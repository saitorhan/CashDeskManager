using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashDeskManager.V2.Entity;
using CashDeskManager.V2.Entity.Database;
using CashDeskManager.V2.Entity.Enums;
using DevExpress.XtraEditors;

namespace CashDeskManager.V2.Forms
{
    public partial class XtraFormAction : DevExpress.XtraEditors.XtraForm
    {
        public CashDeskAction CashDeskAction { get; set; }
        private string[] Banks;
        private string[] BankBranches;
        private int payedFrom = -1;
        public bool Result { get; set; }

        #region Ek sınıflar

        private CustumerDibtCollect custumerDibtCollect;
        private DebtPay debtPay;
        private FixedExpensePay fixedExpensePay;
        private MoneyOut moneyOut;

        #endregion

        public XtraFormAction(CashDeskAction cashDeskAction)
        {
            if (cashDeskAction == null)
            {
                throw new ArgumentNullException();
            }

            CashDeskAction = cashDeskAction;
            InitializeComponent();
            comboBoxEditCurrencyUnit.Properties.Items.AddRange(Enum.GetNames(typeof(CurrencyUnit)));
            comboBoxEditCurrencyUnit.SelectedIndex = 0;
            dateEditDateTime.DateTime = DateTime.Today;

            Banks = CashDeskContext.DeskContext.CashDeskActions.Where(c => c.BankName.Length > 0).Select(c => c.BankName).Distinct().ToArray();
            BankBranches = CashDeskContext.DeskContext.CashDeskActions.Where(c => c.BankBranch.Length > 0).Select(c => c.BankBranch).Distinct().ToArray();

            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(Banks);
            textEditCreditBank.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textEditCreditBank.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textEditCreditBank.MaskBox.AutoCompleteCustomSource = autoCompleteStringCollection;

            textEditCheckBank.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textEditCheckBank.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textEditCheckBank.MaskBox.AutoCompleteCustomSource = autoCompleteStringCollection;

            autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(BankBranches);
            textEditCheckBankBranch.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textEditCheckBankBranch.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textEditCheckBankBranch.MaskBox.AutoCompleteCustomSource = autoCompleteStringCollection;

            cashDeskBindingSource.DataSource = CashDeskContext.DeskContext.CashDesks.ToList();

            #region değerleri girme
            comboBoxEditCurrencyUnit.SelectedIndex = (int)CashDeskAction.CurrencyUnit;
            textEditAmount.Text = CashDeskAction.Amount.ToString("F2");
            dateEditDateTime.DateTime = CashDeskAction.DateTime;
            memoEditDesc.Text = CashDeskAction.Description;
            radioGroupPaymentMethod.SelectedIndex = (int)CashDeskAction.PaymentMethod;
            switch (CashDeskAction.PaymentMethod)
            {
                case PaymentMethod.Cash:

                    break;
                case PaymentMethod.CreditCard:
                    textEditCreditBank.Text = CashDeskAction.BankName;
                    break;
                case PaymentMethod.Check:
                    textEditCheckBank.Text = CashDeskAction.BankName;
                    break;
            }
            dateEditSignDate.DateTime = CashDeskAction.SignDateTime ?? DateTime.Today;
            dateEditExpiriyDate.DateTime = CashDeskAction.ExpirtyDateTime ?? DateTime.Today;
            textEditCheckBankBranch.Text = CashDeskAction.BankBranch;
            textEditCheckAccount.Text = CashDeskAction.AccountNumber;
            textEditCheckNumber.Text = CashDeskAction.CheckNumber;
            textEditCheckOwnerName.Text = CashDeskAction.CheckOwner;

            if (CashDeskAction.Id == 0)
            {
                dateEditDateTime.DateTime = DateTime.Today;
                dateEditExpiriyDate.DateTime = DateTime.Today;
                dateEditSignDate.DateTime = DateTime.Today;
            }

            if (CashDeskAction.ActionDirection == ActionDirection.In)
            {
                labelControlCashDesk.Text = "Ödemeyi Alan Kasa:";
            }

            #endregion değerleri girme

            if (CashDeskAction is CustumerDibtCollect)
            {
                custumerDibtCollect = CashDeskAction as CustumerDibtCollect;
            }
            else if (CashDeskAction is DebtPay)
            {
                debtPay = CashDeskAction as DebtPay;
                payedFrom = debtPay.DebtPayCashDeskId;
            }
            else if (CashDeskAction is FixedExpensePay)
            {
                fixedExpensePay = CashDeskAction as FixedExpensePay;
                payedFrom = fixedExpensePay.FixedExpensePayCeshDeskId;
            }
            else if (CashDeskAction is MoneyOut)
            {
                moneyOut = CashDeskAction as MoneyOut;
                payedFrom = moneyOut.MoneyOutCashDeskId;
            }


        }

        private void barButtonItemCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void radioGroupPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            xtraTabControlExtraInfos.Enabled = radioGroupPaymentMethod.SelectedIndex > 0;
            xtraTabControlExtraInfos.SelectedTabPageIndex = radioGroupPaymentMethod.SelectedIndex > 0 ? radioGroupPaymentMethod.SelectedIndex - 1 : 0;

           xtraTabPageCreditCard.PageVisible = radioGroupPaymentMethod.SelectedIndex == 1;
           xtraTabPageCheck.PageVisible = radioGroupPaymentMethod.SelectedIndex == 2;
        }

        private void textEditAmount_Validating(object sender, CancelEventArgs e)
        {
            if (textEditAmount.Text.ToDoubleOrDefault(-1) < 0)
            {
                e.Cancel = true;
                textEditAmount.ErrorText = "Girilen miktar değerini kontrol ediniz.";
            }
        }

        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            #region temel değerleri ayarla

            CashDeskAction.CurrencyUnit = (CurrencyUnit)comboBoxEditCurrencyUnit.SelectedIndex;
            CashDeskAction.Amount = textEditAmount.Text.ToDouble();
            CashDeskAction.DateTime = dateEditDateTime.DateTime;
            CashDeskAction.Description = memoEditDesc.Text;
            CashDeskAction.PaymentMethod = (PaymentMethod)radioGroupPaymentMethod.SelectedIndex;
            CashDeskAction.BankName = CashDeskAction.PaymentMethod == PaymentMethod.CreditCard ? textEditCreditBank.Text : CashDeskAction.PaymentMethod == PaymentMethod.Check ? textEditCheckBank.Text : String.Empty;
            CashDeskAction.SignDateTime = dateEditSignDate.DateTime;
            CashDeskAction.ExpirtyDateTime = dateEditExpiriyDate.DateTime;
            CashDeskAction.BankBranch = CashDeskAction.PaymentMethod == PaymentMethod.Check ? textEditCheckBankBranch.Text : String.Empty;
            CashDeskAction.AccountNumber = textEditCheckAccount.Text;
            CashDeskAction.CheckNumber = textEditCheckNumber.Text;
            CashDeskAction.CheckOwner = textEditCheckOwnerName.Text;

            if (CashDeskAction.PaymentMethod != PaymentMethod.Check)
            {
                CashDeskAction.ExpirtyDateTime = null;
                CashDeskAction.SignDateTime = null;
                CashDeskAction.PaymentStatu = PaymentStatu.Approve;
                CashDeskAction.AccountNumber = null;
                CashDeskAction.CheckOwner = null;
                CashDeskAction.CheckNumber = null;
            }
            else
            {
                CashDeskAction.PaymentStatu = PaymentStatu.PendingApprove;
            }

            #endregion temel değerleri ayarla

            if (CashDeskAction is CustumerDibtCollect)
            {
                custumerDibtCollect = CashDeskAction as CustumerDibtCollect;
                custumerDibtCollect.GetCollectCashDeskActionId = (gridLookUpEditPayedFrom.EditValue as CashDesk).Id;

                if (custumerDibtCollect.CashDeskId != custumerDibtCollect.GetCollectCashDeskActionId && XtraMessageBox.Show($"{custumerDibtCollect.Amount} {custumerDibtCollect.CurrencyUnit.ToString()} miktar para {GlobalVariables.CurrentCashDesk.Name} hesabına ödenip {(gridLookUpEditPayedFrom.EditValue as CashDesk).Name} kasasına borç olarak yazılacak. Devam edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                {
                    return;
                }

                CustumerDebt custumerDebt = CashDeskContext.DeskContext.CustumerDebts.FirstOrDefault(
                    c => c.Id == custumerDibtCollect.CustumerDibtId);
                if (custumerDebt.RemainingAmount < CashDeskAction.Amount)
                {
                    if (XtraMessageBox.Show("Tahsil edilen miktar kalan borç miktarından fazladır. İşleme devam edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) != DialogResult.Yes)
                    {
                        return;
                    }
                }

                CashDeskContext.DeskContext.Entry(custumerDibtCollect).State =
                    CashDeskAction.Id > 0 ? EntityState.Modified : EntityState.Added;

                Tuple<bool, string> saveChanges = CashDeskContext.DeskContext.SaveChanges();
                Result = saveChanges.Item1;
                if (Result && custumerDibtCollect.CashDeskId != custumerDibtCollect.GetCollectCashDeskActionId)
                {
                    DebtAndCredit debtAndCredit = CashDeskContext.DeskContext.DebtAndCredits.FirstOrDefault(d => d.ActionId == custumerDibtCollect.Id);
                    if (debtAndCredit.IsNull())
                    {
                        debtAndCredit = new DebtAndCredit();
                    }

                    debtAndCredit.CashDeskId = custumerDibtCollect.GetCollectCashDeskActionId ?? 0;
                    debtAndCredit.ActionId = custumerDibtCollect.Id;
                    debtAndCredit.Amount = custumerDibtCollect.Amount;
                    debtAndCredit.CurrencyUnit = custumerDibtCollect.CurrencyUnit;
                    debtAndCredit.DateTime = custumerDibtCollect.DateTime;
                    debtAndCredit.Description = custumerDibtCollect.Description;
                    debtAndCredit.RemainingAmount = custumerDibtCollect.Amount;
                    debtAndCredit.TargetCashDeskId = custumerDibtCollect.CashDeskId;
                    debtAndCredit.TargetName = GlobalVariables.CurrentCashDesk.Name;


                    CashDeskContext.DeskContext.Entry(debtAndCredit).State = debtAndCredit.Id > 0 ? EntityState.Modified : EntityState.Added;
                    CashDeskContext.DeskContext.SaveChanges();
                    Close();
                    return;
                }
                else if (Result)
                {
                    Close();
                    return;
                }

            }
            else if (CashDeskAction is DebtPay)
            {
                debtPay = CashDeskAction as DebtPay;
                debtPay.DebtPayCashDeskId = (gridLookUpEditPayedFrom.EditValue as CashDesk).Id;

                if (debtPay.CashDeskId != debtPay.DebtPayCashDeskId && XtraMessageBox.Show($"{debtPay.Amount} {debtPay.CurrencyUnit.ToString()} miktar para {(gridLookUpEditPayedFrom.EditValue as CashDesk).Name} hesabından ödenip {GlobalVariables.CurrentCashDesk.Name} kasasına borç olarak yazılacak. Devam edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                {
                    return;
                }

                CashDeskContext.DeskContext.Entry(debtPay).State =
                    CashDeskAction.Id > 0 ? EntityState.Modified : EntityState.Added;

                Tuple<bool, string> saveChanges = CashDeskContext.DeskContext.SaveChanges();
                Result = saveChanges.Item1;
                if (Result && debtPay.CashDeskId != debtPay.DebtPayCashDeskId)
                {
                    DebtAndCredit debtAndCredit = CashDeskContext.DeskContext.DebtAndCredits.FirstOrDefault(d => d.ActionId == debtPay.Id);
                    if (debtAndCredit.IsNull())
                    {
                        debtAndCredit = new DebtAndCredit();
                    }

                    debtAndCredit.CashDeskId = debtPay.CashDeskId;
                    debtAndCredit.ActionId = debtPay.Id;
                    debtAndCredit.Amount = debtPay.Amount;
                    debtAndCredit.CurrencyUnit = debtPay.CurrencyUnit;
                    debtAndCredit.DateTime = debtPay.DateTime;
                    debtAndCredit.Description = debtPay.Description;
                    debtAndCredit.RemainingAmount = debtPay.Amount;
                    debtAndCredit.TargetCashDeskId = debtPay.DebtPayCashDeskId;
                    debtAndCredit.TargetName = (gridLookUpEditPayedFrom.EditValue as CashDesk).Name;


                    CashDeskContext.DeskContext.Entry(debtAndCredit).State = debtAndCredit.Id > 0 ? EntityState.Modified : EntityState.Added;
                    CashDeskContext.DeskContext.SaveChanges();
                    Close();
                    return;
                }
                else if (Result)
                {
                    Close();
                    return;
                }


            }
            else if (CashDeskAction is FixedExpensePay)
            {
                fixedExpensePay = CashDeskAction as FixedExpensePay;
                fixedExpensePay.FixedExpensePayCeshDeskId = (gridLookUpEditPayedFrom.EditValue as CashDesk).Id;

                if (fixedExpensePay.CashDeskId != fixedExpensePay.FixedExpensePayCeshDeskId && XtraMessageBox.Show($"{fixedExpensePay.Amount} {fixedExpensePay.CurrencyUnit.ToString()} miktar para {(gridLookUpEditPayedFrom.EditValue as CashDesk).Name} hesabından ödenip {GlobalVariables.CurrentCashDesk.Name} kasasına borç olarak yazılacak. Devam edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                {
                    return;
                }


                CashDeskContext.DeskContext.Entry(fixedExpensePay).State =
                    CashDeskAction.Id > 0 ? EntityState.Modified : EntityState.Added;


                Tuple<bool, string> saveChanges = CashDeskContext.DeskContext.SaveChanges();
                Result = saveChanges.Item1;

                if (Result && fixedExpensePay.CashDeskId != fixedExpensePay.FixedExpensePayCeshDeskId)
                {
                    DebtAndCredit debtAndCredit =
                        CashDeskContext.DeskContext.DebtAndCredits.FirstOrDefault(d =>
                            d.ActionId == fixedExpensePay.Id);
                    if (debtAndCredit.IsNull())
                    {
                        debtAndCredit = new DebtAndCredit();
                    }

                    debtAndCredit.CashDeskId = fixedExpensePay.CashDeskId;
                    debtAndCredit.ActionId = fixedExpensePay.Id;
                    debtAndCredit.Amount = fixedExpensePay.Amount;
                    debtAndCredit.CurrencyUnit = fixedExpensePay.CurrencyUnit;
                    debtAndCredit.DateTime = fixedExpensePay.DateTime;
                    debtAndCredit.Description = fixedExpensePay.Description;
                    debtAndCredit.RemainingAmount = fixedExpensePay.Amount;
                    debtAndCredit.TargetCashDeskId = fixedExpensePay.FixedExpensePayCeshDeskId;
                    debtAndCredit.TargetName = (gridLookUpEditPayedFrom.EditValue as CashDesk).Name;

                    CashDeskContext.DeskContext.Entry(debtAndCredit).State = debtAndCredit.Id > 0 ? EntityState.Modified : EntityState.Added;
                    CashDeskContext.DeskContext.SaveChanges();
                    Close();
                    return;
                }
                else if (Result)
                {
                    Close();
                    return;
                }

            }
            else if (CashDeskAction is MoneyOut)
            {
                moneyOut = CashDeskAction as MoneyOut;
                moneyOut.MoneyOutCashDeskId = (gridLookUpEditPayedFrom.EditValue as CashDesk).Id;

                if (moneyOut.CashDeskId != moneyOut.MoneyOutCashDeskId && XtraMessageBox.Show($"{moneyOut.Amount} {moneyOut.CurrencyUnit.ToString()} miktar para {(gridLookUpEditPayedFrom.EditValue as CashDesk).Name} hesabından ödenip {GlobalVariables.CurrentCashDesk.Name} kasasına borç olarak yazılacak. Devam edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                {
                    return;
                }


                CashDeskContext.DeskContext.Entry(moneyOut).State =
                    CashDeskAction.Id > 0 ? EntityState.Modified : EntityState.Added;


                Tuple<bool, string> saveChanges = CashDeskContext.DeskContext.SaveChanges();
                Result = saveChanges.Item1;
                if (Result && moneyOut.CashDeskId != moneyOut.MoneyOutCashDeskId)
                {

                    DebtAndCredit debtAndCredit =
                        CashDeskContext.DeskContext.DebtAndCredits.FirstOrDefault(d =>
                            d.ActionId == moneyOut.Id);
                    if (debtAndCredit.IsNull())
                    {
                        debtAndCredit = new DebtAndCredit();
                    }

                    debtAndCredit.CashDeskId = moneyOut.CashDeskId;
                    debtAndCredit.ActionId = moneyOut.Id;
                    debtAndCredit.Amount = moneyOut.Amount;
                    debtAndCredit.CurrencyUnit = moneyOut.CurrencyUnit;
                    debtAndCredit.DateTime = moneyOut.DateTime;
                    debtAndCredit.Description = moneyOut.Description;
                    debtAndCredit.RemainingAmount = moneyOut.Amount;
                    debtAndCredit.TargetCashDeskId = moneyOut.MoneyOutCashDeskId;
                    debtAndCredit.TargetName = (gridLookUpEditPayedFrom.EditValue as CashDesk).Name;

                    CashDeskContext.DeskContext.Entry(debtAndCredit).State = debtAndCredit.Id > 0 ? EntityState.Modified : EntityState.Added;
                    CashDeskContext.DeskContext.SaveChanges();
                    Close();
                    return;
                }
                else if (Result)
                {
                    Close();
                    return;
                }
            }
            else
            {
                CashDeskAction.GetCollectCashDeskActionId = (gridLookUpEditPayedFrom.EditValue as CashDesk).Id;

                if (CashDeskAction.CashDeskId != CashDeskAction.GetCollectCashDeskActionId && XtraMessageBox.Show($"{CashDeskAction.Amount} {CashDeskAction.CurrencyUnit.ToString()} miktar para {GlobalVariables.CurrentCashDesk.Name} hesabına ödenip {(gridLookUpEditPayedFrom.EditValue as CashDesk).Name} kasasına borç olarak yazılacak. Devam edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                {
                    return;
                }

                CashDeskContext.DeskContext.Entry(CashDeskAction).State =
                    CashDeskAction.Id > 0 ? EntityState.Modified : EntityState.Added;


                Tuple<bool, string> saveChanges = CashDeskContext.DeskContext.SaveChanges();
                Result = saveChanges.Item1;
                if (Result && CashDeskAction.CashDeskId != CashDeskAction.GetCollectCashDeskActionId)
                {
                    DebtAndCredit debtAndCredit = CashDeskContext.DeskContext.DebtAndCredits.FirstOrDefault(d => d.ActionId == CashDeskAction.Id);
                    if (debtAndCredit.IsNull())
                    {
                        debtAndCredit = new DebtAndCredit();
                    }

                    debtAndCredit.CashDeskId = CashDeskAction.GetCollectCashDeskActionId ?? 0;
                    debtAndCredit.ActionId = CashDeskAction.Id;
                    debtAndCredit.Amount = CashDeskAction.Amount;
                    debtAndCredit.CurrencyUnit = CashDeskAction.CurrencyUnit;
                    debtAndCredit.DateTime = CashDeskAction.DateTime;
                    debtAndCredit.Description = CashDeskAction.Description;
                    debtAndCredit.RemainingAmount = CashDeskAction.Amount;
                    debtAndCredit.TargetCashDeskId = CashDeskAction.CashDeskId;
                    debtAndCredit.TargetName = GlobalVariables.CurrentCashDesk.Name;


                    CashDeskContext.DeskContext.Entry(debtAndCredit).State = debtAndCredit.Id > 0 ? EntityState.Modified : EntityState.Added;
                    CashDeskContext.DeskContext.SaveChanges();
                    Close();
                    return;
                }
                else if (Result)
                {
                    Close();
                    return;
                }
            }

            XtraMessageBox.Show(
                $"Kasaya para {(CashDeskAction.ActionDirection == ActionDirection.Out ? "çıkışı" : "girişi")} işlemi başarısız oldu.",
                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void XtraFormAction_Load(object sender, EventArgs e)
        {
            foreach (CashDesk cashDesk in cashDeskBindingSource.DataSource as List<CashDesk>)
            {
                if (cashDesk.Id == (payedFrom <= 0 ? GlobalVariables.CurrentCashDesk.Id : payedFrom))
                {
                    gridLookUpEditPayedFrom.EditValue = cashDesk;
                }
            }
        }
    }
}