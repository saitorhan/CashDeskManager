namespace CashDeskManager.V2.Forms
{
    partial class XtraFormDebtCredit
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormDebtCredit));
            this.gridLookUpEditCashDesks = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cashDeskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCancel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditTargetName = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEditCurrencyUnit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.memoEditDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePickerExpiriyDate = new System.Windows.Forms.DateTimePicker();
            this.checkEditHasExpiriy = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditCashDesks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashDeskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTargetName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditCurrencyUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHasExpiriy.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLookUpEditCashDesks
            // 
            this.gridLookUpEditCashDesks.Location = new System.Drawing.Point(107, 136);
            this.gridLookUpEditCashDesks.Name = "gridLookUpEditCashDesks";
            this.gridLookUpEditCashDesks.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.gridLookUpEditCashDesks.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close, "Seçimi Temizle", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.gridLookUpEditCashDesks.Properties.DataSource = this.cashDeskBindingSource;
            this.gridLookUpEditCashDesks.Properties.NullText = "Borç bir kasaya ise kasayı seçiniz";
            this.gridLookUpEditCashDesks.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEditCashDesks.Size = new System.Drawing.Size(363, 20);
            this.gridLookUpEditCashDesks.TabIndex = 0;
            this.gridLookUpEditCashDesks.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.gridLookUpEditCashDesks_ButtonClick);
            this.gridLookUpEditCashDesks.EditValueChanged += new System.EventHandler(this.gridLookUpEditCashDesks_EditValueChanged);
            // 
            // cashDeskBindingSource
            // 
            this.cashDeskBindingSource.DataSource = typeof(CashDeskManager.V2.Entity.Database.CashDesk);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemSave,
            this.barButtonItemCancel});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(482, 126);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItemSave
            // 
            this.barButtonItemSave.Caption = "Kaydet";
            this.barButtonItemSave.CausesValidation = true;
            this.barButtonItemSave.Id = 1;
            this.barButtonItemSave.ImageOptions.LargeImage = global::CashDeskManager.V2.Properties.Resources.save_32x32;
            this.barButtonItemSave.Name = "barButtonItemSave";
            this.barButtonItemSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSave_ItemClick);
            // 
            // barButtonItemCancel
            // 
            this.barButtonItemCancel.Caption = "İptal";
            this.barButtonItemCancel.Id = 2;
            this.barButtonItemCancel.ImageOptions.LargeImage = global::CashDeskManager.V2.Properties.Resources.cancel_32x32;
            this.barButtonItemCancel.Name = "barButtonItemCancel";
            this.barButtonItemCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCancel_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemCancel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "İşlemler";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 139);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Alacaklı Kasa:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 165);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Alacak Adı:";
            // 
            // textEditTargetName
            // 
            this.textEditTargetName.Location = new System.Drawing.Point(107, 162);
            this.textEditTargetName.MenuManager = this.ribbonControl1;
            this.textEditTargetName.Name = "textEditTargetName";
            this.textEditTargetName.Size = new System.Drawing.Size(363, 20);
            this.textEditTargetName.TabIndex = 2;
            // 
            // comboBoxEditCurrencyUnit
            // 
            this.comboBoxEditCurrencyUnit.Location = new System.Drawing.Point(107, 188);
            this.comboBoxEditCurrencyUnit.MenuManager = this.ribbonControl1;
            this.comboBoxEditCurrencyUnit.Name = "comboBoxEditCurrencyUnit";
            this.comboBoxEditCurrencyUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditCurrencyUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditCurrencyUnit.Size = new System.Drawing.Size(363, 20);
            this.comboBoxEditCurrencyUnit.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 191);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Para Birimi:";
            // 
            // textEditAmount
            // 
            this.textEditAmount.Location = new System.Drawing.Point(107, 214);
            this.textEditAmount.Name = "textEditAmount";
            this.textEditAmount.Properties.Mask.EditMask = "f2";
            this.textEditAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditAmount.Size = new System.Drawing.Size(363, 20);
            this.textEditAmount.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 217);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Miktar:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 246);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Tarih:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(107, 240);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(363, 21);
            this.dateTimePickerDate.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 296);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Açıklama:";
            // 
            // memoEditDescription
            // 
            this.memoEditDescription.Location = new System.Drawing.Point(107, 294);
            this.memoEditDescription.MenuManager = this.ribbonControl1;
            this.memoEditDescription.Name = "memoEditDescription";
            this.memoEditDescription.Size = new System.Drawing.Size(363, 87);
            this.memoEditDescription.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 273);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(57, 13);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Vade Tarihi:";
            // 
            // dateTimePickerExpiriyDate
            // 
            this.dateTimePickerExpiriyDate.Enabled = false;
            this.dateTimePickerExpiriyDate.Location = new System.Drawing.Point(135, 267);
            this.dateTimePickerExpiriyDate.Name = "dateTimePickerExpiriyDate";
            this.dateTimePickerExpiriyDate.Size = new System.Drawing.Size(335, 21);
            this.dateTimePickerExpiriyDate.TabIndex = 4;
            // 
            // checkEditHasExpiriy
            // 
            this.checkEditHasExpiriy.Location = new System.Drawing.Point(107, 267);
            this.checkEditHasExpiriy.MenuManager = this.ribbonControl1;
            this.checkEditHasExpiriy.Name = "checkEditHasExpiriy";
            this.checkEditHasExpiriy.Properties.Caption = "";
            this.checkEditHasExpiriy.Size = new System.Drawing.Size(30, 20);
            this.checkEditHasExpiriy.TabIndex = 7;
            this.checkEditHasExpiriy.ToolTip = "Vade tarihini aktifleştirmek için seçiniz.";
            this.checkEditHasExpiriy.CheckedChanged += new System.EventHandler(this.checkEditHasExpiriy_CheckedChanged);
            // 
            // XtraFormDebtCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(482, 396);
            this.Controls.Add(this.checkEditHasExpiriy);
            this.Controls.Add(this.memoEditDescription);
            this.Controls.Add(this.dateTimePickerExpiriyDate);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.comboBoxEditCurrencyUnit);
            this.Controls.Add(this.textEditAmount);
            this.Controls.Add(this.textEditTargetName);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.gridLookUpEditCashDesks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("XtraFormDebtCredit.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraFormDebtCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alacak - Borç Kaydı";
            this.Load += new System.EventHandler(this.XtraFormDebtCredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditCashDesks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashDeskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTargetName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditCurrencyUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHasExpiriy.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditCashDesks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource cashDeskBindingSource;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSave;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCancel;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditTargetName;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditCurrencyUnit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditAmount;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit memoEditDescription;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpiriyDate;
        private DevExpress.XtraEditors.CheckEdit checkEditHasExpiriy;
    }
}