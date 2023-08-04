namespace CashDeskManager.V2.Reports
{
    partial class XtraReportGeneral
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.bindingSourceActions = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceMoneyOut = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceCustumerDibtCollect = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceDebtPay = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceFixedExpensePay = new System.Windows.Forms.BindingSource(this.components);
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMoneyOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustumerDibtCollect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDebtPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFixedExpensePay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 100F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // bindingSourceActions
            // 
            this.bindingSourceActions.DataSource = typeof(CashDeskManager.V2.Entity.Database.CashDeskAction);
            // 
            // bindingSourceMoneyOut
            // 
            this.bindingSourceMoneyOut.DataSource = typeof(CashDeskManager.V2.Entity.Database.MoneyOut);
            // 
            // bindingSourceCustumerDibtCollect
            // 
            this.bindingSourceCustumerDibtCollect.DataSource = typeof(CashDeskManager.V2.Entity.Database.CustumerDibtCollect);
            // 
            // bindingSourceDebtPay
            // 
            this.bindingSourceDebtPay.DataSource = typeof(CashDeskManager.V2.Entity.Database.DebtPay);
            // 
            // bindingSourceFixedExpensePay
            // 
            this.bindingSourceFixedExpensePay.DataSource = typeof(CashDeskManager.V2.Entity.Database.FixedExpensePay);
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.GroupHeader1.HeightF = 100F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(166.6667F, 31.20832F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel1.Text = "Para Çıkışları";
            // 
            // XtraReportGeneral
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1});
            this.DataSource = this.bindingSourceActions;
            this.Version = "15.2";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMoneyOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustumerDibtCollect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDebtPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFixedExpensePay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private System.Windows.Forms.BindingSource bindingSourceActions;
        private System.Windows.Forms.BindingSource bindingSourceMoneyOut;
        private System.Windows.Forms.BindingSource bindingSourceCustumerDibtCollect;
        private System.Windows.Forms.BindingSource bindingSourceDebtPay;
        private System.Windows.Forms.BindingSource bindingSourceFixedExpensePay;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    }
}
