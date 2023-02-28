
namespace DXApplication1.PRESENTATION_LAYER.Forms
{
    partial class frmBillingInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillingInfo));
            this.lcBillingInfo = new DevExpress.XtraEditors.LabelControl();
            this.gcPersonal = new DevExpress.XtraEditors.GroupControl();
            this.teTelephone = new DevExpress.XtraEditors.TextEdit();
            this.lcTelephone = new DevExpress.XtraEditors.LabelControl();
            this.teEmail = new DevExpress.XtraEditors.TextEdit();
            this.lcEmail = new DevExpress.XtraEditors.LabelControl();
            this.teLastName = new DevExpress.XtraEditors.TextEdit();
            this.lcLastName = new DevExpress.XtraEditors.LabelControl();
            this.teFirstName = new DevExpress.XtraEditors.TextEdit();
            this.lcFirstName = new DevExpress.XtraEditors.LabelControl();
            this.gcCardInfo = new DevExpress.XtraEditors.GroupControl();
            this.ceOther = new DevExpress.XtraEditors.CheckEdit();
            this.teCardHolder = new DevExpress.XtraEditors.TextEdit();
            this.lcCardHolder = new DevExpress.XtraEditors.LabelControl();
            this.teCSC = new DevExpress.XtraEditors.TextEdit();
            this.lcCSC = new DevExpress.XtraEditors.LabelControl();
            this.teYear = new DevExpress.XtraEditors.TextEdit();
            this.lcYear = new DevExpress.XtraEditors.LabelControl();
            this.teMonth = new DevExpress.XtraEditors.TextEdit();
            this.lcMonth = new DevExpress.XtraEditors.LabelControl();
            this.teCardNo = new DevExpress.XtraEditors.TextEdit();
            this.lcCardNo = new DevExpress.XtraEditors.LabelControl();
            this.gcShippingAddress = new DevExpress.XtraEditors.GroupControl();
            this.comboState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lcState = new DevExpress.XtraEditors.LabelControl();
            this.teCity = new DevExpress.XtraEditors.TextEdit();
            this.lcCity = new DevExpress.XtraEditors.LabelControl();
            this.teZipCode = new DevExpress.XtraEditors.TextEdit();
            this.lcZipCode = new DevExpress.XtraEditors.LabelControl();
            this.teUnitNo = new DevExpress.XtraEditors.TextEdit();
            this.lcUnitNo = new DevExpress.XtraEditors.LabelControl();
            this.teStreetAddress = new DevExpress.XtraEditors.TextEdit();
            this.lcStreetAddress = new DevExpress.XtraEditors.LabelControl();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.peCross = new DevExpress.XtraEditors.PictureEdit();
            this.dxError = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcPersonal)).BeginInit();
            this.gcPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTelephone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCardInfo)).BeginInit();
            this.gcCardInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceOther.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCardHolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCSC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCardNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcShippingAddress)).BeginInit();
            this.gcShippingAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teZipCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUnitNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teStreetAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCross.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxError)).BeginInit();
            this.SuspendLayout();
            // 
            // lcBillingInfo
            // 
            this.lcBillingInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcBillingInfo.Appearance.Options.UseFont = true;
            this.lcBillingInfo.Location = new System.Drawing.Point(23, 24);
            this.lcBillingInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcBillingInfo.Name = "lcBillingInfo";
            this.lcBillingInfo.Size = new System.Drawing.Size(185, 28);
            this.lcBillingInfo.TabIndex = 1;
            this.lcBillingInfo.Text = "Billing Inforamtion";
            // 
            // gcPersonal
            // 
            this.gcPersonal.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.gcPersonal.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.gcPersonal.Appearance.Options.UseBackColor = true;
            this.gcPersonal.Appearance.Options.UseBorderColor = true;
            this.gcPersonal.Controls.Add(this.teTelephone);
            this.gcPersonal.Controls.Add(this.lcTelephone);
            this.gcPersonal.Controls.Add(this.teEmail);
            this.gcPersonal.Controls.Add(this.lcEmail);
            this.gcPersonal.Controls.Add(this.teLastName);
            this.gcPersonal.Controls.Add(this.lcLastName);
            this.gcPersonal.Controls.Add(this.teFirstName);
            this.gcPersonal.Controls.Add(this.lcFirstName);
            this.gcPersonal.Location = new System.Drawing.Point(45, 89);
            this.gcPersonal.Name = "gcPersonal";
            this.gcPersonal.Size = new System.Drawing.Size(336, 300);
            this.gcPersonal.TabIndex = 1;
            this.gcPersonal.Text = "Personal";
            // 
            // teTelephone
            // 
            this.teTelephone.EditValue = "";
            this.teTelephone.Location = new System.Drawing.Point(18, 245);
            this.teTelephone.Name = "teTelephone";
            this.teTelephone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.teTelephone.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.teTelephone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teTelephone.Properties.Appearance.Options.UseBackColor = true;
            this.teTelephone.Properties.Appearance.Options.UseBorderColor = true;
            this.teTelephone.Properties.Appearance.Options.UseFont = true;
            this.teTelephone.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teTelephone.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.teTelephone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teTelephone.Properties.NullText = "Search";
            this.teTelephone.Size = new System.Drawing.Size(300, 30);
            this.teTelephone.TabIndex = 4;
            // 
            // lcTelephone
            // 
            this.lcTelephone.Location = new System.Drawing.Point(18, 223);
            this.lcTelephone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcTelephone.Name = "lcTelephone";
            this.lcTelephone.Size = new System.Drawing.Size(60, 16);
            this.lcTelephone.TabIndex = 47;
            this.lcTelephone.Text = "Telephone";
            // 
            // teEmail
            // 
            this.teEmail.EditValue = "";
            this.teEmail.Location = new System.Drawing.Point(18, 187);
            this.teEmail.Name = "teEmail";
            this.teEmail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.teEmail.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.teEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teEmail.Properties.Appearance.Options.UseBackColor = true;
            this.teEmail.Properties.Appearance.Options.UseBorderColor = true;
            this.teEmail.Properties.Appearance.Options.UseFont = true;
            this.teEmail.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teEmail.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.teEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teEmail.Properties.NullText = "Search";
            this.teEmail.Size = new System.Drawing.Size(300, 30);
            this.teEmail.TabIndex = 3;
            // 
            // lcEmail
            // 
            this.lcEmail.Location = new System.Drawing.Point(18, 165);
            this.lcEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcEmail.Name = "lcEmail";
            this.lcEmail.Size = new System.Drawing.Size(81, 16);
            this.lcEmail.TabIndex = 45;
            this.lcEmail.Text = "Email Address";
            // 
            // teLastName
            // 
            this.teLastName.EditValue = "";
            this.teLastName.Location = new System.Drawing.Point(18, 129);
            this.teLastName.Name = "teLastName";
            this.teLastName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.teLastName.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.teLastName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teLastName.Properties.Appearance.Options.UseBackColor = true;
            this.teLastName.Properties.Appearance.Options.UseBorderColor = true;
            this.teLastName.Properties.Appearance.Options.UseFont = true;
            this.teLastName.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teLastName.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.teLastName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teLastName.Properties.NullText = "Search";
            this.teLastName.Size = new System.Drawing.Size(300, 30);
            this.teLastName.TabIndex = 2;
            // 
            // lcLastName
            // 
            this.lcLastName.Location = new System.Drawing.Point(18, 107);
            this.lcLastName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcLastName.Name = "lcLastName";
            this.lcLastName.Size = new System.Drawing.Size(60, 16);
            this.lcLastName.TabIndex = 43;
            this.lcLastName.Text = "Last Name";
            // 
            // teFirstName
            // 
            this.teFirstName.EditValue = "";
            this.teFirstName.Location = new System.Drawing.Point(18, 66);
            this.teFirstName.Name = "teFirstName";
            this.teFirstName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.teFirstName.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.teFirstName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teFirstName.Properties.Appearance.Options.UseBackColor = true;
            this.teFirstName.Properties.Appearance.Options.UseBorderColor = true;
            this.teFirstName.Properties.Appearance.Options.UseFont = true;
            this.teFirstName.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teFirstName.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.teFirstName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teFirstName.Properties.NullText = "Search";
            this.teFirstName.Size = new System.Drawing.Size(300, 30);
            this.teFirstName.TabIndex = 1;
            // 
            // lcFirstName
            // 
            this.lcFirstName.Location = new System.Drawing.Point(18, 44);
            this.lcFirstName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcFirstName.Name = "lcFirstName";
            this.lcFirstName.Size = new System.Drawing.Size(62, 16);
            this.lcFirstName.TabIndex = 1;
            this.lcFirstName.Text = "First Name";
            // 
            // gcCardInfo
            // 
            this.gcCardInfo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.gcCardInfo.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.gcCardInfo.Appearance.Options.UseBackColor = true;
            this.gcCardInfo.Appearance.Options.UseBorderColor = true;
            this.gcCardInfo.Controls.Add(this.ceOther);
            this.gcCardInfo.Controls.Add(this.teCardHolder);
            this.gcCardInfo.Controls.Add(this.lcCardHolder);
            this.gcCardInfo.Controls.Add(this.teCSC);
            this.gcCardInfo.Controls.Add(this.lcCSC);
            this.gcCardInfo.Controls.Add(this.teYear);
            this.gcCardInfo.Controls.Add(this.lcYear);
            this.gcCardInfo.Controls.Add(this.teMonth);
            this.gcCardInfo.Controls.Add(this.lcMonth);
            this.gcCardInfo.Controls.Add(this.teCardNo);
            this.gcCardInfo.Controls.Add(this.lcCardNo);
            this.gcCardInfo.Location = new System.Drawing.Point(431, 89);
            this.gcCardInfo.Name = "gcCardInfo";
            this.gcCardInfo.Size = new System.Drawing.Size(336, 300);
            this.gcCardInfo.TabIndex = 2;
            this.gcCardInfo.Text = "Card Information";
            // 
            // ceOther
            // 
            this.ceOther.Location = new System.Drawing.Point(254, 131);
            this.ceOther.Name = "ceOther";
            this.ceOther.Properties.Appearance.Options.UseFont = true;
            this.ceOther.Properties.Caption = "Other";
            this.ceOther.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgCheckBox1;
            this.ceOther.Size = new System.Drawing.Size(64, 26);
            this.ceOther.TabIndex = 7;
            // 
            // teCardHolder
            // 
            this.teCardHolder.EditValue = "";
            this.teCardHolder.Location = new System.Drawing.Point(18, 129);
            this.teCardHolder.Name = "teCardHolder";
            this.teCardHolder.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.teCardHolder.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.teCardHolder.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teCardHolder.Properties.Appearance.Options.UseBackColor = true;
            this.teCardHolder.Properties.Appearance.Options.UseBorderColor = true;
            this.teCardHolder.Properties.Appearance.Options.UseFont = true;
            this.teCardHolder.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teCardHolder.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.teCardHolder.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teCardHolder.Properties.NullText = "Search";
            this.teCardHolder.Size = new System.Drawing.Size(227, 30);
            this.teCardHolder.TabIndex = 6;
            // 
            // lcCardHolder
            // 
            this.lcCardHolder.Location = new System.Drawing.Point(18, 107);
            this.lcCardHolder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcCardHolder.Name = "lcCardHolder";
            this.lcCardHolder.Size = new System.Drawing.Size(68, 16);
            this.lcCardHolder.TabIndex = 49;
            this.lcCardHolder.Text = "Card Holder";
            // 
            // teCSC
            // 
            this.teCSC.EditValue = "";
            this.teCSC.Location = new System.Drawing.Point(18, 245);
            this.teCSC.Name = "teCSC";
            this.teCSC.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.teCSC.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.teCSC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teCSC.Properties.Appearance.Options.UseBackColor = true;
            this.teCSC.Properties.Appearance.Options.UseBorderColor = true;
            this.teCSC.Properties.Appearance.Options.UseFont = true;
            this.teCSC.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teCSC.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.teCSC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teCSC.Properties.NullText = "Search";
            this.teCSC.Size = new System.Drawing.Size(300, 30);
            this.teCSC.TabIndex = 10;
            // 
            // lcCSC
            // 
            this.lcCSC.Location = new System.Drawing.Point(18, 223);
            this.lcCSC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcCSC.Name = "lcCSC";
            this.lcCSC.Size = new System.Drawing.Size(24, 16);
            this.lcCSC.TabIndex = 47;
            this.lcCSC.Text = "CSC";
            // 
            // teYear
            // 
            this.teYear.EditValue = "";
            this.teYear.Location = new System.Drawing.Point(178, 187);
            this.teYear.Name = "teYear";
            this.teYear.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.teYear.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.teYear.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teYear.Properties.Appearance.Options.UseBackColor = true;
            this.teYear.Properties.Appearance.Options.UseBorderColor = true;
            this.teYear.Properties.Appearance.Options.UseFont = true;
            this.teYear.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teYear.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.teYear.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teYear.Properties.NullText = "Search";
            this.teYear.Size = new System.Drawing.Size(140, 30);
            this.teYear.TabIndex = 9;
            // 
            // lcYear
            // 
            this.lcYear.Location = new System.Drawing.Point(178, 165);
            this.lcYear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcYear.Name = "lcYear";
            this.lcYear.Size = new System.Drawing.Size(26, 16);
            this.lcYear.TabIndex = 45;
            this.lcYear.Text = "Year";
            // 
            // teMonth
            // 
            this.teMonth.EditValue = "";
            this.teMonth.Location = new System.Drawing.Point(18, 187);
            this.teMonth.Name = "teMonth";
            this.teMonth.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.teMonth.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.teMonth.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMonth.Properties.Appearance.Options.UseBackColor = true;
            this.teMonth.Properties.Appearance.Options.UseBorderColor = true;
            this.teMonth.Properties.Appearance.Options.UseFont = true;
            this.teMonth.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teMonth.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.teMonth.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teMonth.Properties.NullText = "Search";
            this.teMonth.Size = new System.Drawing.Size(140, 30);
            this.teMonth.TabIndex = 8;
            // 
            // lcMonth
            // 
            this.lcMonth.Location = new System.Drawing.Point(18, 165);
            this.lcMonth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcMonth.Name = "lcMonth";
            this.lcMonth.Size = new System.Drawing.Size(35, 16);
            this.lcMonth.TabIndex = 43;
            this.lcMonth.Text = "Month";
            // 
            // teCardNo
            // 
            this.teCardNo.EditValue = "";
            this.teCardNo.Location = new System.Drawing.Point(18, 66);
            this.teCardNo.Name = "teCardNo";
            this.teCardNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.teCardNo.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.teCardNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teCardNo.Properties.Appearance.Options.UseBackColor = true;
            this.teCardNo.Properties.Appearance.Options.UseBorderColor = true;
            this.teCardNo.Properties.Appearance.Options.UseFont = true;
            this.teCardNo.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teCardNo.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.teCardNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teCardNo.Properties.NullText = "Search";
            this.teCardNo.Size = new System.Drawing.Size(300, 30);
            this.teCardNo.TabIndex = 5;
            // 
            // lcCardNo
            // 
            this.lcCardNo.Location = new System.Drawing.Point(18, 44);
            this.lcCardNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcCardNo.Name = "lcCardNo";
            this.lcCardNo.Size = new System.Drawing.Size(76, 16);
            this.lcCardNo.TabIndex = 1;
            this.lcCardNo.Text = "Card Number";
            // 
            // gcShippingAddress
            // 
            this.gcShippingAddress.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.gcShippingAddress.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.gcShippingAddress.Appearance.Options.UseBackColor = true;
            this.gcShippingAddress.Appearance.Options.UseBorderColor = true;
            this.gcShippingAddress.Controls.Add(this.comboState);
            this.gcShippingAddress.Controls.Add(this.lcState);
            this.gcShippingAddress.Controls.Add(this.teCity);
            this.gcShippingAddress.Controls.Add(this.lcCity);
            this.gcShippingAddress.Controls.Add(this.teZipCode);
            this.gcShippingAddress.Controls.Add(this.lcZipCode);
            this.gcShippingAddress.Controls.Add(this.teUnitNo);
            this.gcShippingAddress.Controls.Add(this.lcUnitNo);
            this.gcShippingAddress.Controls.Add(this.teStreetAddress);
            this.gcShippingAddress.Controls.Add(this.lcStreetAddress);
            this.gcShippingAddress.Location = new System.Drawing.Point(45, 419);
            this.gcShippingAddress.Name = "gcShippingAddress";
            this.gcShippingAddress.Size = new System.Drawing.Size(722, 182);
            this.gcShippingAddress.TabIndex = 3;
            this.gcShippingAddress.Text = "Shipping Address";
            // 
            // comboState
            // 
            this.comboState.EditValue = "Select state";
            this.comboState.Location = new System.Drawing.Point(525, 124);
            this.comboState.Name = "comboState";
            this.comboState.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.comboState.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.comboState.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboState.Properties.Appearance.Options.UseBackColor = true;
            this.comboState.Properties.Appearance.Options.UseBorderColor = true;
            this.comboState.Properties.Appearance.Options.UseFont = true;
            this.comboState.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboState.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.comboState.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.comboState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboState.Properties.Items.AddRange(new object[] {
            "Virginia",
            "New Jersey",
            "New York",
            "Los Angeles",
            "California",
            "Washington DC"});
            this.comboState.Properties.NullText = "Search";
            this.comboState.Size = new System.Drawing.Size(179, 30);
            this.comboState.TabIndex = 15;
            // 
            // lcState
            // 
            this.lcState.Location = new System.Drawing.Point(525, 102);
            this.lcState.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcState.Name = "lcState";
            this.lcState.Size = new System.Drawing.Size(30, 16);
            this.lcState.TabIndex = 49;
            this.lcState.Text = "State";
            // 
            // teCity
            // 
            this.teCity.EditValue = "";
            this.teCity.Location = new System.Drawing.Point(270, 124);
            this.teCity.Name = "teCity";
            this.teCity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.teCity.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.teCity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teCity.Properties.Appearance.Options.UseBackColor = true;
            this.teCity.Properties.Appearance.Options.UseBorderColor = true;
            this.teCity.Properties.Appearance.Options.UseFont = true;
            this.teCity.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teCity.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.teCity.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teCity.Properties.NullText = "Search";
            this.teCity.Size = new System.Drawing.Size(225, 30);
            this.teCity.TabIndex = 14;
            // 
            // lcCity
            // 
            this.lcCity.Location = new System.Drawing.Point(270, 102);
            this.lcCity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcCity.Name = "lcCity";
            this.lcCity.Size = new System.Drawing.Size(21, 16);
            this.lcCity.TabIndex = 47;
            this.lcCity.Text = "City";
            // 
            // teZipCode
            // 
            this.teZipCode.EditValue = "";
            this.teZipCode.Location = new System.Drawing.Point(18, 124);
            this.teZipCode.Name = "teZipCode";
            this.teZipCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.teZipCode.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.teZipCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teZipCode.Properties.Appearance.Options.UseBackColor = true;
            this.teZipCode.Properties.Appearance.Options.UseBorderColor = true;
            this.teZipCode.Properties.Appearance.Options.UseFont = true;
            this.teZipCode.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teZipCode.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.teZipCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teZipCode.Properties.NullText = "Search";
            this.teZipCode.Size = new System.Drawing.Size(225, 30);
            this.teZipCode.TabIndex = 13;
            // 
            // lcZipCode
            // 
            this.lcZipCode.Location = new System.Drawing.Point(18, 102);
            this.lcZipCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcZipCode.Name = "lcZipCode";
            this.lcZipCode.Size = new System.Drawing.Size(51, 16);
            this.lcZipCode.TabIndex = 45;
            this.lcZipCode.Text = "ZIP Code";
            // 
            // teUnitNo
            // 
            this.teUnitNo.EditValue = "";
            this.teUnitNo.Location = new System.Drawing.Point(525, 66);
            this.teUnitNo.Name = "teUnitNo";
            this.teUnitNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.teUnitNo.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.teUnitNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teUnitNo.Properties.Appearance.Options.UseBackColor = true;
            this.teUnitNo.Properties.Appearance.Options.UseBorderColor = true;
            this.teUnitNo.Properties.Appearance.Options.UseFont = true;
            this.teUnitNo.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teUnitNo.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.teUnitNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teUnitNo.Properties.NullText = "Search";
            this.teUnitNo.Size = new System.Drawing.Size(179, 30);
            this.teUnitNo.TabIndex = 12;
            // 
            // lcUnitNo
            // 
            this.lcUnitNo.Location = new System.Drawing.Point(525, 44);
            this.lcUnitNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcUnitNo.Name = "lcUnitNo";
            this.lcUnitNo.Size = new System.Drawing.Size(69, 16);
            this.lcUnitNo.TabIndex = 43;
            this.lcUnitNo.Text = "Apt/Unit No.";
            // 
            // teStreetAddress
            // 
            this.teStreetAddress.EditValue = "";
            this.teStreetAddress.Location = new System.Drawing.Point(18, 66);
            this.teStreetAddress.Name = "teStreetAddress";
            this.teStreetAddress.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.teStreetAddress.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.teStreetAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teStreetAddress.Properties.Appearance.Options.UseBackColor = true;
            this.teStreetAddress.Properties.Appearance.Options.UseBorderColor = true;
            this.teStreetAddress.Properties.Appearance.Options.UseFont = true;
            this.teStreetAddress.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teStreetAddress.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.teStreetAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teStreetAddress.Properties.NullText = "Search";
            this.teStreetAddress.Size = new System.Drawing.Size(477, 30);
            this.teStreetAddress.TabIndex = 11;
            // 
            // lcStreetAddress
            // 
            this.lcStreetAddress.Location = new System.Drawing.Point(18, 44);
            this.lcStreetAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lcStreetAddress.Name = "lcStreetAddress";
            this.lcStreetAddress.Size = new System.Drawing.Size(85, 16);
            this.lcStreetAddress.TabIndex = 1;
            this.lcStreetAddress.Text = "Street Address";
            // 
            // sbSave
            // 
            this.sbSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.sbSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbSave.Appearance.Options.UseBackColor = true;
            this.sbSave.Appearance.Options.UseFont = true;
            this.sbSave.Location = new System.Drawing.Point(654, 644);
            this.sbSave.Margin = new System.Windows.Forms.Padding(5);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(113, 33);
            this.sbSave.TabIndex = 16;
            this.sbSave.Text = "Save";
            this.sbSave.Click += new System.EventHandler(this.sbSave_Click);
            // 
            // peCross
            // 
            this.peCross.EditValue = ((object)(resources.GetObject("peCross.EditValue")));
            this.peCross.Location = new System.Drawing.Point(773, 12);
            this.peCross.Name = "peCross";
            this.peCross.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peCross.Properties.Appearance.Options.UseBackColor = true;
            this.peCross.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peCross.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peCross.Size = new System.Drawing.Size(26, 26);
            this.peCross.TabIndex = 0;
            this.peCross.Click += new System.EventHandler(this.peCross_Click);
            // 
            // dxError
            // 
            this.dxError.ContainerControl = this;
            // 
            // frmBillingInfo
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 708);
            this.Controls.Add(this.peCross);
            this.Controls.Add(this.sbSave);
            this.Controls.Add(this.gcShippingAddress);
            this.Controls.Add(this.gcCardInfo);
            this.Controls.Add(this.gcPersonal);
            this.Controls.Add(this.lcBillingInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBillingInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Billing Info";
            this.Load += new System.EventHandler(this.frmBillingInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcPersonal)).EndInit();
            this.gcPersonal.ResumeLayout(false);
            this.gcPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTelephone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCardInfo)).EndInit();
            this.gcCardInfo.ResumeLayout(false);
            this.gcCardInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceOther.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCardHolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCSC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCardNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcShippingAddress)).EndInit();
            this.gcShippingAddress.ResumeLayout(false);
            this.gcShippingAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teZipCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUnitNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teStreetAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCross.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lcBillingInfo;
        private DevExpress.XtraEditors.GroupControl gcPersonal;
        private DevExpress.XtraEditors.LabelControl lcFirstName;
        private DevExpress.XtraEditors.TextEdit teFirstName;
        private DevExpress.XtraEditors.TextEdit teLastName;
        private DevExpress.XtraEditors.LabelControl lcLastName;
        private DevExpress.XtraEditors.TextEdit teTelephone;
        private DevExpress.XtraEditors.LabelControl lcTelephone;
        private DevExpress.XtraEditors.TextEdit teEmail;
        private DevExpress.XtraEditors.LabelControl lcEmail;
        private DevExpress.XtraEditors.GroupControl gcCardInfo;
        private DevExpress.XtraEditors.TextEdit teCSC;
        private DevExpress.XtraEditors.LabelControl lcCSC;
        private DevExpress.XtraEditors.TextEdit teYear;
        private DevExpress.XtraEditors.LabelControl lcYear;
        private DevExpress.XtraEditors.TextEdit teMonth;
        private DevExpress.XtraEditors.LabelControl lcMonth;
        private DevExpress.XtraEditors.TextEdit teCardNo;
        private DevExpress.XtraEditors.LabelControl lcCardNo;
        private DevExpress.XtraEditors.GroupControl gcShippingAddress;
        private DevExpress.XtraEditors.TextEdit teCity;
        private DevExpress.XtraEditors.LabelControl lcCity;
        private DevExpress.XtraEditors.TextEdit teZipCode;
        private DevExpress.XtraEditors.LabelControl lcZipCode;
        private DevExpress.XtraEditors.TextEdit teUnitNo;
        private DevExpress.XtraEditors.LabelControl lcUnitNo;
        private DevExpress.XtraEditors.TextEdit teStreetAddress;
        private DevExpress.XtraEditors.LabelControl lcStreetAddress;
        private DevExpress.XtraEditors.LabelControl lcState;
        private DevExpress.XtraEditors.SimpleButton sbSave;
        private DevExpress.XtraEditors.ComboBoxEdit comboState;
        private DevExpress.XtraEditors.TextEdit teCardHolder;
        private DevExpress.XtraEditors.LabelControl lcCardHolder;
        private DevExpress.XtraEditors.CheckEdit ceOther;
        private DevExpress.XtraEditors.PictureEdit peCross;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxError;
    }
}