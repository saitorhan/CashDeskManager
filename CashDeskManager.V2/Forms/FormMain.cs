using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CashDeskManager.V2.Entity;
using CashDeskManager.V2.Entity.Database;
using CashDeskManager.V2.Entity.Enums;
using CashDeskManager.V2.Reports;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace CashDeskManager.V2.Forms
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        bool dbConnected;
        public FormMain(bool dbConnected)
        {
            InitializeComponent();
            this.dbConnected = dbConnected;
        }

        private void accordionControlElementCashDesk_Click(object sender, System.EventArgs e)
        {
            XtraForm form = new XtraFormCashDesks();
            ShowNewForm(ref form, false);
        }

        private void ShowNewForm(ref XtraForm form, bool requireCash = true)
        {
            if (!dbConnected)
            {
                return;
            }

            if (requireCash && GlobalVariables.CurrentCashDesk.IsNull())
            {
                XtraMessageBox.Show("İşlem yapmak için uygun kasa seçilmedi.\n<b>Aktif Kasa Ayarla</b> butonunu kullanarak kasa ayarlayınız.", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, DefaultBoolean.True);
                return;
            }
            XtraForm ff = form;
            Form firstOrDefault = MdiChildren.FirstOrDefault(f => f.Name == ff.Name);
            if (firstOrDefault.IsNotNull())
            {
                firstOrDefault.BringToFront();
                return;
            }

            ff.MdiParent = this;
            ff.WindowState = FormWindowState.Maximized;
            ff.Show();
        }

        private void accordionControlElementCustumers_Click(object sender, System.EventArgs e)
        {
            XtraForm form = new XtraFormCustumers();
            ShowNewForm(ref form);
        }

        private void accordionControlElementFixedExpense_Click(object sender, System.EventArgs e)
        {
            XtraForm form = new XtraFormFixedExpenses();
            ShowNewForm(ref form);
        }

        private void accordionControlElementCashDeskActions_Click(object sender, System.EventArgs e)
        {
            XtraForm form = new XtraFormCashDeskActions();
            ShowNewForm(ref form);
        }

        private void accordionControlElementDebtsCredits_Click(object sender, System.EventArgs e)
        {

            XtraForm form = new XtraFormDebtsCredits();
            ShowNewForm(ref form);
        }

        private void accordionControlElementCashDeskStatus_Click(object sender, System.EventArgs e)
        {
            XtraReportGeneral xtraReportGeneral = new XtraReportGeneral();
            //XtraForm form = new XtraFormCashDeskInfos(xtraFormSelectCashDesk.CashDesk);
            //ShowNewForm(ref form);
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            if (!dbConnected)
            {
                accordionControlElement1.Visible = false;
                accordionControlElement3.Expanded = true;
                groupControl1.Visible = false;
                return;
            }

            if (Properties.Settings.Default.ActiveCashDesk == 0)
            {
                labelControlActiveCashDesk.Text = "Aktif Kasa Ayarlanmadı";
                simpleButtonSetCashDesk.Text = "Aktif Kasa Ayarla";
            }
            else
            {
                GlobalVariables.CurrentCashDesk =
                    CashDeskContext.DeskContext.CashDesks.FirstOrDefault(c =>
                        c.Id == Properties.Settings.Default.ActiveCashDesk);

                if (GlobalVariables.CurrentCashDesk.IsNotNull())
                {
                    simpleButtonSetCashDesk.Text = "Aktif Kasayı Değiştir";
                    labelControlActiveCashDesk.Text = GlobalVariables.CurrentCashDesk.Name;
                    this.Text =$"Kasa Takip Yazılımı (Aktif Kasa: {GlobalVariables.CurrentCashDesk.Name})";
                    labelControlActiveCashDesk.ToolTip = GlobalVariables.CurrentCashDesk.Description;
                    tileControl1.Visible = true;
                }
            }
        }

        private void simpleButtonSetCashDesk_Click(object sender, System.EventArgs e)
        {
            XtraFormSelectCashDesk xtraFormSelectCashDesk = new XtraFormSelectCashDesk();
            xtraFormSelectCashDesk.ShowDialog();
            if (xtraFormSelectCashDesk.CashDesk.IsNull())
            {
                XtraMessageBox.Show("İşlem yapmak için uygun kasa seçilmedi.", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            simpleButtonSetCashDesk.Text = "Aktif Kasayı Değiştir";
            this.Text =$"Kasa Takip Yazılımı (Aktif Kasa: {GlobalVariables.CurrentCashDesk.Name})";
            labelControlActiveCashDesk.Text = GlobalVariables.CurrentCashDesk.Name;
            labelControlActiveCashDesk.ToolTip = GlobalVariables.CurrentCashDesk.Description;
            Properties.Settings.Default.ActiveCashDesk = GlobalVariables.CurrentCashDesk.Id;
            Properties.Settings.Default.Save();
            MdiChildren.ForEach(f => f.Close());
            tileControl1.Visible = false;
            tileControl1.Visible = true;
        }

        private void xtraTabbedMdiManager1_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            tileControl1.Visible = MdiChildren.Length == 0;
        }

        private void xtraTabbedMdiManager1_PageAdded(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {

            tileControl1.Visible = MdiChildren.Length == 0;
        }

        private void tileControl1_VisibleChanged(object sender, System.EventArgs e)
        {
            if (!tileControl1.Visible)
            {
                return;
            }

            List<CashDeskAction> cashDeskActions = CashDeskContext.DeskContext.CashDeskActions.Where(c => c.CashDeskId == GlobalVariables.CurrentCashDesk.Id).ToList();

            #region giriş

            tileItemTotalIn.Elements[1].Text = String.Format(new CultureInfo("tr-TR"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.In && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.TRY)
                .Sum(c => c.Amount));
            tileItemTotalIn.Elements[2].Text = String.Format(new CultureInfo("en-US"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.In && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.USD)
                .Sum(c => c.Amount));
            tileItemTotalIn.Elements[3].Text = String.Format(new CultureInfo("fr-FR"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.In && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.EUR)
                .Sum(c => c.Amount));


            tileItemTotalCashIn.Elements[1].Text = String.Format(new CultureInfo("tr-TR"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.In && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.TRY && c.PaymentMethod == PaymentMethod.Cash)
                .Sum(c => c.Amount));
            tileItemTotalCashIn.Elements[2].Text = String.Format(new CultureInfo("en-US"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.In && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.USD && c.PaymentMethod == PaymentMethod.Cash)
                .Sum(c => c.Amount));
            tileItemTotalCashIn.Elements[3].Text = String.Format(new CultureInfo("fr-FR"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.In && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.EUR && c.PaymentMethod == PaymentMethod.Cash)
                .Sum(c => c.Amount));


            tileItemTotalCardIn.Elements[1].Text = String.Format(new CultureInfo("tr-TR"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.In && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.TRY && c.PaymentMethod == PaymentMethod.CreditCard)
                .Sum(c => c.Amount));
            tileItemTotalCardIn.Elements[2].Text = String.Format(new CultureInfo("en-US"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.In && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.USD && c.PaymentMethod == PaymentMethod.CreditCard)
                .Sum(c => c.Amount));
            tileItemTotalCardIn.Elements[3].Text = String.Format(new CultureInfo("fr-FR"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.In && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.EUR && c.PaymentMethod == PaymentMethod.CreditCard)
                .Sum(c => c.Amount));


            tileItemTotalCheckIn.Elements[1].Text = String.Format(new CultureInfo("tr-TR"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.In && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.TRY && c.PaymentMethod == PaymentMethod.Check)
                .Sum(c => c.Amount));
            tileItemTotalCheckIn.Elements[2].Text = String.Format(new CultureInfo("en-US"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.In && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.USD && c.PaymentMethod == PaymentMethod.Check)
                .Sum(c => c.Amount));
            tileItemTotalCheckIn.Elements[3].Text = String.Format(new CultureInfo("fr-FR"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.In && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.EUR && c.PaymentMethod == PaymentMethod.Check)
                .Sum(c => c.Amount));

            #endregion giriş

            #region çıkış

            tileItemTotalOut.Elements[1].Text = String.Format(new CultureInfo("tr-TR"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.Out && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.TRY)
                .Sum(c => c.Amount));
            tileItemTotalOut.Elements[2].Text = String.Format(new CultureInfo("en-US"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.Out && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.USD)
                .Sum(c => c.Amount));
            tileItemTotalOut.Elements[3].Text = String.Format(new CultureInfo("fr-FR"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.Out && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.EUR)
                .Sum(c => c.Amount));


            tileItemTotalCashOut.Elements[1].Text = String.Format(new CultureInfo("tr-TR"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.Out && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.TRY && c.PaymentMethod == PaymentMethod.Cash)
                .Sum(c => c.Amount));
            tileItemTotalCashOut.Elements[2].Text = String.Format(new CultureInfo("en-US"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.Out && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.USD && c.PaymentMethod == PaymentMethod.Cash)
                .Sum(c => c.Amount));
            tileItemTotalCashOut.Elements[3].Text = String.Format(new CultureInfo("fr-FR"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.Out && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.EUR && c.PaymentMethod == PaymentMethod.Cash)
                .Sum(c => c.Amount));


            tileItemTotalCardOut.Elements[1].Text = String.Format(new CultureInfo("tr-TR"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.Out && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.TRY && c.PaymentMethod == PaymentMethod.CreditCard)
                .Sum(c => c.Amount));
            tileItemTotalCardOut.Elements[2].Text = String.Format(new CultureInfo("en-US"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.Out && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.USD && c.PaymentMethod == PaymentMethod.CreditCard)
                .Sum(c => c.Amount));
            tileItemTotalCardOut.Elements[3].Text = String.Format(new CultureInfo("fr-FR"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.Out && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.EUR && c.PaymentMethod == PaymentMethod.CreditCard)
                .Sum(c => c.Amount));


            tileItemTotalCheckOut.Elements[1].Text = String.Format(new CultureInfo("tr-TR"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.Out && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.TRY && c.PaymentMethod == PaymentMethod.Check)
                .Sum(c => c.Amount));
            tileItemTotalCheckOut.Elements[2].Text = String.Format(new CultureInfo("en-US"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.Out && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.USD && c.PaymentMethod == PaymentMethod.Check)
                .Sum(c => c.Amount));
            tileItemTotalCheckOut.Elements[3].Text = String.Format(new CultureInfo("fr-FR"), "{0:c2}", cashDeskActions.Where(c => c.ActionDirection == ActionDirection.Out && c.Deleted == null && c.CurrencyUnit == CurrencyUnit.EUR && c.PaymentMethod == PaymentMethod.Check)
                .Sum(c => c.Amount));

            #endregion çıkış
        }

        private void accordionControlElementBackUp_Click(object sender, EventArgs e)
        {
            string constring = ConfigurationManager.ConnectionStrings["CashDeskContext"].ConnectionString;
            xtraSaveFileDialog1.FileName = $"{DateTime.Now:yyyMMdd_HHmmss}.sql";
            if (xtraSaveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(xtraSaveFileDialog1.FileName);
                            conn.Close();
                        }
                    }
                    XtraMessageBox.Show("Yedekleme işlemi başarıyla tamamlandı.", "Yedekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    XtraMessageBox.Show("Yedekleme işlemi başarısız oldu.", "Yedekleme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void accordionControlElementFromOtherCashes_Click(object sender, EventArgs e)
        {
            XtraForm formFromOtherCashes = new XtraFormFromOtherCashes();
            ShowNewForm(ref formFromOtherCashes);
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            Process.Start("https://saitorhan.com");
        }

        private void accordionControlElementLinkedIn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/saitorhan/");
        }

        private void accordionControlElementTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.twitter.com/saitorhan/");
        }

        private void accordionControlElementYouTube_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/saitorhan/");
        }
    }
}
