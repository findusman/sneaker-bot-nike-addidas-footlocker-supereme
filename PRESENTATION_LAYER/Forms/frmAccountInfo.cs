using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.PRESENTATION_LAYER.Forms
{
    public partial class frmAccountInfo : DevExpress.XtraEditors.XtraForm
    {
        public bool IsValidated { get; set; }
        private string mode;
        private PRESENTATION_LAYER.UserControls.ucAccountInfo ucAccount;

        public frmAccountInfo(string pmode)
        {
            InitializeComponent();
            mode = pmode;
            ucAccount = new PRESENTATION_LAYER.UserControls.ucAccountInfo();
        }

        public frmAccountInfo(PRESENTATION_LAYER.UserControls.ucAccountInfo ucAccount, string pmode) : this(pmode)
        {
            this.ucAccount = ucAccount;
            setValues(this.ucAccount);
        }

        private void peCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(teWebsite.Text))
            {
                teWebsite.Focus();
                dxError.SetError(teWebsite, "Please Enter Website!");
            }
            else if (string.IsNullOrEmpty(teUserID.Text))
            {
                teUserID.Focus();
                dxError.SetError(teUserID, "Please Enter Your User ID!");
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
            teWebsite.Text = "Footlocker";
            teUserID.Text = "ahmed@mail.com";
            tePassword.Text = "123456abc";
        }

        private void setValues(PRESENTATION_LAYER.UserControls.ucAccountInfo ucAccountInfo)
        {
            teWebsite.Text = ucAccountInfo.Website;
            teUserID.Text = ucAccountInfo.UserID;
            tePassword.Text = ucAccountInfo.Password;
        }

        private void sbSave_Click(object sender, EventArgs e)
        {
            saveAccountProfile();
        }

        void saveAccountProfile()
        {
            if (ValidateForm() == true)
            {
                //ucAccountInfo ucAccount = new ucAccountInfo();
                ucAccount.Website = teWebsite.Text;
                ucAccount.UserID = teUserID.Text;
                ucAccount.Password = tePassword.Text;
                ucAccount.save(true, mode);
                this.Close();
            }
        }

        private void frmAccountInfo_Load(object sender, EventArgs e)
        {
            //setDefaultValues();
        }
    }
}