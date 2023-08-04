namespace CashDeskManager.V2.Forms
{
    partial class XtraFormCustumer
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormCustumer));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.custumerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.phoneNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.addressMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.descriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            nameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custumerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 141);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(61, 13);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Adı Soyadı:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(12, 167);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(98, 13);
            phoneNumberLabel.TabIndex = 8;
            phoneNumberLabel.Text = "Telefon Numarası::";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(12, 192);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(39, 13);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "Adres:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 294);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(52, 13);
            descriptionLabel.TabIndex = 10;
            descriptionLabel.Text = "Açıklama:";
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
            this.ribbonControl1.Size = new System.Drawing.Size(444, 126);
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
            // custumerBindingSource
            // 
            this.custumerBindingSource.DataSource = typeof(CashDeskManager.V2.Entity.Database.Custumer);
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.custumerBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.nameTextEdit.Location = new System.Drawing.Point(116, 138);
            this.nameTextEdit.MenuManager = this.ribbonControl1;
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(317, 20);
            this.nameTextEdit.TabIndex = 8;
            // 
            // phoneNumberTextEdit
            // 
            this.phoneNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.custumerBindingSource, "PhoneNumber", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.phoneNumberTextEdit.Location = new System.Drawing.Point(116, 164);
            this.phoneNumberTextEdit.MenuManager = this.ribbonControl1;
            this.phoneNumberTextEdit.Name = "phoneNumberTextEdit";
            this.phoneNumberTextEdit.Properties.Mask.EditMask = "(999) 000-0000";
            this.phoneNumberTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.phoneNumberTextEdit.Size = new System.Drawing.Size(317, 20);
            this.phoneNumberTextEdit.TabIndex = 9;
            // 
            // addressMemoEdit
            // 
            this.addressMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.custumerBindingSource, "Address", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.addressMemoEdit.Location = new System.Drawing.Point(116, 190);
            this.addressMemoEdit.MenuManager = this.ribbonControl1;
            this.addressMemoEdit.Name = "addressMemoEdit";
            this.addressMemoEdit.Size = new System.Drawing.Size(317, 96);
            this.addressMemoEdit.TabIndex = 10;
            // 
            // descriptionMemoEdit
            // 
            this.descriptionMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.custumerBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.descriptionMemoEdit.Location = new System.Drawing.Point(116, 292);
            this.descriptionMemoEdit.MenuManager = this.ribbonControl1;
            this.descriptionMemoEdit.Name = "descriptionMemoEdit";
            this.descriptionMemoEdit.Size = new System.Drawing.Size(317, 96);
            this.descriptionMemoEdit.TabIndex = 11;
            // 
            // XtraFormCustumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(444, 405);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionMemoEdit);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressMemoEdit);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextEdit);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextEdit);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("XtraFormCustumer.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraFormCustumer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müşteri Hesabı";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custumerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.BindingSource custumerBindingSource;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit phoneNumberTextEdit;
        private DevExpress.XtraEditors.MemoEdit addressMemoEdit;
        private DevExpress.XtraEditors.MemoEdit descriptionMemoEdit;
    }
}