using System.Linq;
using System.Windows.Forms;
using CashDeskManager.V2.Entity;
using CashDeskManager.V2.Entity.Database;
using DevExpress.XtraEditors;

namespace CashDeskManager.V2.Forms
{
    public partial class XtraFormSelectCashDesk : DevExpress.XtraEditors.XtraForm
    {
        public CashDesk CashDesk { get; set; }
        public XtraFormSelectCashDesk()
        {
            InitializeComponent();

            cashDeskBindingSource.DataSource = CashDeskContext.DeskContext.CashDesks.ToList();
        }

        private void barButtonItemCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CashDesk = null;
            Close();
        }

        private void barButtonItemOk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CashDesk = gridLookUpEditCashDesks.EditValue as CashDesk;
            if (CashDesk.IsNull())
            {
                XtraMessageBox.Show("Kasa hareketleri ekranı için işlem yapılacak kasa seçilmelidir.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                GlobalVariables.CurrentCashDesk = CashDesk;
                Close();
            }
        }
    }
}