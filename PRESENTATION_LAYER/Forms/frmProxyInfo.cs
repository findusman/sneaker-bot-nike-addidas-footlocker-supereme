using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXApplication1.PRESENTATION_LAYER.Forms
{
    public partial class frmProxyInfo : DevExpress.XtraEditors.XtraForm
    {
        public bool IsValidated { get; set; }
        private string mode;
        private PRESENTATION_LAYER.UserControls.ucProxyInfo ucProxy;

        public frmProxyInfo(string pmode)
        {
            InitializeComponent();
            mode = pmode;
            ucProxy = new PRESENTATION_LAYER.UserControls.ucProxyInfo();
        }

        public frmProxyInfo(PRESENTATION_LAYER.UserControls.ucProxyInfo ucProxy, string pmode) : this(pmode)
        {
            this.ucProxy = ucProxy;
            setValues(this.ucProxy);
        }

        private void peCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(teIP.Text))
            {
                teIP.Focus();
                dxError.SetError(teIP, "Please Enter IP address!");
            }
            else if (string.IsNullOrEmpty(tePort.Text))
            {
                tePort.Focus();
                dxError.SetError(tePort, "Please Enter Port!");
            }
            else if (string.IsNullOrEmpty(teUser.Text))
            {
                teUser.Focus();
                dxError.SetError(teUser, "Please Enter Your Password!");
            }
            else if (string.IsNullOrEmpty(tePassword.Text))
            {
                tePassword.Focus();
                dxError.SetError(tePassword, "Please Enter Your Password!");
            }
            else
            {
                IsValidated = true;
            }
            return IsValidated;
        }

        private void setDefaultValues()
        {
            teIP.Text = "192.162.156.14";
            tePort.Text = "8080";
            teUser.Text = "Dummy User";
            tePassword.Text = "123456abc";
        }

        private void setValues(PRESENTATION_LAYER.UserControls.ucProxyInfo ucProxyInfo)
        {
            teIP.Text = ucProxyInfo.IP;
            tePort.Text = ucProxyInfo.Port;
            teUser.Text = ucProxyInfo.User;
            tePassword.Text = ucProxyInfo.Password;
        }

        private void sbSave_Click(object sender, EventArgs e)
        {
            saveProxyProfile();
        }

        void saveProxyProfile()
        {
            if (ValidateForm() == true)
            {
                //ucProxyInfo ucProxy = new ucProxyInfo();
                ucProxy.IP = teIP.Text;
                ucProxy.Port = tePort.Text;
                ucProxy.User = teUser.Text;
                ucProxy.Password = tePassword.Text;
                ucProxy.save(true, mode);
                this.Close();
            }
        }

        private void frmProxyInfo_Load(object sender, EventArgs e)
        {
            //setDefaultValues();
        }
    }
}