using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using CashDeskManager.V2.Entity;
using CashDeskManager.V2.Entity.Database;
using DevExpress.XtraEditors;

namespace CashDeskManager.V2.Forms
{
    public partial class XtraFormCustumer : DevExpress.XtraEditors.XtraForm
    {
        private Custumer Custumer;
        public bool Result { get; set; }
        public XtraFormCustumer()
        {
            InitializeComponent();
        }

        public XtraFormCustumer(Custumer custumer)
        {
            InitializeComponent();
            Custumer = custumer;
            custumerBindingSource.DataSource = Custumer;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Custumer.IsNull())
            {
                this.Custumer = new Custumer
                {
                    RecordDate = DateTime.Now,
                    CashDeskId = GlobalVariables.CurrentCashDesk.Id
                };
            }


            Custumer.Name = nameTextEdit.Text;
            Custumer.Address = addressMemoEdit.Text;
            Custumer.Description = descriptionMemoEdit.Text;
            Custumer.PhoneNumber = phoneNumberTextEdit.Text;

            if (CashDeskContext.DeskContext.Custumers.Any(c => c.Id != Custumer.Id && c.Name == Custumer.Name))
            {
                if (XtraMessageBox.Show($"{Custumer.Name} isimli müşteri zaten var. Devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
            }

            CashDeskContext.DeskContext.Entry(Custumer).State =
                Custumer.Id > 0 ? EntityState.Modified : EntityState.Added;

            Tuple<bool, string> saveChanges = CashDeskContext.DeskContext.SaveChanges();
            Result = saveChanges.Item1;

            if (Result)
            {
                Close();
            }
            else
            {
                XtraMessageBox.Show("Müşteri hesabı kaydedilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}