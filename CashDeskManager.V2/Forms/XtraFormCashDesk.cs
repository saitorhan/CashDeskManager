using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashDeskManager.V2.Entity;
using CashDeskManager.V2.Entity.Database;
using DevExpress.XtraEditors;

namespace CashDeskManager.Forms
{
    public partial class XtraFormCashDesk : DevExpress.XtraEditors.XtraForm
    {
        private CashDesk CashDesk;
        public bool Result { get; set; }
        public XtraFormCashDesk()
        {
            InitializeComponent();
            createdDateTimeDateEdit.DateTime = DateTime.Today;
        }

        public XtraFormCashDesk(CashDesk cashDesk)
        {
            InitializeComponent();
            CashDesk = cashDesk;
            cashDeskBindingSource.DataSource = CashDesk;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.CashDesk.IsNull())
            {
                this.CashDesk = new CashDesk();
            }


            CashDesk.Name = nameTextEdit.Text;
            CashDesk.CreatedDateTime = createdDateTimeDateEdit.DateTime;
            CashDesk.Description = descriptionMemoEdit.Text;

            CashDeskContext.DeskContext.Entry(CashDesk).State =
                CashDesk.Id > 0 ? EntityState.Modified : EntityState.Added;

            Tuple<bool, string> saveChanges = CashDeskContext.DeskContext.SaveChanges();
            Result = saveChanges.Item1;

            if (Result)
            {
                Close();
            }
            else
            {
                XtraMessageBox.Show("Kasa hesabı kaydedilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}