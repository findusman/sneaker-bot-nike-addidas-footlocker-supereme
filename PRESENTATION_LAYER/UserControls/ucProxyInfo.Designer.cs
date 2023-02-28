namespace DXApplication1.PRESENTATION_LAYER.UserControls
{
    partial class ucProxyInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProxyInfo));
            this.labelControl84 = new DevExpress.XtraEditors.LabelControl();
            this.lcIP = new DevExpress.XtraEditors.LabelControl();
            this.lcPort = new DevExpress.XtraEditors.LabelControl();
            this.lcPassword = new DevExpress.XtraEditors.LabelControl();
            this.lcUser = new DevExpress.XtraEditors.LabelControl();
            this.peDelete = new DevExpress.XtraEditors.PictureEdit();
            this.peEdit = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.peDelete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl84
            // 
            this.labelControl84.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl84.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl84.Appearance.Options.UseFont = true;
            this.labelControl84.Appearance.Options.UseForeColor = true;
            this.labelControl84.Location = new System.Drawing.Point(690, 16);
            this.labelControl84.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl84.Name = "labelControl84";
            this.labelControl84.Size = new System.Drawing.Size(28, 16);
            this.labelControl84.TabIndex = 50;
            this.labelControl84.Text = "none";
            // 
            // lcIP
            // 
            this.lcIP.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcIP.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcIP.Appearance.Options.UseFont = true;
            this.lcIP.Appearance.Options.UseForeColor = true;
            this.lcIP.Location = new System.Drawing.Point(60, 16);
            this.lcIP.Margin = new System.Windows.Forms.Padding(5);
            this.lcIP.Name = "lcIP";
            this.lcIP.Size = new System.Drawing.Size(89, 16);
            this.lcIP.TabIndex = 48;
            this.lcIP.Text = "192.168.98.890";
            // 
            // lcPort
            // 
            this.lcPort.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcPort.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcPort.Appearance.Options.UseFont = true;
            this.lcPort.Appearance.Options.UseForeColor = true;
            this.lcPort.Location = new System.Drawing.Point(193, 16);
            this.lcPort.Margin = new System.Windows.Forms.Padding(5);
            this.lcPort.Name = "lcPort";
            this.lcPort.Size = new System.Drawing.Size(14, 16);
            this.lcPort.TabIndex = 43;
            this.lcPort.Text = "25";
            // 
            // lcPassword
            // 
            this.lcPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcPassword.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcPassword.Appearance.Options.UseFont = true;
            this.lcPassword.Appearance.Options.UseForeColor = true;
            this.lcPassword.Location = new System.Drawing.Point(432, 16);
            this.lcPassword.Margin = new System.Windows.Forms.Padding(5);
            this.lcPassword.Name = "lcPassword";
            this.lcPassword.Size = new System.Drawing.Size(72, 16);
            this.lcPassword.TabIndex = 45;
            this.lcPassword.Text = "*********";
            // 
            // lcUser
            // 
            this.lcUser.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcUser.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcUser.Appearance.Options.UseFont = true;
            this.lcUser.Appearance.Options.UseForeColor = true;
            this.lcUser.Location = new System.Drawing.Point(292, 16);
            this.lcUser.Margin = new System.Windows.Forms.Padding(5);
            this.lcUser.Name = "lcUser";
            this.lcUser.Size = new System.Drawing.Size(28, 16);
            this.lcUser.TabIndex = 44;
            this.lcUser.Text = "none";
            // 
            // peDelete
            // 
            this.peDelete.EditValue = ((object)(resources.GetObject("peDelete.EditValue")));
            this.peDelete.Location = new System.Drawing.Point(855, 12);
            this.peDelete.Name = "peDelete";
            this.peDelete.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peDelete.Properties.Appearance.Options.UseBackColor = true;
            this.peDelete.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peDelete.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peDelete.Size = new System.Drawing.Size(28, 28);
            this.peDelete.TabIndex = 125;
            this.peDelete.Click += new System.EventHandler(this.peDelete_Click);
            // 
            // peEdit
            // 
            this.peEdit.EditValue = ((object)(resources.GetObject("peEdit.EditValue")));
            this.peEdit.Location = new System.Drawing.Point(819, 12);
            this.peEdit.Name = "peEdit";
            this.peEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peEdit.Properties.Appearance.Options.UseBackColor = true;
            this.peEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peEdit.Size = new System.Drawing.Size(28, 28);
            this.peEdit.TabIndex = 124;
            this.peEdit.Click += new System.EventHandler(this.peEdit_Click);
            // 
            // ucProxyInfo
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.peDelete);
            this.Controls.Add(this.peEdit);
            this.Controls.Add(this.labelControl84);
            this.Controls.Add(this.lcIP);
            this.Controls.Add(this.lcPort);
            this.Controls.Add(this.lcPassword);
            this.Controls.Add(this.lcUser);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ucProxyInfo";
            this.Size = new System.Drawing.Size(896, 50);
            ((System.ComponentModel.ISupportInitialize)(this.peDelete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl84;
        private DevExpress.XtraEditors.LabelControl lcIP;
        private DevExpress.XtraEditors.LabelControl lcPort;
        private DevExpress.XtraEditors.LabelControl lcPassword;
        private DevExpress.XtraEditors.LabelControl lcUser;
        private DevExpress.XtraEditors.PictureEdit peDelete;
        private DevExpress.XtraEditors.PictureEdit peEdit;
    }
}
