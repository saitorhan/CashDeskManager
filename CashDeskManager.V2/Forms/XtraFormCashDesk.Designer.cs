﻿namespace CashDeskManager.Forms
{
    partial class XtraFormCashDesk
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
            System.Windows.Forms.Label createdDateTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormCashDesk));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.cashDeskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.createdDateTimeDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.descriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            nameLabel = new System.Windows.Forms.Label();
            createdDateTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashDeskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createdDateTimeDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createdDateTimeDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(11, 135);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(52, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Kasa Adı:";
            // 
            // createdDateTimeLabel
            // 
            createdDateTimeLabel.AutoSize = true;
            createdDateTimeLabel.Location = new System.Drawing.Point(11, 161);
            createdDateTimeLabel.Name = "createdDateTimeLabel";
            createdDateTimeLabel.Size = new System.Drawing.Size(89, 13);
            createdDateTimeLabel.TabIndex = 3;
            createdDateTimeLabel.Text = "Oluşturma Tarihi:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(11, 186);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(52, 13);
            descriptionLabel.TabIndex = 5;
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
            this.ribbonControl1.Size = new System.Drawing.Size(399, 126);
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
            // cashDeskBindingSource
            // 
            this.cashDeskBindingSource.DataSource = typeof(CashDeskManager.V2.Entity.Database.CashDesk);
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cashDeskBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.nameTextEdit.Location = new System.Drawing.Point(110, 132);
            this.nameTextEdit.MenuManager = this.ribbonControl1;
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(277, 20);
            this.nameTextEdit.TabIndex = 3;
            // 
            // createdDateTimeDateEdit
            // 
            this.createdDateTimeDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cashDeskBindingSource, "CreatedDateTime", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.createdDateTimeDateEdit.EditValue = null;
            this.createdDateTimeDateEdit.Location = new System.Drawing.Point(110, 158);
            this.createdDateTimeDateEdit.MenuManager = this.ribbonControl1;
            this.createdDateTimeDateEdit.Name = "createdDateTimeDateEdit";
            this.createdDateTimeDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.createdDateTimeDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.createdDateTimeDateEdit.Properties.ReadOnly = true;
            this.createdDateTimeDateEdit.Size = new System.Drawing.Size(277, 20);
            this.createdDateTimeDateEdit.TabIndex = 4;
            // 
            // descriptionMemoEdit
            // 
            this.descriptionMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cashDeskBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.descriptionMemoEdit.Location = new System.Drawing.Point(110, 184);
            this.descriptionMemoEdit.MenuManager = this.ribbonControl1;
            this.descriptionMemoEdit.Name = "descriptionMemoEdit";
            this.descriptionMemoEdit.Size = new System.Drawing.Size(277, 96);
            this.descriptionMemoEdit.TabIndex = 6;
            // 
            // XtraFormCashDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 290);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionMemoEdit);
            this.Controls.Add(createdDateTimeLabel);
            this.Controls.Add(this.createdDateTimeDateEdit);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextEdit);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("XtraFormCashDesk.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraFormCashDesk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kasa Hesabı";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashDeskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createdDateTimeDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createdDateTimeDateEdit.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource cashDeskBindingSource;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.DateEdit createdDateTimeDateEdit;
        private DevExpress.XtraEditors.MemoEdit descriptionMemoEdit;
    }
}