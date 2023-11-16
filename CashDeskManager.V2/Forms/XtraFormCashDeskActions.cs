using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CashDeskManager.V2.Entity;
using CashDeskManager.V2.Entity.AppModel;
using CashDeskManager.V2.Entity.Database;
using CashDeskManager.V2.Entity.Enums;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;

namespace CashDeskManager.V2.Forms
{
    public partial class XtraFormCashDeskActions : DevExpress.XtraEditors.XtraForm
    {
        public ActionDirection? actionDirection { get; set; }
        public XtraFormCashDeskActions()
        {
            InitializeComponent();
            actionDirection = null;
        }

        private void RefreshData()
        {
            
            switch (actionDirection)
            {
                case ActionDirection.In:
                    gridControlTotals.DataSource = null;
                    gridControlOuts.DataSource = null;
                    gridControlIns.DataSource = cashDeskActionModelBindingSource;
                    break;
                case ActionDirection.Out:
                    gridControlTotals.DataSource = null;
                    gridControlIns.DataSource = null;
                    gridControlOuts.DataSource = cashDeskActionModelBindingSource;
                    break;
                case null:
                    gridControlIns.DataSource = null;
                    gridControlOuts.DataSource = null;
                    gridControlTotals.DataSource = cashDeskActionModelBindingSource;
                    break;
            }

            List<CashDeskActionModel> cashDeskActionModels = CashDeskContext.DeskContext.Database.SqlQuery<CashDeskActionModel>("select ca.Id, c1.Name cashdesk, ca.CurrencyUnit, ca.Amount, ca.DateTime, ca.Description, ca.BankName, ca.BankBranch,ca.SignDateTime, ca.ExpirtyDateTime,ca.AccountNumber, ca.CheckNumber, ca.CheckOwner, ca.PaymentStatu, ca.PaymentMethod, ca.ActionDirection, ca.Deleted, ca.DeleteTime, cu.Name CustumerName, ca.FixedExpensePayCeshDeskId, ca.DebtPayCashDeskId, ca.MoneyOutCashDeskId, concat(f.ExpenseType, '(', f.Description, ')') fixedExpense from cashdeskactions ca left join cashdesks c1 on ca.CashDeskId = c1.Id left join custumers cu on ca.CustumerId = cu.Id left join fixedexpenses f on ca.FixedExpenseId = f.Id where ca.CashDeskId = {0} and ca.Deleted is null order by ca.Id desc;", GlobalVariables.CurrentCashDesk.Id).ToListAsync().Result;

            foreach (CashDeskActionModel cashDeskActionModel in cashDeskActionModels)
            {
                CashDesk cashDesk = CashDeskContext.DeskContext.CashDesks
                    .FirstOrDefault(c => (new List<int>()
                    {
                        cashDeskActionModel.FixedExpensePayCeshDeskId ?? 0, cashDeskActionModel.DebtPayCashDeskId ?? 0,
                        cashDeskActionModel.MoneyOutCashDeskId ?? 0
                    }).Contains(c.Id));
                if (cashDesk.IsNotNull())
                {
                    cashDeskActionModel.PayedFromCashDeskName = cashDesk.Name;
                }
                

                //if (cashDeskActionModel.FixedExpensePayCeshDeskId != null)
                //{
                //    cashDeskActionModel.PayedFromCashDeskName = CashDeskContext.DeskContext.CashDesks.FirstOrDefault()
                //}
                //else if (cashDeskActionModel.FixedExpensePayCeshDeskId != null)
                //{

                //}
                //else if (cashDeskActionModel.FixedExpensePayCeshDeskId != null)
                //{

                //}
                if (cashDeskActionModel.ActionDirection == ActionDirection.In)
                {
                    cashDeskActionModel.PayedToCashDeskName = CashDeskContext.DeskContext.Database
                        .SqlQuery<string>(
                            "select c.Name from cashdeskactions ca join debtandcredits d on ca.Id = d.ActionId join cashdesks c on d.CashDeskId = c.Id where ca.ActionDirection = 0 and ca.Id = {0}",
                            cashDeskActionModel.Id)
                        .ToListAsync().Result.FirstOrDefault();
                }
                
            }

            cashDeskActionModelBindingSource.DataSource = cashDeskActionModels.Where(c => actionDirection == null || c.ActionDirection == actionDirection).ToList();
            bandedGridView1.BestFitColumns();
            bandedGridView2.BestFitColumns();
            bandedGridView3.BestFitColumns();

        }

        private void barButtonItemCashIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CashDeskAction cashDeskAction = new CashDeskAction();
            cashDeskAction.ActionDirection = ActionDirection.In;
            cashDeskAction.CashDeskId = GlobalVariables.CurrentCashDesk.Id;

            XtraFormAction xtraFormAction = new XtraFormAction(cashDeskAction);
            xtraFormAction.ShowDialog();

            if (xtraFormAction.Result)
            {
                RefreshData();
            }
        }

        private void barButtonItemCashOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MoneyOut cashDeskAction = new MoneyOut();
            cashDeskAction.ActionDirection = ActionDirection.Out;
            cashDeskAction.CashDeskId = GlobalVariables.CurrentCashDesk.Id;

            XtraFormAction xtraFormAction = new XtraFormAction(cashDeskAction);
            xtraFormAction.ShowDialog();


            if (xtraFormAction.Result)
            {
                RefreshData();
            }
        }

        private void barButtonItemCreditIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItemCreditOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CashDeskActionModel cashDeskActionModel = cashDeskActionModelBindingSource.Current as CashDeskActionModel;
            if (cashDeskActionModel.IsNull())
            {
                return;
            }
            if (XtraMessageBox.Show("Kasa hareketi silinecek. Onaylıyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            CashDeskAction firstOrDefault = CashDeskContext.DeskContext.CashDeskActions.FirstOrDefault(c => c.Id == cashDeskActionModel.Id);
            if (firstOrDefault.IsNull())
            {
                RefreshData();
            }

            firstOrDefault.Deleted = true;
            firstOrDefault.DeleteTime = DateTime.Now;
            Tuple<bool, string> saveChanges = CashDeskContext.DeskContext.SaveChanges();
            if (saveChanges.Item1)
            {
                RefreshData();
            }
            else
            {
                XtraMessageBox.Show("Kasa hareketi silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CashDeskActionModel cashDeskActionModel = cashDeskActionModelBindingSource.Current as CashDeskActionModel;
            if (cashDeskActionModel.IsNull())
            {
                return;
            }

            CashDeskAction firstOrDefault = CashDeskContext.DeskContext.CashDeskActions.FirstOrDefault(c => c.Id == cashDeskActionModel.Id);

            //if (firstOrDefault is CreditCardAction)
            //{
            //    CreditCardAction creditCardAction = firstOrDefault as CreditCardAction;
            //    XtraFormCreditCardPay xtraFormCreditCardPay = new XtraFormCreditCardPay(CashDesk, creditCardAction.ActionDirection, creditCardAction);
            //    xtraFormCreditCardPay.ShowDialog();
            //    if (xtraFormCreditCardPay.Result)
            //    {
            //        RefreshData();
            //    }
            //}
            //else if (firstOrDefault is CheckAction)
            //{
            //    CheckAction checkAction = firstOrDefault as CheckAction;
            //}
            //else
            //{
            //    XtraFormCashPay xtraFormCashPay = new XtraFormCashPay(CashDesk, firstOrDefault.ActionDirection, firstOrDefault);
            //    xtraFormCashPay.ShowDialog();
            //    if (xtraFormCashPay.Result)
            //    {
            //        RefreshData();
            //    }
            //}

            XtraFormAction xtraFormAction = new XtraFormAction(firstOrDefault);
            xtraFormAction.ShowDialog();


            if (xtraFormAction.Result)
            {
                RefreshData();
            }
        }

        private void XtraFormCashDeskActions_Load(object sender, System.EventArgs e)
        {
            RefreshData();
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshData();
        }

        private void cashDeskActionModelBindingSource_CurrentChanged(object sender, System.EventArgs e)
        {
            CashDeskActionModel cashDeskActionModel = cashDeskActionModelBindingSource.Current as CashDeskActionModel;
            if (cashDeskActionModel.IsNull())
            {
                return;
            }

            ribbonPageGroupCheck.Visible = cashDeskActionModel.PaymentMethod == PaymentMethod.Check;
        }

        private void barButtonItemApprove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CashDeskActionModel cashDeskActionModel = cashDeskActionModelBindingSource.Current as CashDeskActionModel;
            if (cashDeskActionModel.IsNull() || cashDeskActionModel.PaymentMethod != PaymentMethod.Check)
            {
                return;
            }

            CashDeskAction firstOrDefault = CashDeskContext.DeskContext.CashDeskActions.FirstOrDefault(f => f.Id == cashDeskActionModel.Id);
            if (firstOrDefault.IsNull())
            {
                XtraMessageBox.Show("Kasa hesabı bulunamadı.", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            firstOrDefault.PaymentStatu = PaymentStatu.Approve;
            CashDeskContext.DeskContext.Entry(firstOrDefault).State = EntityState.Modified;

            if (CashDeskContext.DeskContext.SaveChanges().Item1)
            {
                XtraMessageBox.Show("Çek onaylama işlemi başarılı oldu.", "Bilgi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                RefreshData();
            }
            else
            {
                XtraMessageBox.Show("Çek onaylama işlemi başarısız oldu.", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void barButtonItemReject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CashDeskActionModel cashDeskActionModel = cashDeskActionModelBindingSource.Current as CashDeskActionModel;
            if (cashDeskActionModel.IsNull() || cashDeskActionModel.PaymentMethod != PaymentMethod.Check)
            {
                return;
            }

            CashDeskAction firstOrDefault = CashDeskContext.DeskContext.CashDeskActions.FirstOrDefault(f => f.Id == cashDeskActionModel.Id);
            if (firstOrDefault.IsNull())
            {
                XtraMessageBox.Show("Kasa hesabı bulunamadı.", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            firstOrDefault.PaymentStatu = PaymentStatu.Reject;
            CashDeskContext.DeskContext.Entry(firstOrDefault).State = EntityState.Modified;
            if (CashDeskContext.DeskContext.SaveChanges().Item1)
            {
                XtraMessageBox.Show("Çek reddetme işlemi başarılı oldu.", "Bilgi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                RefreshData();
            }
            else
            {
                XtraMessageBox.Show("Çek reddetme işlemi başarısız oldu.", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void barButtonItemPending_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CashDeskActionModel cashDeskActionModel = cashDeskActionModelBindingSource.Current as CashDeskActionModel;
            if (cashDeskActionModel.IsNull() || cashDeskActionModel.PaymentMethod != PaymentMethod.Check)
            {
                return;
            }

            CashDeskAction firstOrDefault = CashDeskContext.DeskContext.CashDeskActions.FirstOrDefault(f => f.Id == cashDeskActionModel.Id);
            if (firstOrDefault.IsNull())
            {
                XtraMessageBox.Show("Kasa hesabı bulunamadı.", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            firstOrDefault.PaymentStatu = PaymentStatu.PendingApprove;
            CashDeskContext.DeskContext.Entry(firstOrDefault).State = EntityState.Modified;
            if (CashDeskContext.DeskContext.SaveChanges().Item1)
            {
                XtraMessageBox.Show("Çek bekleme durumuna getirme işlemi başarılı oldu.", "Bilgi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                RefreshData();
            }
            else
            {
                XtraMessageBox.Show("Çek bekleme durumuna getirme işlemi başarısız oldu.", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void bandedGridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle < 0)
            {
                return;
            }

            BandedGridView gridView = sender as BandedGridView;
            CashDeskActionModel cashDeskActionModel = gridView.GetRow(e.RowHandle) as CashDeskActionModel;

            if (cashDeskActionModel.ActionDirection == ActionDirection.In)
            {
                e.Appearance.BackColor = Color.LimeGreen;
                if (cashDeskActionModel.PaymentMethod == PaymentMethod.Check && cashDeskActionModel.PaymentStatu == PaymentStatu.PendingApprove)
                {
                    e.Appearance.BackColor2 = Color.Yellow;
                }
                else
                {
                    e.Appearance.BackColor2 = Color.White;
                }
            }
            else
            {
                e.Appearance.BackColor2 = Color.OrangeRed;
                if (cashDeskActionModel.PaymentMethod == PaymentMethod.Check && cashDeskActionModel.PaymentStatu == PaymentStatu.PendingApprove)
                {
                    e.Appearance.BackColor = Color.Yellow;
                }
                else
                {
                    e.Appearance.BackColor = Color.White;
                }
            }

            

        }

        private void navigationPane1_SelectedPageIndexChanged(object sender, EventArgs e)
        {
            NavigationPage selectedPage = navigationPane1.SelectedPage as NavigationPage;
            if (selectedPage.IsNull())
            {
                XtraMessageBox.Show("Bilinmeyen hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object selectedPageTag = selectedPage.Tag;
            if (selectedPageTag.IsNull())
            {
                actionDirection = null;
            }
            else
            {
                actionDirection = (ActionDirection)Enum.Parse(typeof(ActionDirection), selectedPageTag.ToString());
            }

            RefreshData();
        }

        private void barButtonItemExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string location = GetSaveLocation("Excel Dosyaları (*.xlsx)|*.xlsx");
            if (location.IsNullOrEmpty())
            {
                XtraMessageBox.Show("Excele aktarma için dosya adı seçilmedi. Excele aktarma yapılamadı.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (actionDirection)
            {
                case ActionDirection.In:
                    gridControlIns.ExportToXlsx(location);
                    break;
                case ActionDirection.Out:
                    gridControlOuts.ExportToXlsx(location);
                    break;
                case null:
                    gridControlTotals.ExportToXlsx(location);
                    break;
            }
        }

        public string GetSaveLocation(string filter)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = filter
            };
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            return null;
        }

        private void barButtonItemPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string location = GetSaveLocation("PDF Dosyaları (*.pdf)|*.pdf");
            switch (actionDirection)
            {
                case ActionDirection.In:
                    gridControlIns.ExportToPdf(location);
                    break;
                case ActionDirection.Out:
                    gridControlOuts.ExportToPdf(location);
                    break;
                case null:
                    gridControlTotals.ExportToPdf(location);
                    break;
            }
        }
    }
}
