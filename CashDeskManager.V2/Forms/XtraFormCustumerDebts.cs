using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CashDeskManager.Forms;
using CashDeskManager.V2.Entity;
using CashDeskManager.V2.Entity.Database;
using CashDeskManager.V2.Entity.Enums;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace CashDeskManager.V2.Forms
{
    public partial class XtraFormCustumerDebts : DevExpress.XtraEditors.XtraForm
    {
        private Custumer Custumer { get; }

        public XtraFormCustumerDebts(Custumer custumer)
        {
            Custumer = custumer;
            InitializeComponent();
            Text = $"{Text} ({Custumer.Name})";
            RefreshData();
        }

        private void RefreshData()
        {
            List<CustumerDebt> custumerDebts = CashDeskContext.DeskContext.CustumerDebts
                .Where(c => c.CustumerId == Custumer.Id).ToList();

            custumerDebts.ForEach(cd =>
                {
                    cd.CustumerDibtCollects = CashDeskContext.DeskContext.CustumerDibtCollects
                        .Where(c => c.CustumerDibtId == cd.Id).ToList();
                });

            custumerDebtBindingSource.DataSource = custumerDebts;
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

        private void barButtonItemNewDebt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormCustumerDebt custumerDebt = new XtraFormCustumerDebt(Custumer);
            custumerDebt.ShowDialog();
            if (custumerDebt.Result)
            {
                RefreshData();
            }
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CustumerDebt custumerDebt = custumerDebtBindingSource.Current as CustumerDebt;
            if (custumerDebt.IsNull())
            {
                return;
            }

            if (custumerDebt.PayStatu != CustumerPayStatu.NotPayed)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Ödemesi tamamlanan veya kısmi tahsilat yapılan borç bilgisi düzenlenecek. Devam etmek istiyor musunuz?", "Uyarı",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }
            }

            XtraFormCustumerDebt custumerDebtForm = new XtraFormCustumerDebt(custumerDebt);
            custumerDebtForm.ShowDialog();
            if (custumerDebtForm.Result)
            {
                RefreshData();
            }
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CustumerDebt custumerDebt = custumerDebtBindingSource.Current as CustumerDebt;
            if (custumerDebt.IsNull())
            {
                return;
            }

            if (custumerDebt.PayStatu != CustumerPayStatu.NotPayed)
            {
                XtraMessageBox.Show("Ödemesi tamamlanan veya kısmi tahsilat yapılan borç bilgisi silinemez veya düzenlenemez.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (XtraMessageBox.Show($"<b>{custumerDebt.Amount} {custumerDebt.CurrencyUnit}</b> borç silinecek. Bu işlem geri alınamaz. Onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DefaultBoolean.True) != DialogResult.Yes)
            {
                return;
            }

            CashDeskContext.DeskContext.Entry(custumerDebt).State = EntityState.Deleted;
            Tuple<bool, string> saveChanges = CashDeskContext.DeskContext.SaveChanges();
            if (saveChanges.Item1)
            {
                RefreshData();
            }
            else
            {
                XtraMessageBox.Show("Borç silinemedi. Hata oluştu.", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void barButtonItemCash_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CustumerDebt custumerDebt = custumerDebtBindingSource.Current as CustumerDebt;
            if (custumerDebt.IsNull())
            {
                return;
            }

            CustumerDibtCollect cashDeskAction = new CustumerDibtCollect();
            cashDeskAction.ActionDirection = ActionDirection.In;
            cashDeskAction.CashDeskId = GlobalVariables.CurrentCashDesk.Id;
            cashDeskAction.CustumerId = custumerDebt.CustumerId;
            cashDeskAction.CustumerDibtId = custumerDebt.Id;
            cashDeskAction.CurrencyUnit = custumerDebt.CurrencyUnit;
            cashDeskAction.Amount = custumerDebt.RemainingAmount;

            XtraFormAction xtraFormAction = new XtraFormAction(cashDeskAction);
            xtraFormAction.ShowDialog();

            if (xtraFormAction.Result)
            {
                double amount = xtraFormAction.textEditAmount.Text.ToDouble();
                custumerDebt.RemainingAmount -= amount;
                custumerDebt.PayStatu = custumerDebt.RemainingAmount <= 0
                    ? CustumerPayStatu.Payed
                    : CustumerPayStatu.PartialPayed;
                CashDeskContext.DeskContext.Entry(custumerDebt).State = EntityState.Modified;
                CashDeskContext.DeskContext.SaveChanges();
            }

            XtraMessageBox.Show($"Müşteri borç tahsilatı başarı{(xtraFormAction.Result ? "lı" : "sız")} oldu.",
                xtraFormAction.Result ? "Bilgi" : "Hata", MessageBoxButtons.OK,
                xtraFormAction.Result ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (xtraFormAction.Result)
            {
                RefreshData();
            }
        }

        private void barButtonItemAllCashes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void custumerDebtBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            CustumerDebt custumerDebt = custumerDebtBindingSource.Current as CustumerDebt;
            if (custumerDebt.IsNull())
            {
                return;
            }

            barButtonItemCash.Visibility = custumerDebt.PayStatu != CustumerPayStatu.Payed
                ? BarItemVisibility.Always
                : BarItemVisibility.Never;
        }
    }
}