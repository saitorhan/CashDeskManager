using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using CashDeskManager.Forms;
using CashDeskManager.V2.Entity;
using CashDeskManager.V2.Entity.Database;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace CashDeskManager.V2.Forms
{
    public partial class XtraFormCashDesks : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormCashDesks()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            cashDeskBindingSource.DataSource = CashDeskContext.DeskContext.CashDesks.ToList();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormCashDesk xtraFormCashDesk = new XtraFormCashDesk();
            xtraFormCashDesk.ShowDialog();
            if (xtraFormCashDesk.Result)
            {
                RefreshData();
            }
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CashDesk cashDesk = cashDeskBindingSource.Current as CashDesk;

            if (cashDesk.IsNull())
            {
                return;
            }

            if (cashDesk.Name == "Şirket Hesabı")
            {
                XtraMessageBox.Show($"Şirket Hesabı değiştirilemez veya silinemez.", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop, DefaultBoolean.True);
                return;
            }

            XtraFormCashDesk xtraFormCashDesk = new XtraFormCashDesk(cashDesk);
            xtraFormCashDesk.ShowDialog();
            if (xtraFormCashDesk.Result)
            {
                RefreshData();
            }

        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CashDesk cashDesk = cashDeskBindingSource.Current as CashDesk;
            if (cashDesk.IsNull())
            {
                return;
            }

            if (cashDesk.Name == "Şirket Hesabı")
            {
                XtraMessageBox.Show($"Şirket Hesabı değiştirilemez veya silinemez.", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop, DefaultBoolean.True);
                return;
            }

            if (XtraMessageBox.Show($"<b>{cashDesk.Name}</b> silinecek. Bu işlem geri alınamaz. Onaylıyor musunuz?",
                    "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DefaultBoolean.True) != DialogResult.Yes)
            {
                return;
            }

            CashDeskContext.DeskContext.Entry(cashDesk).State = EntityState.Deleted;
            Tuple<bool, string> saveChanges = CashDeskContext.DeskContext.SaveChanges();

            if (saveChanges.Item1)
            {
                XtraMessageBox.Show($"<b>{cashDesk.Name}</b> silindi.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information, DefaultBoolean.True);
                RefreshData();
            }
            else
            {
                XtraMessageBox.Show($"<b>{cashDesk.Name}</b> silinemedi.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error, DefaultBoolean.True);
            }
        }
    }
}