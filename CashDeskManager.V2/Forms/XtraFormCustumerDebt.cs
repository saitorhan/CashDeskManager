using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashDeskManager.V2.Entity;
using CashDeskManager.V2.Entity.Database;
using CashDeskManager.V2.Entity.Enums;
using DevExpress.XtraEditors;

namespace CashDeskManager.Forms
{
    public partial class XtraFormCustumerDebt : DevExpress.XtraEditors.XtraForm
    {
        public bool Result { get; set; }
        public CustumerDebt CustumerDebt { get; private set; }
        public double OriginalAmaunt { get; set; }

        public XtraFormCustumerDebt(Custumer custumer)
        {
            CustumerDebt = new CustumerDebt { CustumerId = custumer.Id };
            InitializeComponent();

            comboBoxEditCurrency.Properties.Items.AddRange(Enum.GetValues(typeof(CurrencyUnit)));
        }
        public XtraFormCustumerDebt(CustumerDebt custumerDebt)
        {
            CustumerDebt = custumerDebt;
            OriginalAmaunt = CustumerDebt.Amount;
            InitializeComponent();
            comboBoxEditCurrency.Properties.Items.AddRange(Enum.GetValues(typeof(CurrencyUnit)));
            foreach (CurrencyUnit propertiesItem in comboBoxEditCurrency.Properties.Items)
            {
                if (CustumerDebt.CurrencyUnit == propertiesItem)
                {
                    comboBoxEditCurrency.SelectedItem = propertiesItem;
                    break;
                }
            }

            textEditAmount.Text = CustumerDebt.Amount.ToString();
            memoEditDesc.Text = CustumerDebt.Description;
            dateEditDateTime.DateTime = CustumerDebt.DateTime;
        }

        private void textEditAmount_Validating(object sender, CancelEventArgs e)
        {
            MemoEdit memoEdit = sender as MemoEdit;
            if (memoEdit != null)
            {
                if (memoEdit.Text.IsNullOrEmpty())
                {
                    e.Cancel = true;
                    memoEdit.ErrorText = "Açıklama boş bırakılamaz.";
                }
            }
            else
            {
                TextEdit textEdit = sender as TextEdit;
                if (textEdit.Text.IsNullOrEmpty())
                {
                    e.Cancel = true;
                    textEdit.ErrorText = "Miktar boş bırakılamaz.";
                }
            }
        }

        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            CustumerDebt.Amount = Convert.ToDouble(textEditAmount.Text);
            CustumerDebt.CurrencyUnit = (CurrencyUnit)comboBoxEditCurrency.SelectedItem;
            CustumerDebt.Description = memoEditDesc.Text;
            CustumerDebt.DateTime = dateEditDateTime.DateTime;
            CustumerDebt.RemainingAmount += (CustumerDebt.Amount - OriginalAmaunt);

            if (CustumerDebt.Id == 0 || CustumerDebt.PayStatu == CustumerPayStatu.NotPayed)
            {
                CustumerDebt.RemainingAmount = CustumerDebt.Amount;
                CustumerDebt.PayStatu = CustumerPayStatu.NotPayed;
            }

            CashDeskContext.DeskContext.Entry(CustumerDebt).State = CustumerDebt.Id < 1 ? EntityState.Added : EntityState.Modified;
            Tuple<bool, string> saveChanges = CashDeskContext.DeskContext.SaveChanges();
            Result = saveChanges.Item1;
            if (Result)
            {
                Close();
            }
            else
            {
                XtraMessageBox.Show($"Müşteri borcu kaydedilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void XtraFormCustumerDebt_Load(object sender, EventArgs e)
        {
            comboBoxEditCurrency.SelectedIndex = 0;
        }

        private void comboBoxEditCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CurrencyUnit currencyUnit = (CurrencyUnit)comboBoxEditCurrency.SelectedItem;

            //switch (currencyUnit)
            //{
            //    case CurrencyUnit.TRY:
            //        textEditAmount.Properties.Mask.Culture = new CultureInfo("tr-TR");
            //        break;
            //    case CurrencyUnit.USD:
            //        textEditAmount.Properties.Mask.Culture = new CultureInfo("en-US");
            //        break;
            //    case CurrencyUnit.EUR:
            //        textEditAmount.Properties.Mask.Culture = new CultureInfo("fr-FR");
            //        break;
            //    default:
            //        textEditAmount.Properties.Mask.Culture = new CultureInfo("tr-TR");
            //        break;
            //}
        }

        private void barButtonItemCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}