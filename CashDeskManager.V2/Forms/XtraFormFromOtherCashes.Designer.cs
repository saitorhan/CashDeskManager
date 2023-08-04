namespace CashDeskManager.V2.Forms
{
    partial class XtraFormFromOtherCashes
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.actionFromOtherCashesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSourceCash = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSignDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpirtyDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheckNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheckOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustumerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoneyOutFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeptPayFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebtName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFixedFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFixedExpense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoneyToDesk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActionDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActionDirectionString = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentMethodString = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentStatuString = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionFromOtherCashesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(961, 126);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
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
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.actionFromOtherCashesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 126);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(961, 532);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // actionFromOtherCashesBindingSource
            // 
            this.actionFromOtherCashesBindingSource.DataSource = typeof(CashDeskManager.V2.Entity.AppModel.ActionFromOtherCashes);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSourceCash,
            this.colCurrencyUnit,
            this.colAmount,
            this.colDateTime,
            this.colDescription,
            this.colBankName,
            this.colBankBranch,
            this.colSignDateTime,
            this.colExpirtyDateTime,
            this.colAccountNumber,
            this.colCheckNumber,
            this.colCheckOwner,
            this.colCustumerName,
            this.colMoneyOutFrom,
            this.colDeptPayFrom,
            this.colDebtName,
            this.colFixedFrom,
            this.colFixedExpense,
            this.colMoneyToDesk,
            this.colActionDesc,
            this.colActionDirectionString,
            this.colPaymentMethodString,
            this.colPaymentStatuString});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // colSourceCash
            // 
            this.colSourceCash.FieldName = "SourceCash";
            this.colSourceCash.Name = "colSourceCash";
            this.colSourceCash.Visible = true;
            this.colSourceCash.VisibleIndex = 0;
            this.colSourceCash.Width = 88;
            // 
            // colCurrencyUnit
            // 
            this.colCurrencyUnit.FieldName = "CurrencyUnit";
            this.colCurrencyUnit.Name = "colCurrencyUnit";
            this.colCurrencyUnit.Visible = true;
            this.colCurrencyUnit.VisibleIndex = 1;
            this.colCurrencyUnit.Width = 69;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 2;
            this.colAmount.Width = 49;
            // 
            // colDateTime
            // 
            this.colDateTime.FieldName = "DateTime";
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.Visible = true;
            this.colDateTime.VisibleIndex = 3;
            this.colDateTime.Width = 74;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 61;
            // 
            // colBankName
            // 
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 5;
            this.colBankName.Width = 49;
            // 
            // colBankBranch
            // 
            this.colBankBranch.FieldName = "BankBranch";
            this.colBankBranch.Name = "colBankBranch";
            this.colBankBranch.Visible = true;
            this.colBankBranch.VisibleIndex = 6;
            this.colBankBranch.Width = 83;
            // 
            // colSignDateTime
            // 
            this.colSignDateTime.FieldName = "SignDateTime";
            this.colSignDateTime.Name = "colSignDateTime";
            this.colSignDateTime.Visible = true;
            this.colSignDateTime.VisibleIndex = 7;
            this.colSignDateTime.Width = 72;
            // 
            // colExpirtyDateTime
            // 
            this.colExpirtyDateTime.FieldName = "ExpirtyDateTime";
            this.colExpirtyDateTime.Name = "colExpirtyDateTime";
            this.colExpirtyDateTime.Visible = true;
            this.colExpirtyDateTime.VisibleIndex = 8;
            this.colExpirtyDateTime.Width = 73;
            // 
            // colAccountNumber
            // 
            this.colAccountNumber.FieldName = "AccountNumber";
            this.colAccountNumber.Name = "colAccountNumber";
            this.colAccountNumber.Visible = true;
            this.colAccountNumber.VisibleIndex = 9;
            this.colAccountNumber.Width = 97;
            // 
            // colCheckNumber
            // 
            this.colCheckNumber.FieldName = "CheckNumber";
            this.colCheckNumber.Name = "colCheckNumber";
            this.colCheckNumber.Visible = true;
            this.colCheckNumber.VisibleIndex = 10;
            this.colCheckNumber.Width = 85;
            // 
            // colCheckOwner
            // 
            this.colCheckOwner.FieldName = "CheckOwner";
            this.colCheckOwner.Name = "colCheckOwner";
            this.colCheckOwner.Visible = true;
            this.colCheckOwner.VisibleIndex = 11;
            this.colCheckOwner.Width = 69;
            // 
            // colCustumerName
            // 
            this.colCustumerName.FieldName = "CustumerName";
            this.colCustumerName.Name = "colCustumerName";
            this.colCustumerName.Visible = true;
            this.colCustumerName.VisibleIndex = 12;
            this.colCustumerName.Width = 73;
            // 
            // colMoneyOutFrom
            // 
            this.colMoneyOutFrom.FieldName = "MoneyOutFrom";
            this.colMoneyOutFrom.Name = "colMoneyOutFrom";
            this.colMoneyOutFrom.Visible = true;
            this.colMoneyOutFrom.VisibleIndex = 13;
            this.colMoneyOutFrom.Width = 113;
            // 
            // colDeptPayFrom
            // 
            this.colDeptPayFrom.FieldName = "DeptPayFrom";
            this.colDeptPayFrom.Name = "colDeptPayFrom";
            this.colDeptPayFrom.Visible = true;
            this.colDeptPayFrom.VisibleIndex = 14;
            this.colDeptPayFrom.Width = 145;
            // 
            // colDebtName
            // 
            this.colDebtName.FieldName = "DebtName";
            this.colDebtName.Name = "colDebtName";
            this.colDebtName.Visible = true;
            this.colDebtName.VisibleIndex = 15;
            this.colDebtName.Width = 85;
            // 
            // colFixedFrom
            // 
            this.colFixedFrom.FieldName = "FixedFrom";
            this.colFixedFrom.Name = "colFixedFrom";
            this.colFixedFrom.Visible = true;
            this.colFixedFrom.VisibleIndex = 16;
            this.colFixedFrom.Width = 176;
            // 
            // colFixedExpense
            // 
            this.colFixedExpense.FieldName = "FixedExpense";
            this.colFixedExpense.Name = "colFixedExpense";
            this.colFixedExpense.Visible = true;
            this.colFixedExpense.VisibleIndex = 17;
            this.colFixedExpense.Width = 116;
            // 
            // colMoneyToDesk
            // 
            this.colMoneyToDesk.FieldName = "MoneyToDesk";
            this.colMoneyToDesk.Name = "colMoneyToDesk";
            this.colMoneyToDesk.Visible = true;
            this.colMoneyToDesk.VisibleIndex = 18;
            this.colMoneyToDesk.Width = 104;
            // 
            // colActionDesc
            // 
            this.colActionDesc.FieldName = "ActionDesc";
            this.colActionDesc.Name = "colActionDesc";
            this.colActionDesc.Visible = true;
            this.colActionDesc.VisibleIndex = 19;
            this.colActionDesc.Width = 70;
            // 
            // colActionDirectionString
            // 
            this.colActionDirectionString.FieldName = "ActionDirectionString";
            this.colActionDirectionString.Name = "colActionDirectionString";
            this.colActionDirectionString.OptionsColumn.ReadOnly = true;
            this.colActionDirectionString.Visible = true;
            this.colActionDirectionString.VisibleIndex = 20;
            this.colActionDirectionString.Width = 70;
            // 
            // colPaymentMethodString
            // 
            this.colPaymentMethodString.FieldName = "PaymentMethodString";
            this.colPaymentMethodString.Name = "colPaymentMethodString";
            this.colPaymentMethodString.OptionsColumn.ReadOnly = true;
            this.colPaymentMethodString.Visible = true;
            this.colPaymentMethodString.VisibleIndex = 21;
            this.colPaymentMethodString.Width = 78;
            // 
            // colPaymentStatuString
            // 
            this.colPaymentStatuString.FieldName = "PaymentStatuString";
            this.colPaymentStatuString.Name = "colPaymentStatuString";
            this.colPaymentStatuString.OptionsColumn.ReadOnly = true;
            this.colPaymentStatuString.Visible = true;
            this.colPaymentStatuString.VisibleIndex = 22;
            this.colPaymentStatuString.Width = 94;
            // 
            // XtraFormFromOtherCashes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 658);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "XtraFormFromOtherCashes";
            this.Text = "Diğer Kasalardan Kaynaklı Hareketler";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionFromOtherCashesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource actionFromOtherCashesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSourceCash;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colBankName;
        private DevExpress.XtraGrid.Columns.GridColumn colBankBranch;
        private DevExpress.XtraGrid.Columns.GridColumn colSignDateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colExpirtyDateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCheckNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCheckOwner;
        private DevExpress.XtraGrid.Columns.GridColumn colCustumerName;
        private DevExpress.XtraGrid.Columns.GridColumn colMoneyOutFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colDeptPayFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colDebtName;
        private DevExpress.XtraGrid.Columns.GridColumn colFixedFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colFixedExpense;
        private DevExpress.XtraGrid.Columns.GridColumn colMoneyToDesk;
        private DevExpress.XtraGrid.Columns.GridColumn colActionDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colActionDirectionString;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentMethodString;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentStatuString;
    }
}