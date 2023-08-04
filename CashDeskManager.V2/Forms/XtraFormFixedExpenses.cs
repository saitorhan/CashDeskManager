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
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace CashDeskManager.V2.Forms
{
    public partial class XtraFormFixedExpenses : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormFixedExpenses()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            List<FixedExpense> fixedExpenses = CashDeskContext.DeskContext.FixedExpenses.Where(f => f.CashDeskId == GlobalVariables.CurrentCashDesk.Id).ToList();
            fixedExpenses.ForEach(f =>
            {
                f.FixedExpensePays = CashDeskContext.DeskContext.FixedExpensePays
                    .Where(fe => fe.FixedExpenseId == f.Id).ToList();
                f.FixedExpensePays.ForEach(fp =>
                {
                    fp.CashDeskPayFrom =
                        CashDeskContext.DeskContext.CashDesks.FirstOrDefault(c =>
                            c.Id == fp.FixedExpensePayCeshDeskId);
                });
            });
            fixedExpenseBindingSource.DataSource = fixedExpenses;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormFixedExpense xtraFormCashDesk = new XtraFormFixedExpense();
            xtraFormCashDesk.ShowDialog();
            if (xtraFormCashDesk.Result)
            {
                RefreshData();
            }
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FixedExpense cashDesk = fixedExpenseBindingSource.Current as FixedExpense;
            if (cashDesk.IsNull())
            {
                return;
            }

            XtraFormFixedExpense xtraFormCashDesk = new XtraFormFixedExpense(cashDesk);
            xtraFormCashDesk.ShowDialog();
            if (xtraFormCashDesk.Result)
            {
                RefreshData();
            }

        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FixedExpense fixedExpense = fixedExpenseBindingSource.Current as FixedExpense;
            if (fixedExpense.IsNull())
            {
                return;
            }

            if (XtraMessageBox.Show($"<b>{fixedExpense.Description}</b> ve varsa daha önce yapılan ödeme bilgileri silinecek. Bu işlem geri alınamaz. Onaylıyor musunuz?",
                    "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DefaultBoolean.True) != DialogResult.Yes)
            {
                return;
            }

            CashDeskContext.DeskContext.Entry(fixedExpense).State = EntityState.Deleted;
            Tuple<bool, string> saveChanges = CashDeskContext.DeskContext.SaveChanges();

            if (saveChanges.Item1)
            {
                IQueryable<FixedExpensePay> fixedExpensePays = CashDeskContext.DeskContext.FixedExpensePays.Where(c => c.FixedExpenseId == fixedExpense.Id);
                CashDeskContext.DeskContext.FixedExpensePays.RemoveRange(fixedExpensePays);
                CashDeskContext.DeskContext.SaveChanges();
                XtraMessageBox.Show($"<b>{fixedExpense.Description}</b> silindi.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information, DefaultBoolean.True);
                RefreshData();
            }
            else
            {
                XtraMessageBox.Show($"<b>{fixedExpense.Description}</b> silinemedi.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error, DefaultBoolean.True);
            }
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ColumnView columnView = sender as ColumnView;
            if (e.Column.FieldName == "Amount" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
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

        private void barButtonItemPay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FixedExpense fixedExpense = fixedExpenseBindingSource.Current as FixedExpense;
            if (fixedExpense.IsNull())
            {
                return;
            }

            FixedExpensePay cashDeskAction = new FixedExpensePay();
            cashDeskAction.ActionDirection = ActionDirection.Out;
            cashDeskAction.CashDeskId = GlobalVariables.CurrentCashDesk.Id;
            cashDeskAction.FixedExpenseId = fixedExpense.Id;

            XtraFormAction xtraFormAction = new XtraFormAction(cashDeskAction);
            xtraFormAction.ShowDialog();

            if (xtraFormAction.Result)
            {
                RefreshData();
            }

        }

        private void XtraFormFixedExpenses_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void gridView1_MasterRowExpanded(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e)
        {
            GridView gridView = sender as GridView;
            GridView gridViewTests = gridView.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            gridView.BeginUpdate();
            gridViewTests.Columns["Id"].Visible = false;
            gridViewTests.Columns["Id"].OptionsColumn.ShowInCustomizationForm = false;
            gridViewTests.Columns["CashDeskId"].Visible = false;
            gridViewTests.Columns["CashDeskId"].OptionsColumn.ShowInCustomizationForm = false;
            gridViewTests.Columns["Deleted"].Visible = false;
            gridViewTests.Columns["Deleted"].OptionsColumn.ShowInCustomizationForm = false;
            gridViewTests.Columns["DeleteTime"].Visible = false;
            gridViewTests.Columns["DeleteTime"].OptionsColumn.ShowInCustomizationForm = false;
            gridViewTests.Columns["PaymentMethod"].Visible = false;
            gridViewTests.Columns["PaymentMethod"].OptionsColumn.ShowInCustomizationForm = false;
            gridViewTests.Columns["ActionDirection"].Visible = false;
            gridViewTests.Columns["ActionDirection"].OptionsColumn.ShowInCustomizationForm = false;
            gridViewTests.Columns["PaymentStatu"].Visible = false;
            gridViewTests.Columns["PaymentStatu"].OptionsColumn.ShowInCustomizationForm = false;
            gridViewTests.Columns["FixedExpenseId"].Visible = false;
            gridViewTests.Columns["FixedExpenseId"].OptionsColumn.ShowInCustomizationForm = false;
            gridViewTests.Columns["FixedExpensePayCeshDeskId"].Visible = false;
            gridViewTests.Columns["FixedExpensePayCeshDeskId"].OptionsColumn.ShowInCustomizationForm = false;
            gridView.EndUpdate();
        }
    }
}