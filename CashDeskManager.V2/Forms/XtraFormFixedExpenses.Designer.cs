namespace CashDeskManager.V2.Forms
{
    partial class XtraFormFixedExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormFixedExpenses));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemNew = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemPay = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemPayCash = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCheck = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.fixedExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colExpenseType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFixedExpensePeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFixedExpensePeriodCustomDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNextDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedExpenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemNew,
            this.barButtonItemEdit,
            this.barButtonItemDelete,
            this.barButtonItemPay,
            this.barButtonItemPayCash,
            this.barButtonItemCheck});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1172, 95);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItemNew
            // 
            this.barButtonItemNew.Caption = "Yeni";
            this.barButtonItemNew.Glyph = global::CashDeskManager.V2.Properties.Resources.add_16x16;
            this.barButtonItemNew.Id = 1;
            this.barButtonItemNew.LargeGlyph = global::CashDeskManager.V2.Properties.Resources.add_32x32;
            this.barButtonItemNew.Name = "barButtonItemNew";
            this.barButtonItemNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItemEdit
            // 
            this.barButtonItemEdit.Caption = "Düzenle";
            this.barButtonItemEdit.Glyph = global::CashDeskManager.V2.Properties.Resources.editname_16x16;
            this.barButtonItemEdit.Id = 2;
            this.barButtonItemEdit.LargeGlyph = global::CashDeskManager.V2.Properties.Resources.editname_32x32;
            this.barButtonItemEdit.Name = "barButtonItemEdit";
            this.barButtonItemEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEdit_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Sil";
            this.barButtonItemDelete.Glyph = global::CashDeskManager.V2.Properties.Resources.delete_16x16;
            this.barButtonItemDelete.Id = 3;
            this.barButtonItemDelete.LargeGlyph = global::CashDeskManager.V2.Properties.Resources.delete_32x32;
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // barButtonItemPay
            // 
            this.barButtonItemPay.Caption = "Ödeme Yap";
            this.barButtonItemPay.Id = 4;
            this.barButtonItemPay.LargeGlyph = global::CashDeskManager.V2.Properties.Resources.credit_cart;
            this.barButtonItemPay.Name = "barButtonItemPay";
            this.barButtonItemPay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPay_ItemClick);
            // 
            // barButtonItemPayCash
            // 
            this.barButtonItemPayCash.Caption = "Nakit Ödeme Yap";
            this.barButtonItemPayCash.Id = 5;
            this.barButtonItemPayCash.LargeGlyph = global::CashDeskManager.V2.Properties.Resources.calculator;
            this.barButtonItemPayCash.Name = "barButtonItemPayCash";
            this.barButtonItemPayCash.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPay_ItemClick);
            // 
            // barButtonItemCheck
            // 
            this.barButtonItemCheck.Caption = "Çek İle Ödeme Yap";
            this.barButtonItemCheck.Enabled = false;
            this.barButtonItemCheck.Id = 6;
            this.barButtonItemCheck.LargeGlyph = global::CashDeskManager.V2.Properties.Resources.cek;
            this.barButtonItemCheck.Name = "barButtonItemCheck";
            this.barButtonItemCheck.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPay_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Sabit Ödeme İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemPay);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Ödeme & Raporlama";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 692);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1172, 27);
            // 
            // fixedExpenseBindingSource
            // 
            this.fixedExpenseBindingSource.DataSource = typeof(CashDeskManager.V2.Entity.Database.FixedExpense);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.fixedExpenseBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 95);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1172, 597);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colExpenseType,
            this.colDescription,
            this.colCurrencyUnit,
            this.colAmount,
            this.colFixedExpensePeriod,
            this.colFixedExpensePeriodCustomDay,
            this.colStartDate,
            this.colLastDate,
            this.colNextDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gridView1_MasterRowExpanded);
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // colExpenseType
            // 
            this.colExpenseType.FieldName = "ExpenseType";
            this.colExpenseType.Name = "colExpenseType";
            this.colExpenseType.Visible = true;
            this.colExpenseType.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colCurrencyUnit
            // 
            this.colCurrencyUnit.FieldName = "CurrencyUnit";
            this.colCurrencyUnit.Name = "colCurrencyUnit";
            this.colCurrencyUnit.Visible = true;
            this.colCurrencyUnit.VisibleIndex = 2;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 3;
            // 
            // colFixedExpensePeriod
            // 
            this.colFixedExpensePeriod.FieldName = "FixedExpensePeriod";
            this.colFixedExpensePeriod.Name = "colFixedExpensePeriod";
            this.colFixedExpensePeriod.Visible = true;
            this.colFixedExpensePeriod.VisibleIndex = 4;
            // 
            // colFixedExpensePeriodCustomDay
            // 
            this.colFixedExpensePeriodCustomDay.FieldName = "FixedExpensePeriodCustomDay";
            this.colFixedExpensePeriodCustomDay.Name = "colFixedExpensePeriodCustomDay";
            this.colFixedExpensePeriodCustomDay.Visible = true;
            this.colFixedExpensePeriodCustomDay.VisibleIndex = 5;
            // 
            // colStartDate
            // 
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 6;
            // 
            // colLastDate
            // 
            this.colLastDate.FieldName = "LastDate";
            this.colLastDate.Name = "colLastDate";
            this.colLastDate.Visible = true;
            this.colLastDate.VisibleIndex = 7;
            // 
            // colNextDate
            // 
            this.colNextDate.FieldName = "NextDate";
            this.colNextDate.Name = "colNextDate";
            this.colNextDate.Visible = true;
            this.colNextDate.VisibleIndex = 8;
            // 
            // XtraFormFixedExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 719);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XtraFormFixedExpenses";
            this.Text = "Sabit Giderler";
            this.Load += new System.EventHandler(this.XtraFormFixedExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedExpenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private System.Windows.Forms.BindingSource fixedExpenseBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNew;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colExpenseType;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colFixedExpensePeriod;
        private DevExpress.XtraGrid.Columns.GridColumn colFixedExpensePeriodCustomDay;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLastDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNextDate;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPay;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPayCash;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCheck;
    }
}