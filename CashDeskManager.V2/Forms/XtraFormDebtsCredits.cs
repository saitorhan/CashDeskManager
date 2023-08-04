using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CashDeskManager.V2.Entity;
using CashDeskManager.V2.Entity.Database;
using CashDeskManager.V2.Entity.Enums;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace CashDeskManager.V2.Forms
{
    public partial class XtraFormDebtsCredits : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormDebtsCredits()
        {
            InitializeComponent();
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ColumnView columnView = sender as ColumnView;
            if ((e.Column.FieldName == "Amount" || e.Column.FieldName == "RemainingAmount") && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                CurrencyUnit currencyUnit = (CurrencyUnit)columnView.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyUnit");
                double d = e.Value.ToDouble();
                switch (currencyUnit)
                {
                    case CurrencyUnit.TRY:
                        e.DisplayText = String.Format(new CultureInfo("tr-TR"), "{0:c2}", d);
                        break;
                    case CurrencyUnit.USD:
                        e.DisplayText = String.Format(new CultureInfo("en-US"), "{0:c2}", d);
                        break;
                    case CurrencyUnit.EUR:
                        e.DisplayText = String.Format(new CultureInfo("fr-FR"), "{0:c2}", d);
                        break;
                    default:
                        e.DisplayText = String.Format(new CultureInfo("tr-TR"), "{0:c2}", d);
                        break;
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormDebtCredit xtraFormCashDesk = new XtraFormDebtCredit(GlobalVariables.CurrentCashDesk.Id);
            xtraFormCashDesk.ShowDialog();
            if (xtraFormCashDesk.Result)
            {
                RefreshData();
            }
        }
        private void RefreshData()
        {
            List<CashDesk> cashDesks = CashDeskContext.DeskContext.CashDesks.ToList();
            List<DebtAndCredit> debtAndCredits = CashDeskContext.DeskContext.DebtAndCredits.Where(d => d.CashDeskId == GlobalVariables.CurrentCashDesk.Id || d.TargetCashDeskId == GlobalVariables.CurrentCashDesk.Id).ToList();
            debtAndCredits.ForEach(d =>
                {
                    if (d.TargetCashDeskId != null)
                    {
                        d.TargetCashDesk =
                            cashDesks.FirstOrDefault(c => c.Id == d.TargetCashDeskId);
                    }

                    d.CashDesk =
                        cashDesks.FirstOrDefault(c => c.Id == d.CashDeskId);
                });
            debtsCreditsBindingSource.DataSource = debtAndCredits;
            gridControl1.RefreshDataSource();
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DebtAndCredit cashDesk = debtsCreditsBindingSource.Current as DebtAndCredit;
            if (cashDesk.IsNull())
            {
                return;
            }

            XtraFormDebtCredit xtraFormCashDesk = new XtraFormDebtCredit(cashDesk);
            xtraFormCashDesk.ShowDialog();
            if (xtraFormCashDesk.Result)
            {
                RefreshData();
            }

        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DebtAndCredit cashDesk = debtsCreditsBindingSource.Current as DebtAndCredit;
            if (cashDesk.IsNull())
            {
                return;
            }

            if (XtraMessageBox.Show($"<b>{cashDesk.Description}</b> silinecek. Bu işlem geri alınamaz.\nOnaylıyor musunuz?",
                    "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DefaultBoolean.True) != DialogResult.Yes)
            {
                return;
            }

            CashDeskContext.DeskContext.Entry(cashDesk).State = EntityState.Deleted;
            Tuple<bool, string> saveChanges = CashDeskContext.DeskContext.SaveChanges();

            if (saveChanges.Item1)
            {
                XtraMessageBox.Show($"<b>{cashDesk.Description}</b> silindi.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information, DefaultBoolean.True);
                RefreshData();
            }
            else
            {
                XtraMessageBox.Show($"<b>{cashDesk.Description}</b> silinemedi.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error, DefaultBoolean.True);
            }
        }

        private void barButtonItemPay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DebtAndCredit debtAndCredit = debtsCreditsBindingSource.Current as DebtAndCredit;
            if (debtAndCredit.IsNull())
            {
                return;
            }
             

            DebtPay debtPay = new DebtPay();
            debtPay.DebtId = debtAndCredit.Id;
            debtPay.ActionDirection = ActionDirection.Out;
            debtPay.CashDeskId = GlobalVariables.CurrentCashDesk.Id;

            XtraFormAction xtraFormAction = new XtraFormAction(debtPay);
            xtraFormAction.ShowDialog();

            if (xtraFormAction.Result)
            {
                RefreshData();
            }
        }

        private void barButtonItemResfresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshData();
        }

        private void XtraFormDebtsCredits_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void debtsCreditsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DebtAndCredit debtAndCredit = debtsCreditsBindingSource.Current as DebtAndCredit;
            if (debtAndCredit.IsNull())
            {
                return;
            }
            
                barButtonItemPayCreditCard.Enabled = debtAndCredit.RecordType.Equals("Borç");

        }
    }
}