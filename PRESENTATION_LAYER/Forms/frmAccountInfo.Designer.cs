
namespace DXApplication1.PRESENTATION_LAYER.Forms
{
    partial class frmAccountInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountInfo));
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lcPassword = new DevExpress.XtraEditors.LabelControl();
            this.lcUserID = new DevExpress.XtraEditors.LabelControl();
            this.teWebsite = new DevExpress.XtraEditors.TextEdit();
            this.lcWebsite = new DevExpress.XtraEditors.LabelControl();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.teUserID = new DevExpress.XtraEditors.TextEdit();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.peCross = new DevExpress.XtraEditors.PictureEdit();
            this.dxError = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.teWebsite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCross.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxError)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(26, 18);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(82, 28);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Account";
            // 
            // lcPassword
            // 
            this.lcPassword.Location = new System.Drawing.Point(49, 211);
            this.lcPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcPassword.Name = "lcPassword";
            this.lcPassword.Size = new System.Drawing.Size(55, 16);
            this.lcPassword.TabIndex = 43;
            this.lcPassword.Text = "Password";
            // 
            // lcUserID
            // 
            this.lcUserID.Location = new System.Drawing.Point(49, 145);
            this.lcUserID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcUserID.Name = "lcUserID";
            this.lcUserID.Size = new System.Drawing.Size(42, 16);
            this.lcUserID.TabIndex = 44;
            this.lcUserID.Text = "User ID";
            // 
            // teWebsite
            // 
            this.teWebsite.EditValue = "";
            this.teWebsite.Location = new System.Drawing.Point(49, 98);
            this.teWebsite.Name = "teWebsite";
            this.teWebsite.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.teWebsite.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.teWebsite.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teWebsite.Properties.Appearance.Options.UseBackColor = true;
            this.teWebsite.Properties.Appearance.Options.UseBorderColor = true;
            this.teWebsite.Properties.Appearance.Options.UseFont = true;
            this.teWebsite.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teWebsite.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.teWebsite.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teWebsite.Properties.NullText = "Search";
            this.teWebsite.Size = new System.Drawing.Size(202, 30);
            this.teWebsite.TabIndex = 1;
            // 
            // lcWebsite
            // 
            this.lcWebsite.Location = new System.Drawing.Point(53, 77);
            this.lcWebsite.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcWebsite.Name = "lcWebsite";
            this.lcWebsite.Size = new System.Drawing.Size(46, 16);
            this.lcWebsite.TabIndex = 42;
            this.lcWebsite.Text = "Website";
            // 
            // tePassword
            // 
            this.tePassword.EditValue = "";
            this.tePassword.Location = new System.Drawing.Point(49, 232);
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
            this.tePassword.TabIndex = 3;
            // 
            // teUserID
            // 
            this.teUserID.EditValue = "";
            this.teUserID.Location = new System.Drawing.Point(49, 167);
            this.teUserID.Name = "teUserID";
            this.teUserID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.teUserID.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.teUserID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teUserID.Properties.Appearance.Options.UseBackColor = true;
            this.teUserID.Properties.Appearance.Options.UseBorderColor = true;
            this.teUserID.Properties.Appearance.Options.UseFont = true;
            this.teUserID.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teUserID.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.teUserID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teUserID.Properties.NullText = "Search";
            this.teUserID.Size = new System.Drawing.Size(202, 30);
            this.teUserID.TabIndex = 2;
            // 
            // sbSave
            // 
            this.sbSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.sbSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbSave.Appearance.Options.UseBackColor = true;
            this.sbSave.Appearance.Options.UseFont = true;
            this.sbSave.Location = new System.Drawing.Point(169, 306);
            this.sbSave.Margin = new System.Windows.Forms.Padding(5);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(82, 33);
            this.sbSave.TabIndex = 4;
            this.sbSave.Text = "Save";
            this.sbSave.Click += new System.EventHandler(this.sbSave_Click);
            // 
            // peCross
            // 
            this.peCross.EditValue = ((object)(resources.GetObject("peCross.EditValue")));
            this.peCross.Location = new System.Drawing.Point(260, 12);
            this.peCross.Name = "peCross";
            this.peCross.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peCross.Properties.Appearance.Options.UseBackColor = true;
            this.peCross.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peCross.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peCross.Size = new System.Drawing.Size(26, 26);
            this.peCross.TabIndex = 53;
            this.peCross.Click += new System.EventHandler(this.peCross_Click);
            // 
            // dxError
            // 
            this.dxError.ContainerControl = this;
            // 
            // frmAccountInfo
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 370);
            this.Controls.Add(this.peCross);
            this.Controls.Add(this.sbSave);
            this.Controls.Add(this.lcPassword);
            this.Controls.Add(this.lcUserID);
            this.Controls.Add(this.teWebsite);
            this.Controls.Add(this.lcWebsite);
            this.Controls.Add(this.tePassword);
            this.Controls.Add(this.teUserID);
            this.Controls.Add(this.labelControl6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAccountInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAccount";
            this.Load += new System.EventHandler(this.frmAccountInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teWebsite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCross.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lcPassword;
        private DevExpress.XtraEditors.LabelControl lcUserID;
        private DevExpress.XtraEditors.TextEdit teWebsite;
        private DevExpress.XtraEditors.LabelControl lcWebsite;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.TextEdit teUserID;
        private DevExpress.XtraEditors.SimpleButton sbSave;
        private DevExpress.XtraEditors.PictureEdit peCross;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxError;
    }
}