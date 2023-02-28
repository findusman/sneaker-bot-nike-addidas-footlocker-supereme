using DXApplication1.Global;
using System;
using System.Windows.Forms;

namespace DXApplication1.PRESENTATION_LAYER.UserControls
{
    public partial class ucAccountInfo : DevExpress.XtraEditors.XtraUserControl
    {
        private BLL.Account.AccountInfoManager accountManager;

        public int AccountID { get; set; }
        public string Website { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }

        public ucAccountInfo()
        {
            InitializeComponent();
            Website = "";
            UserID = "";
            Password = "";

            accountManager = new BLL.Account.AccountInfoManager();
        }

        public void save(bool isAddToDatabase, string mode)
        {
            lcWebsite.Text = Website;
            lcEmail.Text = UserID;

            if (isAddToDatabase)
            {
                var status = accountManager.saveAccountInfo(this, mode);
                int id = 0;
                int.TryParse(status, out id);

                if (id > 0)
                {
                    this.AccountID = id;
                    Global.globalObjects.FlowLayoutPanel_accounts.Controls.Add(this);
                }
                else if (status != "ok")
                    MessageBox.Show(status);
            }
            else
                Global.globalObjects.FlowLayoutPanel_accounts.Controls.Add(this);
        }

        private void peDelete_Click(object sender, EventArgs e)
        {
            var status = accountManager.deleteAccountInfo(AccountID);

            if (status == "ok")
                globalObjects.FlowLayoutPanel_accounts.Controls.Remove(this);
            else
                MessageBox.Show(status);
        }

        private void peEdit_Click(object sender, EventArgs e)
        {
            PRESENTATION_LAYER.Forms.frmAccountInfo accountForm = new PRESENTATION_LAYER.Forms.frmAccountInfo(this, "U");
            accountForm.ShowDialog();
        }
    }
}
