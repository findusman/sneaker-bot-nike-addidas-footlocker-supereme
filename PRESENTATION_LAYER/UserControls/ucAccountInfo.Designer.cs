namespace DXApplication1.PRESENTATION_LAYER.UserControls
{
    partial class ucAccountInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAccountInfo));
            this.lcNo = new DevExpress.XtraEditors.LabelControl();
            this.lcPassword = new DevExpress.XtraEditors.LabelControl();
            this.lcEmail = new DevExpress.XtraEditors.LabelControl();
            this.lcWebsite = new DevExpress.XtraEditors.LabelControl();
            this.peDelete = new DevExpress.XtraEditors.PictureEdit();
            this.peEdit = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.peDelete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lcNo
            // 
            this.lcNo.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcNo.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcNo.Appearance.Options.UseFont = true;
            this.lcNo.Appearance.Options.UseForeColor = true;
            this.lcNo.Location = new System.Drawing.Point(11, 17);
            this.lcNo.Margin = new System.Windows.Forms.Padding(5);
            this.lcNo.Name = "lcNo";
            this.lcNo.Size = new System.Drawing.Size(7, 16);
            this.lcNo.TabIndex = 52;
            this.lcNo.Text = "1";
            // 
            // lcPassword
            // 
            this.lcPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcPassword.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcPassword.Appearance.Options.UseFont = true;
            this.lcPassword.Appearance.Options.UseForeColor = true;
            this.lcPassword.Location = new System.Drawing.Point(497, 17);
            this.lcPassword.Margin = new System.Windows.Forms.Padding(5);
            this.lcPassword.Name = "lcPassword";
            this.lcPassword.Size = new System.Drawing.Size(80, 16);
            this.lcPassword.TabIndex = 51;
            this.lcPassword.Text = "**********";
            // 
            // lcEmail
            // 
            this.lcEmail.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcEmail.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcEmail.Appearance.Options.UseFont = true;
            this.lcEmail.Appearance.Options.UseForeColor = true;
            this.lcEmail.Location = new System.Drawing.Point(253, 17);
            this.lcEmail.Margin = new System.Windows.Forms.Padding(5);
            this.lcEmail.Name = "lcEmail";
            this.lcEmail.Size = new System.Drawing.Size(109, 16);
            this.lcEmail.TabIndex = 49;
            this.lcEmail.Text = "abcdef@gmail.com";
            // 
            // lcWebsite
            // 
            this.lcWebsite.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcWebsite.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcWebsite.Appearance.Options.UseFont = true;
            this.lcWebsite.Appearance.Options.UseForeColor = true;
            this.lcWebsite.Location = new System.Drawing.Point(71, 17);
            this.lcWebsite.Margin = new System.Windows.Forms.Padding(5);
            this.lcWebsite.Name = "lcWebsite";
            this.lcWebsite.Size = new System.Drawing.Size(23, 16);
            this.lcWebsite.TabIndex = 50;
            this.lcWebsite.Text = "ABC";
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
            this.peDelete.TabIndex = 123;
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
            this.peEdit.TabIndex = 122;
            this.peEdit.Click += new System.EventHandler(this.peEdit_Click);
            // 
            // ucAccount
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.peDelete);
            this.Controls.Add(this.peEdit);
            this.Controls.Add(this.lcNo);
            this.Controls.Add(this.lcPassword);
            this.Controls.Add(this.lcEmail);
            this.Controls.Add(this.lcWebsite);
            this.Name = "ucAccount";
            this.Size = new System.Drawing.Size(900, 50);
            ((System.ComponentModel.ISupportInitialize)(this.peDelete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lcNo;
        private DevExpress.XtraEditors.LabelControl lcPassword;
        private DevExpress.XtraEditors.LabelControl lcEmail;
        private DevExpress.XtraEditors.LabelControl lcWebsite;
        private DevExpress.XtraEditors.PictureEdit peDelete;
        private DevExpress.XtraEditors.PictureEdit peEdit;
    }
}
