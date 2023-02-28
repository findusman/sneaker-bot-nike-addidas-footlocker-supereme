namespace DXApplication1.PRESENTATION_LAYER.UserControls
{
    partial class ucBillingInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBillingInfo));
            this.lcCardNo = new DevExpress.XtraEditors.LabelControl();
            this.lcAddress = new DevExpress.XtraEditors.LabelControl();
            this.lcTelephone = new DevExpress.XtraEditors.LabelControl();
            this.lcEmail = new DevExpress.XtraEditors.LabelControl();
            this.lcName = new DevExpress.XtraEditors.LabelControl();
            this.peDelete = new DevExpress.XtraEditors.PictureEdit();
            this.peEdit = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.peDelete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lcCardNo
            // 
            this.lcCardNo.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcCardNo.Appearance.Options.UseForeColor = true;
            this.lcCardNo.Location = new System.Drawing.Point(655, 16);
            this.lcCardNo.Name = "lcCardNo";
            this.lcCardNo.Size = new System.Drawing.Size(76, 16);
            this.lcCardNo.TabIndex = 118;
            this.lcCardNo.Text = "Card Number";
            // 
            // lcAddress
            // 
            this.lcAddress.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcAddress.Appearance.Options.UseForeColor = true;
            this.lcAddress.Location = new System.Drawing.Point(396, 16);
            this.lcAddress.Name = "lcAddress";
            this.lcAddress.Size = new System.Drawing.Size(46, 16);
            this.lcAddress.TabIndex = 117;
            this.lcAddress.Text = "Address";
            // 
            // lcTelephone
            // 
            this.lcTelephone.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lcTelephone.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcTelephone.Appearance.Options.UseBackColor = true;
            this.lcTelephone.Appearance.Options.UseForeColor = true;
            this.lcTelephone.Location = new System.Drawing.Point(273, 16);
            this.lcTelephone.Name = "lcTelephone";
            this.lcTelephone.Size = new System.Drawing.Size(60, 16);
            this.lcTelephone.TabIndex = 115;
            this.lcTelephone.Text = "Telephone";
            // 
            // lcEmail
            // 
            this.lcEmail.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lcEmail.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcEmail.Appearance.Options.UseBackColor = true;
            this.lcEmail.Appearance.Options.UseForeColor = true;
            this.lcEmail.Location = new System.Drawing.Point(123, 16);
            this.lcEmail.Name = "lcEmail";
            this.lcEmail.Size = new System.Drawing.Size(31, 16);
            this.lcEmail.TabIndex = 114;
            this.lcEmail.Text = "Email";
            // 
            // lcName
            // 
            this.lcName.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lcName.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcName.Appearance.Options.UseBackColor = true;
            this.lcName.Appearance.Options.UseForeColor = true;
            this.lcName.Location = new System.Drawing.Point(18, 16);
            this.lcName.Name = "lcName";
            this.lcName.Size = new System.Drawing.Size(33, 16);
            this.lcName.TabIndex = 113;
            this.lcName.Text = "Name";
            // 
            // peDelete
            // 
            this.peDelete.EditValue = ((object)(resources.GetObject("peDelete.EditValue")));
            this.peDelete.Location = new System.Drawing.Point(858, 11);
            this.peDelete.Name = "peDelete";
            this.peDelete.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peDelete.Properties.Appearance.Options.UseBackColor = true;
            this.peDelete.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peDelete.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peDelete.Size = new System.Drawing.Size(28, 28);
            this.peDelete.TabIndex = 121;
            this.peDelete.Click += new System.EventHandler(this.peDelete_Click);
            // 
            // peEdit
            // 
            this.peEdit.EditValue = ((object)(resources.GetObject("peEdit.EditValue")));
            this.peEdit.Location = new System.Drawing.Point(822, 11);
            this.peEdit.Name = "peEdit";
            this.peEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peEdit.Properties.Appearance.Options.UseBackColor = true;
            this.peEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peEdit.Size = new System.Drawing.Size(28, 28);
            this.peEdit.TabIndex = 120;
            this.peEdit.Click += new System.EventHandler(this.peEdit_Click);
            // 
            // ucBillingInfo
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.peDelete);
            this.Controls.Add(this.peEdit);
            this.Controls.Add(this.lcCardNo);
            this.Controls.Add(this.lcAddress);
            this.Controls.Add(this.lcTelephone);
            this.Controls.Add(this.lcEmail);
            this.Controls.Add(this.lcName);
            this.Name = "ucBillingInfo";
            this.Size = new System.Drawing.Size(896, 51);
            ((System.ComponentModel.ISupportInitialize)(this.peDelete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lcCardNo;
        private DevExpress.XtraEditors.LabelControl lcAddress;
        private DevExpress.XtraEditors.LabelControl lcTelephone;
        public DevExpress.XtraEditors.LabelControl lcEmail;
        public DevExpress.XtraEditors.LabelControl lcName;
        private DevExpress.XtraEditors.PictureEdit peDelete;
        private DevExpress.XtraEditors.PictureEdit peEdit;
    }
}
