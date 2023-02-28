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
    public partial class frmBillingInfo : DevExpress.XtraEditors.XtraForm
    {
        public bool IsValidated { get; set; }
        private string mode;
        private PRESENTATION_LAYER.UserControls.ucBillingInfo ucBilling;

        public frmBillingInfo(string pmode)
        {
            InitializeComponent();
            mode = pmode;
            ucBilling = new PRESENTATION_LAYER.UserControls.ucBillingInfo();
        }

        public frmBillingInfo(PRESENTATION_LAYER.UserControls.ucBillingInfo ucBilling, string pmode) : this(pmode)
        {
            this.ucBilling = ucBilling;
            setValues(this.ucBilling);
        }

        private void peCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateForm()
        {
            string namepattern = @"^[a-zA-Z]+$";
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                      @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                      @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            if (string.IsNullOrEmpty(teFirstName.Text))
            {
                teFirstName.Focus();
                dxError.SetError(teFirstName, "Please Enter Your Frist Name!");
            }
            else if (string.IsNullOrEmpty(teLastName.Text))
            {
                teLastName.Focus();
                dxError.SetError(teLastName, "Please Enter Your Last Name!");
            }
            else if (string.IsNullOrEmpty(teEmail.Text))
            {
                teEmail.Focus();
                dxError.SetError(teEmail, "Please Enter Your Email!");
            }
            else if (Regex.IsMatch(teEmail.Text, strRegex) == false)
            {
                teEmail.Focus();
                dxError.SetError(teEmail, "Enter Your Valid Email!");
            }
            else if (string.IsNullOrEmpty(teTelephone.Text))
            {
                teTelephone.Focus();
                dxError.SetError(teTelephone, "Please Enter Your Telephone!");
            }
            else if (string.IsNullOrEmpty(teCardNo.Text))
            {
                teCardNo.Focus();
                dxError.SetError(teCardNo, "Please Enter Your Debit/Credit Card Number!");
            }
            else if (string.IsNullOrEmpty(teCardHolder.Text))
            {
                teCardHolder.Focus();
                dxError.SetError(teCardHolder, "Please Enter Card Holder Name!");
            }
            else if (string.IsNullOrEmpty(teMonth.Text))
            {
                teMonth.Focus();
                dxError.SetError(teMonth, "Please Enter Your Card Expiry Month!");
            }
            else if (string.IsNullOrEmpty(teYear.Text))
            {
                teYear.Focus();
                dxError.SetError(teYear, "Please Enter Your Card Expiry Year!");
            }
            else if (string.IsNullOrEmpty(teStreetAddress.Text))
            {
                teStreetAddress.Focus();
                dxError.SetError(teStreetAddress, "Please Enter Your Street Address!");
            }
            else if (string.IsNullOrEmpty(teZipCode.Text))
            {
                teZipCode.Focus();
                dxError.SetError(teZipCode, "Please Enter Your Area ZIP Code!");
            }
            else if (string.IsNullOrEmpty(teCity.Text))
            {
                teCity.Focus();
                dxError.SetError(teCity, "Please Enter Your City!");
            }
            else if (comboState.SelectedIndex < 0)
            {
                comboState.Focus();
                dxError.SetError(comboState, "Please Select Your State!");
            }
            else
            {
                IsValidated = true;
            }
            return IsValidated;
        }

        private void setDefaultValues()
        {
            teFirstName.Text = "Ahmed";
            teLastName.Text = "Mushtaq";
            teEmail.Text = "ahmed@mail.com";
            teTelephone.Text = "123456789";

            teCardNo.Text = "134679142536285";
            teCardHolder.Text = "Ahmed";
            teMonth.Text = "10";
            teYear.Text = "25";
            teCSC.Text = "1697";

            teStreetAddress.Text = "West Road, Canal View";
            teUnitNo.Text = "168";
            teZipCode.Text = "49562";
            teCity.Text = "New Orleans";
            comboState.SelectedIndex = 1;
        }
        
        private void setValues(PRESENTATION_LAYER.UserControls.ucBillingInfo ucBillingInfo)
        {
            teFirstName.Text = ucBillingInfo.FirstName;
            teLastName.Text = ucBillingInfo.LastName;
            teEmail.Text = ucBillingInfo.Email;
            teTelephone.Text = ucBillingInfo.Telephone;

            teCardNo.Text = ucBillingInfo.CardNo;
            teCardHolder.Text = ucBillingInfo.CardHolder;
            ceOther.EditValue = ucBillingInfo.IsOther == 0 ? false : true;
            teMonth.Text = ucBillingInfo.MM;
            teYear.Text = ucBillingInfo.YY;
            teCSC.Text = ucBillingInfo.CSC;

            teStreetAddress.Text = ucBillingInfo.StreetAddress;
            teUnitNo.Text = ucBillingInfo.UnitNo;
            teZipCode.Text = ucBillingInfo.ZipCode;
            teCity.Text = ucBillingInfo.City;
            comboState.SelectedIndex = comboState.Properties.Items.IndexOf(ucBillingInfo.State);
        }

        private void sbSave_Click(object sender, EventArgs e)
        {
            saveBillingProfile();
        }

        void saveBillingProfile()
        {
            if (ValidateForm() == true)
            {
                //ucBillingInfo ucBilling = new ucBillingInfo();
                ucBilling.FirstName = teFirstName.Text;
                ucBilling.LastName = teLastName.Text;
                ucBilling.Email = teEmail.Text;
                ucBilling.Telephone = teTelephone.Text;

                ucBilling.CardNo = teCardNo.Text;
                ucBilling.CardHolder = teCardHolder.Text;
                ucBilling.IsOther = (bool)ceOther.EditValue ? (byte)1 : (byte)0;
                ucBilling.MM = teMonth.Text;
                ucBilling.YY = teYear.Text;
                ucBilling.CSC = teCSC.Text;

                ucBilling.StreetAddress = teStreetAddress.Text;
                ucBilling.UnitNo = teUnitNo.Text;
                ucBilling.ZipCode = teZipCode.Text;
                ucBilling.City = teCity.Text;
                ucBilling.State = (string)comboState.SelectedItem;
                ucBilling.save(true, mode);
                this.Close();
            }
        }

        private void frmBillingInfo_Load(object sender, EventArgs e)
        {
            //setDefaultValues();
        }
    }
}