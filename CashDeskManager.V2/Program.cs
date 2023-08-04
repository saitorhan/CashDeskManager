using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using CashDeskManager.V2.Entity;
using CashDeskManager.V2.Entity.Database;
using CashDeskManager.V2.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;

namespace CashDeskManager.V2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] ///
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            Thread.CurrentThread.CurrentUICulture =
                Thread.CurrentThread.CurrentCulture =
                    new CultureInfo("tr-TR") {NumberFormat = {NumberDecimalSeparator = ",", NumberGroupSeparator = "."}};

            bool databaseExist = CheckDataBase();
            if (!databaseExist)
            {
                if (XtraMessageBox.Show("Veri tabanı oluşturulamadı. Veri tabanı oluşturulmadan sistem kullanılamaz.\nVeri tabanı ayarlarını şimdi yapmak ister misiniz?", "Uyarı",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    if (XtraMessageBox.Show("Geliştiricinin iletişim bilgilerine ulaşmak için uygulamayı işlem ekranları olmadan açmak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Application.Run(new FormMain(false));
                        return;
                    }

                    return;
                }

                XtraFormMySqlConnection xtraFormMySql = new XtraFormMySqlConnection();
                xtraFormMySql.ShowDialog();
                if (!xtraFormMySql.Result)
                {
                    if (XtraMessageBox.Show("Geliştiricinin iletişim bilgilerine ulaşmak için uygulamayı işlem ekranları olmadan açmak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Application.Run(new FormMain(false));
                        return;
                    }
                    return;
                }
                else
                {
                    Application.Restart();
                }
            }


            Application.Run(new FormMain(true));
        }

        private static bool CheckDataBase()
        {
            try
            {

                CashDeskContext.DeskContext.Database.CreateIfNotExists();

                CashDeskContext.DeskContext.CashDesks.AddOrUpdate(c => c.Name, new CashDesk
                {
                    Name = "Şirket Hesabı",
                    Description = "Ana şirket hesabı",
                    CreatedDateTime = DateTime.Now
                });
                CashDeskContext.DeskContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
