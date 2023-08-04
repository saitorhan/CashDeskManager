namespace CashDeskManager.V2.Forms
{
    partial class XtraFormFixedExpense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label expenseTypeLabel;
            System.Windows.Forms.Label currencyUnitLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label fixedExpensePeriodLabel;
            System.Windows.Forms.Label fixedExpensePeriodCustomDayLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormFixedExpense));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.fixedExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenseTypeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.currencyUnitComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.amountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.descriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.startDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.fixedExpensePeriodComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.fixedExpensePeriodCustomDayTextEdit = new DevExpress.XtraEditors.TextEdit();
            expenseTypeLabel = new System.Windows.Forms.Label();
            currencyUnitLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            fixedExpensePeriodLabel = new System.Windows.Forms.Label();
            fixedExpensePeriodCustomDayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedExpenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyUnitComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedExpensePeriodComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedExpensePeriodCustomDayTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // expenseTypeLabel
            // 
            expenseTypeLabel.AutoSize = true;
            expenseTypeLabel.Location = new System.Drawing.Point(12, 148);
            expenseTypeLabel.Name = "expenseTypeLabel";
            expenseTypeLabel.Size = new System.Drawing.Size(61, 13);
            expenseTypeLabel.TabIndex = 10;
            expenseTypeLabel.Text = "Gider Türü:";
            // 
            // currencyUnitLabel
            // 
            currencyUnitLabel.AutoSize = true;
            currencyUnitLabel.Location = new System.Drawing.Point(12, 174);
            currencyUnitLabel.Name = "currencyUnitLabel";
            currencyUnitLabel.Size = new System.Drawing.Size(60, 13);
            currencyUnitLabel.TabIndex = 11;
            currencyUnitLabel.Text = "Para Birimi:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(12, 200);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(40, 13);
            amountLabel.TabIndex = 12;
            amountLabel.Text = "Miktar:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 277);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(52, 13);
            descriptionLabel.TabIndex = 13;
            descriptionLabel.Text = "Açıklama:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(12, 380);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(79, 13);
            startDateLabel.TabIndex = 14;
            startDateLabel.Text = "Başlama Tarihi:";
            // 
            // fixedExpensePeriodLabel
            // 
            fixedExpensePeriodLabel.AutoSize = true;
            fixedExpensePeriodLabel.Location = new System.Drawing.Point(12, 226);
            fixedExpensePeriodLabel.Name = "fixedExpensePeriodLabel";
            fixedExpensePeriodLabel.Size = new System.Drawing.Size(81, 13);
            fixedExpensePeriodLabel.TabIndex = 15;
            fixedExpensePeriodLabel.Text = "Gider Periyodu:";
            // 
            // fixedExpensePeriodCustomDayLabel
            // 
            fixedExpensePeriodCustomDayLabel.AutoSize = true;
            fixedExpensePeriodCustomDayLabel.Location = new System.Drawing.Point(12, 252);
            fixedExpensePeriodCustomDayLabel.Name = "fixedExpensePeriodCustomDayLabel";
            fixedExpensePeriodCustomDayLabel.Size = new System.Drawing.Size(111, 13);
            fixedExpensePeriodCustomDayLabel.TabIndex = 16;
            fixedExpensePeriodCustomDayLabel.Text = "Gider Periyodu (Gün):";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(406, 126);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Kaydet";
            this.barButtonItem1.CausesValidation = true;
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = global::CashDeskManager.V2.Properties.Resources.save_16x16;
            this.barButtonItem1.ImageOptions.LargeImage = global::CashDeskManager.V2.Properties.Resources.save_32x32;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "İptal";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = global::CashDeskManager.V2.Properties.Resources.cancel_16x16;
            this.barButtonItem2.ImageOptions.LargeImage = global::CashDeskManager.V2.Properties.Resources.cancel_32x32;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // fixedExpenseBindingSource
            // 
            this.fixedExpenseBindingSource.DataSource = typeof(CashDeskManager.V2.Entity.Database.FixedExpense);
            // 
            // expenseTypeTextEdit
            // 
            this.expenseTypeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fixedExpenseBindingSource, "ExpenseType", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.expenseTypeTextEdit.Location = new System.Drawing.Point(129, 141);
            this.expenseTypeTextEdit.MenuManager = this.ribbonControl1;
            this.expenseTypeTextEdit.Name = "expenseTypeTextEdit";
            this.expenseTypeTextEdit.Size = new System.Drawing.Size(266, 20);
            this.expenseTypeTextEdit.TabIndex = 11;
            // 
            // currencyUnitComboBoxEdit
            // 
            this.currencyUnitComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fixedExpenseBindingSource, "CurrencyUnit", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.currencyUnitComboBoxEdit.EditValue = CashDeskManager.V2.Entity.Enums.CurrencyUnit.TRY;
            this.currencyUnitComboBoxEdit.Location = new System.Drawing.Point(129, 167);
            this.currencyUnitComboBoxEdit.MenuManager = this.ribbonControl1;
            this.currencyUnitComboBoxEdit.Name = "currencyUnitComboBoxEdit";
            this.currencyUnitComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.currencyUnitComboBoxEdit.Properties.Items.AddRange(new object[] {
            CashDeskManager.V2.Entity.Enums.CurrencyUnit.TRY,
            CashDeskManager.V2.Entity.Enums.CurrencyUnit.USD,
            CashDeskManager.V2.Entity.Enums.CurrencyUnit.EUR});
            this.currencyUnitComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.currencyUnitComboBoxEdit.Size = new System.Drawing.Size(266, 20);
            this.currencyUnitComboBoxEdit.TabIndex = 12;
            this.currencyUnitComboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.currencyUnitComboBoxEdit_SelectedIndexChanged);
            // 
            // amountTextEdit
            // 
            this.amountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fixedExpenseBindingSource, "Amount", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.amountTextEdit.Location = new System.Drawing.Point(129, 193);
            this.amountTextEdit.MenuManager = this.ribbonControl1;
            this.amountTextEdit.Name = "amountTextEdit";
            this.amountTextEdit.Properties.Mask.EditMask = "f2";
            this.amountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.amountTextEdit.Size = new System.Drawing.Size(266, 20);
            this.amountTextEdit.TabIndex = 13;
            // 
            // descriptionMemoEdit
            // 
            this.descriptionMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fixedExpenseBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.descriptionMemoEdit.Location = new System.Drawing.Point(129, 275);
            this.descriptionMemoEdit.MenuManager = this.ribbonControl1;
            this.descriptionMemoEdit.Name = "descriptionMemoEdit";
            this.descriptionMemoEdit.Size = new System.Drawing.Size(266, 96);
            this.descriptionMemoEdit.TabIndex = 14;
            // 
            // startDateDateEdit
            // 
            this.startDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fixedExpenseBindingSource, "StartDate", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.startDateDateEdit.EditValue = null;
            this.startDateDateEdit.Location = new System.Drawing.Point(129, 377);
            this.startDateDateEdit.MenuManager = this.ribbonControl1;
            this.startDateDateEdit.Name = "startDateDateEdit";
            this.startDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateDateEdit.Size = new System.Drawing.Size(266, 20);
            this.startDateDateEdit.TabIndex = 15;
            // 
            // fixedExpensePeriodComboBoxEdit
            // 
            this.fixedExpensePeriodComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fixedExpenseBindingSource, "FixedExpensePeriod", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.fixedExpensePeriodComboBoxEdit.Location = new System.Drawing.Point(129, 219);
            this.fixedExpensePeriodComboBoxEdit.MenuManager = this.ribbonControl1;
            this.fixedExpensePeriodComboBoxEdit.Name = "fixedExpensePeriodComboBoxEdit";
            this.fixedExpensePeriodComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fixedExpensePeriodComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.fixedExpensePeriodComboBoxEdit.Size = new System.Drawing.Size(266, 20);
            this.fixedExpensePeriodComboBoxEdit.TabIndex = 16;
            this.fixedExpensePeriodComboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.fixedExpensePeriodComboBoxEdit_SelectedIndexChanged);
            // 
            // fixedExpensePeriodCustomDayTextEdit
            // 
            this.fixedExpensePeriodCustomDayTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fixedExpenseBindingSource, "FixedExpensePeriodCustomDay", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.fixedExpensePeriodCustomDayTextEdit.Enabled = false;
            this.fixedExpensePeriodCustomDayTextEdit.Location = new System.Drawing.Point(129, 249);
            this.fixedExpensePeriodCustomDayTextEdit.MenuManager = this.ribbonControl1;
            this.fixedExpensePeriodCustomDayTextEdit.Name = "fixedExpensePeriodCustomDayTextEdit";
            this.fixedExpensePeriodCustomDayTextEdit.Size = new System.Drawing.Size(266, 20);
            this.fixedExpensePeriodCustomDayTextEdit.TabIndex = 17;
            // 
            // XtraFormFixedExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(406, 411);
            this.Controls.Add(fixedExpensePeriodCustomDayLabel);
            this.Controls.Add(this.fixedExpensePeriodCustomDayTextEdit);
            this.Controls.Add(fixedExpensePeriodLabel);
            this.Controls.Add(this.fixedExpensePeriodComboBoxEdit);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.startDateDateEdit);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionMemoEdit);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextEdit);
            this.Controls.Add(currencyUnitLabel);
            this.Controls.Add(this.currencyUnitComboBoxEdit);
            this.Controls.Add(expenseTypeLabel);
            this.Controls.Add(this.expenseTypeTextEdit);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("XtraFormFixedExpense.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraFormFixedExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sabit Gider";
            this.Load += new System.EventHandler(this.XtraFormFixedExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedExpenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyUnitComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedExpensePeriodComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedExpensePeriodCustomDayTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.BindingSource fixedExpenseBindingSource;
        private DevExpress.XtraEditors.TextEdit expenseTypeTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit currencyUnitComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit amountTextEdit;
        private DevExpress.XtraEditors.MemoEdit descriptionMemoEdit;
        private DevExpress.XtraEditors.DateEdit startDateDateEdit;
        private DevExpress.XtraEditors.ComboBoxEdit fixedExpensePeriodComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit fixedExpensePeriodCustomDayTextEdit;
    }
}