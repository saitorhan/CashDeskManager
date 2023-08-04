namespace CashDeskManager.V2.Forms
{
    partial class XtraFormCustumerDebts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormCustumerDebts));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemNewDebt = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCash = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAllCashes = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControlDebts = new DevExpress.XtraGrid.GridControl();
            this.custumerDebtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustumerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayStatu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainingAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustumer = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDebts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custumerDebtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemNewDebt,
            this.barButtonItem1,
            this.barButtonItemCash,
            this.barButtonItemEdit,
            this.barButtonItemDelete,
            this.barButtonItemAllCashes});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(984, 95);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItemNewDebt
            // 
            this.barButtonItemNewDebt.Caption = "Borç Ekle";
            this.barButtonItemNewDebt.Id = 1;
            this.barButtonItemNewDebt.LargeGlyph = global::CashDeskManager.V2.Properties.Resources.add_32x32;
            this.barButtonItemNewDebt.Name = "barButtonItemNewDebt";
            this.barButtonItemNewDebt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNewDebt_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItemCash
            // 
            this.barButtonItemCash.Caption = "Tahsilat Yap";
            this.barButtonItemCash.Id = 3;
            this.barButtonItemCash.LargeGlyph = global::CashDeskManager.V2.Properties.Resources.calculator;
            this.barButtonItemCash.Name = "barButtonItemCash";
            this.barButtonItemCash.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCash_ItemClick);
            // 
            // barButtonItemEdit
            // 
            this.barButtonItemEdit.Caption = "Borç Düzenleme";
            this.barButtonItemEdit.Id = 6;
            this.barButtonItemEdit.LargeGlyph = global::CashDeskManager.V2.Properties.Resources.editname_32x32;
            this.barButtonItemEdit.Name = "barButtonItemEdit";
            this.barButtonItemEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEdit_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Borç Silme";
            this.barButtonItemDelete.Id = 7;
            this.barButtonItemDelete.LargeGlyph = global::CashDeskManager.V2.Properties.Resources.delete_32x32;
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // barButtonItemAllCashes
            // 
            this.barButtonItemAllCashes.Caption = "Ödemeleri Görüntüle";
            this.barButtonItemAllCashes.Enabled = false;
            this.barButtonItemAllCashes.Glyph = global::CashDeskManager.V2.Properties.Resources.report_16x16;
            this.barButtonItemAllCashes.Id = 8;
            this.barButtonItemAllCashes.LargeGlyph = global::CashDeskManager.V2.Properties.Resources.report_32x32;
            this.barButtonItemAllCashes.Name = "barButtonItemAllCashes";
            this.barButtonItemAllCashes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAllCashes_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemNewDebt);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Borç İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemCash);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemAllCashes);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Ödeme İşlemleri";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 634);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(984, 27);
            // 
            // gridControlDebts
            // 
            this.gridControlDebts.DataSource = this.custumerDebtBindingSource;
            this.gridControlDebts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDebts.Location = new System.Drawing.Point(0, 95);
            this.gridControlDebts.MainView = this.gridView1;
            this.gridControlDebts.MenuManager = this.ribbonControl1;
            this.gridControlDebts.Name = "gridControlDebts";
            this.gridControlDebts.Size = new System.Drawing.Size(984, 539);
            this.gridControlDebts.TabIndex = 2;
            this.gridControlDebts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // custumerDebtBindingSource
            // 
            this.custumerDebtBindingSource.DataSource = typeof(CashDeskManager.V2.Entity.Database.CustumerDebt);
            this.custumerDebtBindingSource.CurrentChanged += new System.EventHandler(this.custumerDebtBindingSource_CurrentChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCustumerId,
            this.colCurrencyUnit,
            this.colAmount,
            this.colDateTime,
            this.colDescription,
            this.colPayStatu,
            this.colRemainingAmount,
            this.colCustumer});
            this.gridView1.GridControl = this.gridControlDebts;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colCustumerId
            // 
            this.colCustumerId.FieldName = "CustumerId";
            this.colCustumerId.Name = "colCustumerId";
            this.colCustumerId.Visible = true;
            this.colCustumerId.VisibleIndex = 1;
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
            // colDateTime
            // 
            this.colDateTime.FieldName = "DateTime";
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.Visible = true;
            this.colDateTime.VisibleIndex = 4;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 5;
            // 
            // colPayStatu
            // 
            this.colPayStatu.FieldName = "PayStatu";
            this.colPayStatu.Name = "colPayStatu";
            this.colPayStatu.Visible = true;
            this.colPayStatu.VisibleIndex = 6;
            // 
            // colRemainingAmount
            // 
            this.colRemainingAmount.FieldName = "RemainingAmount";
            this.colRemainingAmount.Name = "colRemainingAmount";
            this.colRemainingAmount.Visible = true;
            this.colRemainingAmount.VisibleIndex = 7;
            // 
            // colCustumer
            // 
            this.colCustumer.FieldName = "Custumer";
            this.colCustumer.Name = "colCustumer";
            this.colCustumer.Visible = true;
            this.colCustumer.VisibleIndex = 8;
            // 
            // XtraFormCustumerDebts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.gridControlDebts);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraFormCustumerDebts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müşteri Borçları";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDebts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custumerDebtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNewDebt;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCash;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAllCashes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraGrid.GridControl gridControlDebts;
        private System.Windows.Forms.BindingSource custumerDebtBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustumerId;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPayStatu;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainingAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCustumer;
    }
}