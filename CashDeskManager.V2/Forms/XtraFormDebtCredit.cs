using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using CashDeskManager.V2.Entity;
using CashDeskManager.V2.Entity.Database;
using CashDeskManager.V2.Entity.Enums;
using DevExpress.XtraEditors;

namespace CashDeskManager.V2.Forms
{
    public partial class XtraFormDebtCredit : DevExpress.XtraEditors.XtraForm
    {
        private DebtAndCredit debtAndCredit;

        public bool Result { get; set; }
        private bool editForm;

        public XtraFormDebtCredit(int cashDeskId)
        {
            InitializeComponent();
            debtAndCredit = new DebtAndCredit
            {
                CashDeskId = cashDeskId
            };

            GetCashDesks();
            comboBoxEditCurrencyUnit.Properties.Items.AddRange(Enum.GetValues(typeof(CurrencyUnit)));
        }

        public XtraFormDebtCredit(DebtAndCredit debtAndCredit)
        {
            this.debtAndCredit = debtAndCredit;
            InitializeComponent();
            GetCashDesks();
            comboBoxEditCurrencyUnit.Properties.Items.AddRange(Enum.GetValues(typeof(CurrencyUnit)));
            editForm = true;
        }

        private void GetCashDesks()
        {
            cashDeskBindingSource.DataSource = CashDeskContext.DeskContext.CashDesks.Where(c => c.Id != GlobalVariables.CurrentCashDesk.Id).ToList();
        }

        private void barButtonItemCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void gridLookUpEditCashDesks_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridLookUpEdit edit = sender as GridLookUpEdit;
            if(e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Close)
            {
                edit.Text = String.Empty;
                edit.EditValue = null;
                edit.Properties.View.ClearSelection();
            }
        }

        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            debtAndCredit.CashDeskId = GlobalVariables.CurrentCashDesk.Id;
            debtAndCredit.TargetName = textEditTargetName.Text;
            debtAndCredit.CurrencyUnit = (CurrencyUnit) comboBoxEditCurrencyUnit.SelectedItem;
            debtAndCredit.Amount = Convert.ToDouble(textEditAmount.Text);
            debtAndCredit.DateTime = dateTimePickerDate.Value;
            debtAndCredit.ExpiryDateTime = checkEditHasExpiriy.Checked ? dateTimePickerExpiriyDate.Value : (DateTime?) null;
            debtAndCredit.Description = memoEditDescription.Text;
            debtAndCredit.TargetCashDeskId = (gridLookUpEditCashDesks.EditValue as CashDesk)?.Id;
            debtAndCredit.RemainingAmount = debtAndCredit.Amount;

            if (debtAndCredit.TargetCashDeskId == null)
            {
                debtAndCredit.TargetCashDesk = null;
            }

            CashDeskContext.DeskContext.Entry(debtAndCredit).State =
                editForm ? EntityState.Modified : EntityState.Added;
            Tuple<bool, string> saveChanges = CashDeskContext.DeskContext.SaveChanges();
            Result = saveChanges.Item1;

            if (Result)
            {
                Close();
            }
            else
            {
                XtraMessageBox.Show("Kayıt işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XtraFormDebtCredit_Load(object sender, EventArgs e)
        {
            if (editForm)
            {
                textEditTargetName.Text = debtAndCredit.TargetName;
                comboBoxEditCurrencyUnit.SelectedIndex = (int) debtAndCredit.CurrencyUnit;
                textEditAmount.Text = debtAndCredit.Amount.ToString("f2");
                dateTimePickerDate.Value = debtAndCredit.DateTime;
                memoEditDescription.Text = debtAndCredit.Description;
            
                foreach (CashDesk cashDesk in cashDeskBindingSource.DataSource as List<CashDesk>)
                {
                    if (cashDesk.Id == debtAndCredit.TargetCashDeskId)
                    {
                        gridLookUpEditCashDesks.EditValue = cashDesk;
                        break;
                    }
                }
            }
            else
            {
                comboBoxEditCurrencyUnit.SelectedIndex = 0;
            }
        }

        private void gridLookUpEditCashDesks_EditValueChanged(object sender, EventArgs e)
        {
            CashDesk cashDesk = gridLookUpEditCashDesks.EditValue as CashDesk;
            if (cashDesk.IsNotNull())
            {
                textEditTargetName.ReadOnly = true;
                textEditTargetName.Text = cashDesk.Name;
            }
            else
            {
                textEditTargetName.ReadOnly = false;

            }
        }

        private void checkEditHasExpiriy_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerExpiriyDate.Enabled = checkEditHasExpiriy.Checked;
        }
    }
}