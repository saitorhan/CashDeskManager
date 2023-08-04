using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using Configuration = CashDeskManager.V2.Migrations.Configuration;

namespace CashDeskManager.V2.Forms
{
    public partial class XtraFormMySqlConnection : DevExpress.XtraEditors.XtraForm
    {
        public bool Result { get; private set; }
        public XtraFormMySqlConnection()
        {
            InitializeComponent();
        }

        private void XtraFormMySqlConnection_Load(object sender, EventArgs e)
        {
            System.Configuration.Configuration openExeConfiguration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringsSection connectionStringsSection = (ConnectionStringsSection)openExeConfiguration.GetSection("connectionStrings");
            if (connectionStringsSection != null)
            {
                string connectionString = connectionStringsSection.ConnectionStrings["CashDeskContext"].ConnectionString;

                MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder(connectionString);

                textEditServer.Text = mySqlConnectionStringBuilder.Server;
                textEditPort.Text = mySqlConnectionStringBuilder.Port.ToString();
                textEditUser.Text = mySqlConnectionStringBuilder.UserID;
                textEditPassword.Text = mySqlConnectionStringBuilder.Password;
                textEditDatabase.Text = mySqlConnectionStringBuilder.Database;
            }
        }

        private void barButtonItemCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItemTest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MySqlConnectionStringBuilder mySqlConnectionStringBuilder =
                new MySqlConnectionStringBuilder
                {
                    Server = textEditServer.Text,
                    Port = Convert.ToUInt32(textEditPort.Text),
                    UserID = textEditUser.Text,
                    Password = textEditPassword.Text,
                    Database = textEditDatabase.Text
                };

            string connectionString = mySqlConnectionStringBuilder.GetConnectionString(true);
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            try
            {
                mySqlConnection.Open();
                Result = true;
            }
            catch (Exception exception)
            {
                Result = false;
            }
            finally
            {
                if (mySqlConnection.State != ConnectionState.Closed)
                {
                    mySqlConnection.Close();
                }
            }

            XtraMessageBox.Show($"Bağlantı testi başarı{(Result ? "lı" : "sız")} oldu.", "Bilgilendirme",
                MessageBoxButtons.OK, Result ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (Result && e.Item.Name != "barButtonItemTest")
            {
                System.Configuration.Configuration openExeConfiguration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConnectionStringsSection connectionStringsSection = (ConnectionStringsSection)openExeConfiguration.GetSection("connectionStrings");
                if (connectionStringsSection != null)
                {
                    connectionStringsSection.ConnectionStrings["CashDeskContext"].ConnectionString = connectionString;
                        
                    openExeConfiguration.Save();
                    ConfigurationManager.RefreshSection("connectionStrings");

                    Result = true;
                    Close();
                }
            }
        }
    }
}