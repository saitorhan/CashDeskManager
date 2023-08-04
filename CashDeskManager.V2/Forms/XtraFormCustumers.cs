using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using CashDeskManager.V2.Entity;
using CashDeskManager.V2.Entity.Database;
using CashDeskManager.V2.Entity.Enums;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Native;

namespace CashDeskManager.V2.Forms
{
    public partial class XtraFormCustumers : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormCustumers()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            List<Custumer> custumers = CashDeskContext.DeskContext.Custumers.Where(c => c.CashDeskId == GlobalVariables.CurrentCashDesk.Id).OrderBy(c => c.Name).ToList();

            custumers.ForEach(c =>
                {
                    c.NotPayedDebts = CashDeskContext.DeskContext.CustumerDebts.Where(ca => c.Id == ca.CustumerId && ca.PayStatu != CustumerPayStatu.Payed).ToList();

                    c.NotPayedDebts.ForEach(np =>
                    {
                        np.CustumerDibtCollects = CashDeskContext.DeskContext.CustumerDibtCollects
                            .Where(ac => ac.CustumerDibtId == np.Id).ToList();
                    });

                    c.PayedDebts = CashDeskContext.DeskContext.CustumerDebts.Where(ca => c.Id == ca.CustumerId && ca.PayStatu == CustumerPayStatu.Payed).ToList();

                    c.PayedDebts.ForEach(np =>
                    {
                        np.CustumerDibtCollects = CashDeskContext.DeskContext.CustumerDibtCollects
                            .Where(ac => ac.CustumerDibtId == np.Id).ToList();
                    });
                    

                    c.RemainingDebt = CashDeskContext.DeskContext.CustumerDebts.Where(d => d.CustumerId == c.Id && d.RemainingAmount > 0)
                        .Sum(d => (double?)d.RemainingAmount);
                });

            custumerBindingSource.DataSource = custumers;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormCustumer xtraFormCashDesk = new XtraFormCustumer();
            xtraFormCashDesk.ShowDialog();
            if (xtraFormCashDesk.Result)
            {
                RefreshData();
            }
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Custumer custumer = custumerBindingSource.Current as Custumer;
            if (custumer.IsNull())
            {
                return;
            }

            XtraFormCustumer xtraFormCashDesk = new XtraFormCustumer(custumer);
            xtraFormCashDesk.ShowDialog();
            if (xtraFormCashDesk.Result)
            {
                RefreshData();
            }

        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Custumer custumer = custumerBindingSource.Current as Custumer;
            if (custumer.IsNull())
            {
                return;
            }

            if (XtraMessageBox.Show($"<b>{custumer.Name}</b> silinecek. Bu işlem geri alınamaz. Onaylıyor musunuz?",
                    "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DefaultBoolean.True) != DialogResult.Yes)
            {
                return;
            }

            CashDeskContext.DeskContext.Entry(custumer).State = EntityState.Deleted;
            Tuple<bool, string> saveChanges = CashDeskContext.DeskContext.SaveChanges();

            if (saveChanges.Item1)
            {
                XtraMessageBox.Show($"<b>{custumer.Name}</b> silindi.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information, DefaultBoolean.True);
                RefreshData();
            }
            else
            {
                XtraMessageBox.Show($"<b>{custumer.Name}</b> silinemedi.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error, DefaultBoolean.True);
            }
        }

        private void barButtonItemShowDebts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Custumer custumer = custumerBindingSource.Current as Custumer;
            if (custumer.IsNull())
            {
                return;
            }


            XtraFormCustumerDebts xtraFormCustumerDebts = new XtraFormCustumerDebts(custumer);
            xtraFormCustumerDebts.ShowDialog();
            RefreshData();
        }

        private void XtraFormCustumers_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void gridView1_MasterRowExpanded(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e)
        {
            GridView gridViewWelds = sender as GridView;
            GridView gridViewTests = gridViewWelds.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            gridViewTests.MasterRowExpanded += GridViewTestsOnMasterRowExpanded;
            gridViewTests.BeginUpdate();
            gridViewTests.Columns["Id"].Visible = false;
            gridViewTests.Columns["Id"].OptionsColumn.ShowInCustomizationForm = false;
            gridViewTests.Columns["CustumerId"].Visible = false;
            gridViewTests.Columns["CustumerId"].OptionsColumn.ShowInCustomizationForm = false;
            gridViewTests.Columns["PayStatu"].Visible = false;
            gridViewTests.Columns["PayStatu"].OptionsColumn.ShowInCustomizationForm = false;
            gridViewTests.Columns["Custumer"].Visible = false;
            gridViewTests.Columns["Custumer"].OptionsColumn.ShowInCustomizationForm = false;
            gridViewTests.EndUpdate();
        }

        private void GridViewTestsOnMasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            GridView gridView = sender as GridView;
            GridView gridViewTests = gridView.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            gridView.BeginUpdate();
            gridViewTests.Columns["Id"].Visible = false;
            gridViewTests.Columns["Id"].OptionsColumn.ShowInCustomizationForm = false;
            gridViewTests.Columns["CustumerId"].Visible = false;
            gridViewTests.Columns["CustumerId"].OptionsColumn.ShowInCustomizationForm = false;
            gridViewTests.Columns["CustumerDibtId"].Visible = false;
            gridViewTests.Columns["CustumerDibtId"].OptionsColumn.ShowInCustomizationForm = false;
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
            gridView.EndUpdate();
        }
    }
}