using DXApplication1.Global;
using DXApplication1.PRESENTATION_LAYER.Forms;
using System;
using System.Windows.Forms;

namespace DXApplication1.PRESENTATION_LAYER.UserControls
{
    public partial class ucBillingInfo : DevExpress.XtraEditors.XtraUserControl
    {
        private BLL.Billing.BillingInfoManager billingInfoManager;

        public int BillingID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string StreetAddress { get; set; }
        public string UnitNo { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CardNo { get; set; }
        public string MM { get; set; }
        public string YY { get; set; }
        public string CSC { get; set; }
        public string CardHolder { get; set; }
        public byte IsOther { get; set; }

        public ucBillingInfo()
        {
            InitializeComponent();
            FirstName = "";
            LastName = "";
            Email = "";
            Telephone = "";
            StreetAddress = "";
            UnitNo = "";
            ZipCode = "";
            City = "";
            State = "";
            CardNo = "";
            MM = "";
            YY = "";
            CSC = "";
            CardHolder = "";

            billingInfoManager = new BLL.Billing.BillingInfoManager();
        }

        public void save(bool isAddToDatabase, string mode)
        {
            lcName.Text = FirstName + " " + LastName;
            lcEmail.Text = Email;
            lcTelephone.Text = Telephone;
            lcAddress.Text = StreetAddress;
            lcCardNo.Text = CardNo;

            if (isAddToDatabase)
            {
                var status = billingInfoManager.saveBillingInfo(this, mode);
                int id = 0;
                int.TryParse(status, out id);

                if (id > 0)
                {
                    this.BillingID = id;
                    Global.globalObjects.FlowLayoutPanel_billings.Controls.Add(this);
                }
                else if (status != "ok")
                    MessageBox.Show(status);
            }
            else
                Global.globalObjects.FlowLayoutPanel_billings.Controls.Add(this);
        }

        private void peDelete_Click(object sender, EventArgs e)
        {
            var status = billingInfoManager.deleteBillingInfo(BillingID);

            if (status == "ok")
                globalObjects.FlowLayoutPanel_billings.Controls.Remove(this);
            else
                MessageBox.Show(status);
        }

        private void peEdit_Click(object sender, EventArgs e)
        {
            frmBillingInfo billingForm = new frmBillingInfo(this, "U");
            billingForm.ShowDialog();
        }
    }
}
