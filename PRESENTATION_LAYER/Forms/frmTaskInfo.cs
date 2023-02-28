using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.PRESENTATION_LAYER.Forms
{
    public partial class frmTaskInfo : DevExpress.XtraEditors.XtraForm
    {
        public bool IsValidated { get; set; }
        private string mode;
        private UserControls.ucTaskInfo ucTask;

        public frmTaskInfo(string pmode)
        {
            InitializeComponent();
            mode = pmode;
            ucTask = new UserControls.ucTaskInfo();
        }

        public frmTaskInfo(UserControls.ucTaskInfo ucTask, string pmode) : this(pmode)
        {
            this.ucTask = ucTask;
            setValues(this.ucTask);
        }

        private void peCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(teProductTitle.Text))
            {
                teProductTitle.Focus();
                dxError.SetError(teProductTitle, "Please Enter Product Name!");
            }
            else if (comboWebsite.SelectedIndex < 0)
            {
                comboWebsite.Focus();
                dxError.SetError(comboWebsite, "Please Select Webiste!");
            }
            else if (string.IsNullOrEmpty(teURL.Text))
            {
                teURL.Focus();
                dxError.SetError(teURL, "Please Enter Product URL!");
            }
            else if (comboSize.SelectedIndex < 0)
            {
                comboSize.Focus();
                dxError.SetError(comboSize, "Please Select Product Size!");
            }
            else if (comboColor.SelectedIndex < 0)
            {
                comboColor.Focus();
                dxError.SetError(comboColor, "Please Select Product Color!");
            }
            else if (leBillingInfo.EditValue == null)
            {
                leBillingInfo.Focus();
                dxError.SetError(leBillingInfo, "Please Select Billing Profile!");
            }
            else if (leProxyInfo.EditValue == null)
            {
                leProxyInfo.Focus();
                dxError.SetError(leProxyInfo, "Please Select Proxy!");
            }
            else if (leAccountInfo.EditValue == null)
            {
                leAccountInfo.Focus();
                dxError.SetError(leAccountInfo, "Please Select Account!");
            }
            else
            {
                IsValidated = true;
            }
            return IsValidated;
        }

        private void setDefaultValues()
        {
            teProductTitle.Text = "Jordan Zoom '92";
            comboWebsite.SelectedIndex = 1;
            teURL.Text = "https://www.footlocker.com/category/mens/jordan.html";
            comboSize.SelectedIndex = 1;
            comboColor.SelectedIndex = 1;
            leBillingInfo.EditValue = 1;
            leAccountInfo.EditValue = 1;
            leProxyInfo.EditValue = 1;
        }

        private void setValues(UserControls.ucTaskInfo ucTaskInfo)
        {
            teProductTitle.Text = ucTaskInfo.ProductTitle;
            comboWebsite.SelectedIndex = comboWebsite.Properties.Items.IndexOf(ucTaskInfo.Website);
            teURL.Text = ucTaskInfo.URL;
            comboSize.SelectedIndex = comboSize.Properties.Items.IndexOf(ucTaskInfo.ProductSize);
            comboColor.SelectedIndex = comboColor.Properties.Items.IndexOf(ucTaskInfo.ProductColor);
            leBillingInfo.EditValue = ucTaskInfo.BillingID;
            leAccountInfo.EditValue = ucTaskInfo.AccountID;
            leProxyInfo.EditValue = ucTaskInfo.ProxyID;
        }

        private void sbSave_Click(object sender, EventArgs e)
        {
            saveTaskProfile();
        }

        void saveTaskProfile()
        {
            if (ValidateForm() == true)
            {
                //ucTaskInfo ucTask = new ucTaskInfo();
                ucTask.ProductTitle = teProductTitle.Text;
                ucTask.Website = (string)comboWebsite.SelectedItem;
                ucTask.URL = teURL.Text;
                ucTask.ProductSize = (string)comboSize.SelectedItem;
                ucTask.ProductColor = (string)comboColor.SelectedItem;
                ucTask.BillingID = (int)leBillingInfo.EditValue;
                ucTask.AccountID = (int)leAccountInfo.EditValue;
                ucTask.ProxyID = (int)leProxyInfo.EditValue;

                ucTask.save(true, mode);
                this.Close();
            }
        }

        private void frmTaskInfo_Load(object sender, EventArgs e)
        {
            //setDefaultValues();
            leAccountInfo.Properties.DataSource = frmMain.dtAccountInfos;
            leAccountInfo.Properties.PopulateColumns();
            leAccountInfo.Properties.DisplayMember = "UserID";
            leAccountInfo.Properties.ValueMember = "AccountID";
            leAccountInfo.Properties.Columns["AccountID"].Visible = false;
            leAccountInfo.Properties.Columns["Website"].Visible = false;
            leAccountInfo.Properties.Columns["Password"].Visible = false;

            leBillingInfo.Properties.DataSource = frmMain.dtBillingInfos;
            leBillingInfo.Properties.PopulateColumns();
            leBillingInfo.Properties.DisplayMember = "Email";
            leBillingInfo.Properties.ValueMember = "BillingID";
            leBillingInfo.Properties.Columns["FirstName"].Visible = false;
            leBillingInfo.Properties.Columns["LastName"].Visible = false;
            leBillingInfo.Properties.Columns["BillingID"].Visible = false;
            //leBillingInfo.Properties.Columns["Email"].Visible = false;
            leBillingInfo.Properties.Columns["Telephone"].Visible = false;
            leBillingInfo.Properties.Columns["StreetAddress"].Visible = false;
            leBillingInfo.Properties.Columns["UnitNo"].Visible = false;
            leBillingInfo.Properties.Columns["ZipCode"].Visible = false;
            leBillingInfo.Properties.Columns["City"].Visible = false;
            leBillingInfo.Properties.Columns["State"].Visible = false;
            leBillingInfo.Properties.Columns["CardNo"].Visible = false;
            leBillingInfo.Properties.Columns["MM"].Visible = false;
            leBillingInfo.Properties.Columns["YY"].Visible = false;
            leBillingInfo.Properties.Columns["CSC"].Visible = false;
            leBillingInfo.Properties.Columns["CardHolder"].Visible = false;
            leBillingInfo.Properties.Columns["IsOther"].Visible = false;

            leProxyInfo.Properties.DataSource = frmMain.dtProxyInfos;
            leProxyInfo.Properties.PopulateColumns();
            leProxyInfo.Properties.DisplayMember = "User";
            leProxyInfo.Properties.ValueMember = "ProxyID";
            leProxyInfo.Properties.Columns["ProxyID"].Visible = false;
            leProxyInfo.Properties.Columns["IP"].Visible = false;
            leProxyInfo.Properties.Columns["Port"].Visible = false;
            leProxyInfo.Properties.Columns["Password"].Visible = false;

            if (ucTask.TaskID == 0)
            {
                leAccountInfo.EditValue = frmMain.dtAccountInfos.Rows[0]["AccountID"];
                leProxyInfo.EditValue = frmMain.dtProxyInfos.Rows[0]["ProxyID"];
                leBillingInfo.EditValue = frmMain.dtBillingInfos.Rows[0]["BillingID"];
            }
        }
    }
}