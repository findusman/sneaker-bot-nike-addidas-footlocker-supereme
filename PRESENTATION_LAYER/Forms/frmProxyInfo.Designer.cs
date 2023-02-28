namespace DXApplication1.PRESENTATION_LAYER.Forms
{
    partial class frmProxyInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProxyInfo));
            this.lcIP = new DevExpress.XtraEditors.LabelControl();
            this.lcPort = new DevExpress.XtraEditors.LabelControl();
            this.lcUser = new DevExpress.XtraEditors.LabelControl();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.teUser = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.peCross = new DevExpress.XtraEditors.PictureEdit();
            this.teIP = new DevExpress.XtraEditors.TextEdit();
            this.tePort = new DevExpress.XtraEditors.TextEdit();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.lcPassword = new DevExpress.XtraEditors.LabelControl();
            this.dxError = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.teUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCross.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxError)).BeginInit();
            this.SuspendLayout();
            // 
            // lcIP
            // 
            this.lcIP.Location = new System.Drawing.Point(49, 85);
            this.lcIP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcIP.Name = "lcIP";
            this.lcIP.Size = new System.Drawing.Size(11, 16);
            this.lcIP.TabIndex = 0;
            this.lcIP.Text = "IP";
            // 
            // lcPort
            // 
            this.lcPort.Location = new System.Drawing.Point(253, 84);
            this.lcPort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcPort.Name = "lcPort";
            this.lcPort.Size = new System.Drawing.Size(23, 16);
            this.lcPort.TabIndex = 0;
            this.lcPort.Text = "Port";
            // 
            // lcUser
            // 
            this.lcUser.Location = new System.Drawing.Point(45, 153);
            this.lcUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcUser.Name = "lcUser";
            this.lcUser.Size = new System.Drawing.Size(26, 16);
            this.lcUser.TabIndex = 40;
            this.lcUser.Text = "User";
            // 
            // sbSave
            // 
            this.sbSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.sbSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbSave.Appearance.Options.UseBackColor = true;
            this.sbSave.Appearance.Options.UseFont = true;
            this.sbSave.Location = new System.Drawing.Point(238, 317);
            this.sbSave.Margin = new System.Windows.Forms.Padding(5);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(82, 33);
            this.sbSave.TabIndex = 5;
            this.sbSave.Text = "Save";
            this.sbSave.Click += new System.EventHandler(this.sbSave_Click);
            // 
            // teUser
            // 
            this.teUser.EditValue = "";
            this.teUser.Location = new System.Drawing.Point(45, 175);
            this.teUser.Name = "teUser";
            this.teUser.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.teUser.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.teUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teUser.Properties.Appearance.Options.UseBackColor = true;
            this.teUser.Properties.Appearance.Options.UseBorderColor = true;
            this.teUser.Properties.Appearance.Options.UseFont = true;
            this.teUser.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teUser.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.teUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teUser.Properties.NullText = "Search";
            this.teUser.Size = new System.Drawing.Size(202, 30);
            this.teUser.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(23, 19);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 28);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Proxy";
            // 
            // peCross
            // 
            this.peCross.EditValue = ((object)(resources.GetObject("peCross.EditValue")));
            this.peCross.Location = new System.Drawing.Point(322, 11);
            this.peCross.Name = "peCross";
            this.peCross.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peCross.Properties.Appearance.Options.UseBackColor = true;
            this.peCross.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peCross.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peCross.Size = new System.Drawing.Size(26, 26);
            this.peCross.TabIndex = 52;
            this.peCross.Click += new System.EventHandler(this.peCross_Click);
            // 
            // teIP
            // 
            this.teIP.EditValue = "";
            this.teIP.Location = new System.Drawing.Point(45, 106);
            this.teIP.Name = "teIP";
            this.teIP.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.teIP.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.teIP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teIP.Properties.Appearance.Options.UseBackColor = true;
            this.teIP.Properties.Appearance.Options.UseBorderColor = true;
            this.teIP.Properties.Appearance.Options.UseFont = true;
            this.teIP.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teIP.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.teIP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teIP.Properties.NullText = "Search";
            this.teIP.Size = new System.Drawing.Size(202, 30);
            this.teIP.TabIndex = 1;
            // 
            // tePort
            // 
            this.tePort.EditValue = "";
            this.tePort.Location = new System.Drawing.Point(253, 106);
            this.tePort.Name = "tePort";
            this.tePort.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.tePort.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.tePort.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tePort.Properties.Appearance.Options.UseBackColor = true;
            this.tePort.Properties.Appearance.Options.UseBorderColor = true;
            this.tePort.Properties.Appearance.Options.UseFont = true;
            this.tePort.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tePort.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.tePort.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tePort.Properties.NullText = "Search";
            this.tePort.Size = new System.Drawing.Size(68, 30);
            this.tePort.TabIndex = 2;
            // 
            // tePassword
            // 
            this.tePassword.EditValue = "";
            this.tePassword.Location = new System.Drawing.Point(45, 237);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.tePassword.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.tePassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tePassword.Properties.Appearance.Options.UseBackColor = true;
            this.tePassword.Properties.Appearance.Options.UseBorderColor = true;
            this.tePassword.Properties.Appearance.Options.UseFont = true;
            this.tePassword.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tePassword.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.tePassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tePassword.Properties.DisplayFormat.FormatString = "*";
            this.tePassword.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.tePassword.Properties.NullText = "Search";
            this.tePassword.Properties.PasswordChar = '*';
            this.tePassword.Size = new System.Drawing.Size(202, 30);
            this.tePassword.TabIndex = 4;
            // 
            // lcPassword
            // 
            this.lcPassword.Location = new System.Drawing.Point(45, 216);
            this.lcPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcPassword.Name = "lcPassword";
            this.lcPassword.Size = new System.Drawing.Size(55, 16);
            this.lcPassword.TabIndex = 40;
            this.lcPassword.Text = "Password";
            // 
            // dxError
            // 
            this.dxError.ContainerControl = this;
            // 
            // frmProxyInfo
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 376);
            this.Controls.Add(this.peCross);
            this.Controls.Add(this.sbSave);
            this.Controls.Add(this.lcPassword);
            this.Controls.Add(this.lcUser);
            this.Controls.Add(this.lcPort);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.tePort);
            this.Controls.Add(this.teIP);
            this.Controls.Add(this.lcIP);
            this.Controls.Add(this.tePassword);
            this.Controls.Add(this.teUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmProxyInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.frmProxyInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCross.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lcIP;
        private DevExpress.XtraEditors.LabelControl lcPort;
        private DevExpress.XtraEditors.LabelControl lcUser;
        private DevExpress.XtraEditors.SimpleButton sbSave;
        private DevExpress.XtraEditors.TextEdit teUser;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.PictureEdit peCross;
        private DevExpress.XtraEditors.TextEdit teIP;
        private DevExpress.XtraEditors.TextEdit tePort;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.LabelControl lcPassword;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxError;
    }
}