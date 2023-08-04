using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using CashDeskManager.V2.Entity;
using CashDeskManager.V2.Entity.Database;
using CashDeskManager.V2.Entity.Enums;
using DevExpress.XtraEditors;

namespace CashDeskManager.V2.Forms
{
    public partial class XtraFormFixedExpense : DevExpress.XtraEditors.XtraForm
    {
        private FixedExpense FixedExpense;
        public bool Result { get; set; }
        public XtraFormFixedExpense()
        {
            InitializeComponent();

            Enum.GetValues(typeof(FixedExpensePeriod)).Cast<FixedExpensePeriod>().ForEach(s =>
            {
                fixedExpensePeriodComboBoxEdit.Properties.Items.Add(s.ToStringF());
            });

            fixedExpensePeriodComboBoxEdit.SelectedIndex = 2;
        }

        public XtraFormFixedExpense(FixedExpense fixedExpense)
        {
            InitializeComponent();

            Enum.GetValues(typeof(FixedExpensePeriod)).Cast<FixedExpensePeriod>().ForEach(s =>
            {
                fixedExpensePeriodComboBoxEdit.Properties.Items.Add(s.ToStringF());
            });
            

            FixedExpense = fixedExpense;
            fixedExpenseBindingSource.DataSource = FixedExpense;

            
            currencyUnitComboBoxEdit.SelectedIndex = (int) fixedExpense.CurrencyUnit;
            fixedExpensePeriodComboBoxEdit.SelectedIndex = (int) fixedExpense.FixedExpensePeriod;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.FixedExpense.IsNull())
            {
                this.FixedExpense = new FixedExpense();
            }

            FixedExpense.CashDeskId = GlobalVariables.CurrentCashDesk.Id;
            FixedExpense.Amount = amountTextEdit.Text.ToDouble();
            FixedExpense.CurrencyUnit = (CurrencyUnit)currencyUnitComboBoxEdit.SelectedItem;
            FixedExpense.Description = descriptionMemoEdit.Text;
            FixedExpense.ExpenseType = expenseTypeTextEdit.Text;
            FixedExpense.FixedExpensePeriod = (FixedExpensePeriod)fixedExpensePeriodComboBoxEdit.SelectedIndex;
            FixedExpense.FixedExpensePeriodCustomDay =
                fixedExpensePeriodCustomDayTextEdit.Text.ToNullableInt32OrDefault();
            FixedExpense.StartDate = startDateDateEdit.DateTime;

            if (FixedExpense.Id <= 0)
            {
                FixedExpense.NextDate = FixedExpense.StartDate;

                while (FixedExpense.NextDate < DateTime.Today)
                {
                    switch (FixedExpense.FixedExpensePeriod)
                    {
                        case FixedExpensePeriod.Daily:
                            FixedExpense.NextDate = FixedExpense.NextDate.Value.AddDays(1);
                            FixedExpense.FixedExpensePeriodCustomDay = 1;
                            break;
                        case FixedExpensePeriod.Weekly:
                            FixedExpense.NextDate = FixedExpense.NextDate.Value.AddDays(7);
                            FixedExpense.FixedExpensePeriodCustomDay = 7;
                            break;
                        case FixedExpensePeriod.Monthly:
                            FixedExpense.NextDate = FixedExpense.NextDate.Value.AddMonths(1);
                            FixedExpense.FixedExpensePeriodCustomDay = 30;
                            break;
                        case FixedExpensePeriod.Yearly:
                            FixedExpense.NextDate = FixedExpense.NextDate.Value.AddYears(1);
                            FixedExpense.FixedExpensePeriodCustomDay = 365;
                            break;
                        case FixedExpensePeriod.CustomDays:
                            FixedExpense.NextDate = FixedExpense.NextDate.Value.AddDays(FixedExpense.FixedExpensePeriodCustomDay??0);
                            break;
                        default:
                            break;
                    }
                }
            }

            CashDeskContext.DeskContext.Entry(FixedExpense).State =
                FixedExpense.Id > 0 ? EntityState.Modified : EntityState.Added;

            Tuple<bool, string> saveChanges = CashDeskContext.DeskContext.SaveChanges();
            Result = saveChanges.Item1;

            if (Result)
            {
                Close();
            }
            else
            {
                XtraMessageBox.Show("Sabit gider kaydedilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void currencyUnitComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CurrencyUnit currencyUnit = (CurrencyUnit)currencyUnitComboBoxEdit.SelectedItem;

            //switch (currencyUnit)
            //{
            //    case CurrencyUnit.TRY:
            //        amountTextEdit.Properties.Mask.Culture = new CultureInfo("tr-TR");
            //        break;
            //    case CurrencyUnit.USD:
            //        amountTextEdit.Properties.Mask.Culture = new CultureInfo("en-US");
            //        break;
            //    case CurrencyUnit.EUR:
            //        amountTextEdit.Properties.Mask.Culture = new CultureInfo("fr-FR");
            //        break;
            //    default:
            //        amountTextEdit.Properties.Mask.Culture = new CultureInfo("tr-TR");
            //        break;
            //}
        }

        private void XtraFormFixedExpense_Load(object sender, EventArgs e)
        {
            
        }

        private void fixedExpensePeriodComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            FixedExpensePeriod period = (FixedExpensePeriod)fixedExpensePeriodComboBoxEdit.SelectedIndex;
            fixedExpensePeriodCustomDayTextEdit.Enabled = period == FixedExpensePeriod.CustomDays;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}