using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXApplication1.DataAccessLayer;
using DXApplication1.Global;
using DXApplication1.PRESENTATION_LAYER.Forms;

namespace DXApplication1
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public static DataTable dtBillingInfos;
        public static DataTable dtAccountInfos;
        public static DataTable dtProxyInfos;

        public frmMain()
        {
            InitializeComponent();

            dtBillingInfos = null;
            dtAccountInfos = null;
            dtProxyInfos = null;

            panels.Add(panelControl_import);
            panels.Add(panelControl_proxies);
            panels.Add(panelControl_billing);
            panels.Add(panelControl_accounts);
            panels.Add(panelControl_rates);
            panels.Add(panelControl_settings);

            tabs.Add(xtraTabPage_tasks);
            tabs.Add(xtraTabPage_proxies);
            tabs.Add(xtraTabPage_billing);
            tabs.Add(xtraTabPage_accounts);
            tabs.Add(xtraTabPage_rates);
            tabs.Add(xtraTabPage_settings);

            globalObjects.FlowLayoutPanel_tasks = flowLayoutPanel_tasks;
            globalObjects.FlowLayoutPanel_proxies = flowLayoutPanel_proxies;
            globalObjects.FlowLayoutPanel_billings = flowLayoutPanel_billing;
            globalObjects.FlowLayoutPanel_accounts = flowLayoutPanel_account;

            initialize_BillingInfos();
            initialize_AccountInfos();
            initialize_ProxyInfos();
            initialize_TaskInfos();
        }

        List<DevExpress.XtraEditors.PanelControl> panels = new List<DevExpress.XtraEditors.PanelControl>();
        List<DevExpress.XtraTab.XtraTabPage> tabs = new List<DevExpress.XtraTab.XtraTabPage>();
        List<PRESENTATION_LAYER.UserControls.ucTaskInfo> listTasks = new List<PRESENTATION_LAYER.UserControls.ucTaskInfo>();

        private void initialize_BillingInfos()
        {
            BLL.Billing.BillingInfoManager billingInfoManager = new BLL.Billing.BillingInfoManager();
            dtBillingInfos = billingInfoManager.selectBillingInfo();

            foreach (DataRow row in dtBillingInfos.Rows)
            {
                PRESENTATION_LAYER.UserControls.ucBillingInfo ucBillingInfo = new PRESENTATION_LAYER.UserControls.ucBillingInfo();
                ucBillingInfo.BillingID = Convert.ToInt32(row[0].ToString());
                ucBillingInfo.FirstName = row[1].ToString();
                ucBillingInfo.LastName = row[2].ToString();
                ucBillingInfo.Email = row[3].ToString();
                ucBillingInfo.Telephone = row[4].ToString();
                ucBillingInfo.StreetAddress = row[5].ToString();
                ucBillingInfo.UnitNo = row[6].ToString();
                ucBillingInfo.ZipCode = row[7].ToString();
                ucBillingInfo.City = row[8].ToString();
                ucBillingInfo.State = row[9].ToString();
                ucBillingInfo.CardNo = row[10].ToString();
                ucBillingInfo.MM = row[11].ToString();
                ucBillingInfo.YY = row[12].ToString();
                ucBillingInfo.CSC = row[13].ToString();
                ucBillingInfo.CardHolder = row[14].ToString();
                ucBillingInfo.IsOther = (bool)row[15] ? (byte)1 : (byte)0;
                ucBillingInfo.save(false, "");
            }
        }

        private void initialize_AccountInfos()
        {
            BLL.Account.AccountInfoManager accountInfoManager = new BLL.Account.AccountInfoManager();
            dtAccountInfos = accountInfoManager.selectAccountInfos();

            foreach (DataRow row in dtAccountInfos.Rows)
            {
                PRESENTATION_LAYER.UserControls.ucAccountInfo ucAccountInfo = new PRESENTATION_LAYER.UserControls.ucAccountInfo();
                ucAccountInfo.AccountID = Convert.ToInt32(row[0].ToString());
                ucAccountInfo.Website = row[1].ToString();
                ucAccountInfo.UserID = row[2].ToString();
                ucAccountInfo.Password = row[3].ToString();
                ucAccountInfo.save(false, "");
            }
        }

        private void initialize_ProxyInfos()
        {
            BLL.Proxy.ProxyInfoManager proxyInfoManager = new BLL.Proxy.ProxyInfoManager();
            dtProxyInfos = proxyInfoManager.selectProxyInfos();

            foreach (DataRow row in dtProxyInfos.Rows)
            {
                PRESENTATION_LAYER.UserControls.ucProxyInfo ucProxyInfo = new PRESENTATION_LAYER.UserControls.ucProxyInfo();
                ucProxyInfo.ProxyID = Convert.ToInt32(row[0].ToString());
                ucProxyInfo.IP = row[1].ToString();
                ucProxyInfo.Port = row[2].ToString();
                ucProxyInfo.User = row[3].ToString();
                ucProxyInfo.Password = row[4].ToString();
                ucProxyInfo.save(false, "");
            }
        }

        private void initialize_TaskInfos()
        {
            BLL.Task.TaskInfoManager taskInfoManager = new BLL.Task.TaskInfoManager();
            DataTable taskInfos = taskInfoManager.selectTaskInfo();

            foreach (DataRow row in taskInfos.Rows)
            {
                PRESENTATION_LAYER.UserControls.ucTaskInfo ucTaskInfo = new PRESENTATION_LAYER.UserControls.ucTaskInfo();
                ucTaskInfo.TaskID = Convert.ToInt32(row[0].ToString());
                ucTaskInfo.AccountID = Convert.ToInt32(row[1].ToString());
                ucTaskInfo.BillingID = Convert.ToInt32(row[2].ToString());
                ucTaskInfo.ProxyID = Convert.ToInt32(row[3].ToString());
                ucTaskInfo.ProductTitle = row[4].ToString();
                ucTaskInfo.Website = row[5].ToString();
                ucTaskInfo.URL = row[6].ToString();
                ucTaskInfo.ProductSize = row[7].ToString();
                ucTaskInfo.ProductColor = row[8].ToString();
                ucTaskInfo.save(false, "");
            }
        }

        private void adjustUI()
        {
            textEdit2.Location =
            textEdit5.Location =
            textEdit3.Location =
            textEdit4.Location =
            //textEdit7.Location =
            textEdit6.Location =
            new Point((ClientSize.Width / 2 - textEdit2.Size.Width / 2), labelControl1.Location.Y);


            //panelControl14.Location =
            //  new Point((ClientSize.Width / 2 - panelControl14.Size.Width / 2), 10);

            panelControl_tasksContainer.Location =
            panelControl1.Location =
            panelControl37.Location =
            panelControl32.Location =
            panelControl34.Location =
            panelControl39.Location =
            new Point((ClientSize.Width / 2 - panelControl_tasksContainer.Size.Width / 2), 150);




            // textEdit_search.Left = this..Width;
            //textEdit_search.Location = new Point((this.Width - textEdit_search.Width) / 2, 5);

            //textEdit_search.Left = (this.Width - textEdit_search.Width) / 2;
            //textEdit_search.Top = (this.ClientSize.Height - textEdit_search.Height) / 2;




        }
        private void adjustActiveMenuColor(string str)
        {


            foreach (PanelControl item in panels)
                item.Visible = false;

            if (str == "simpleButton_import")
                panelControl_import.Visible = true;
            else if (str == "simpleButton_proxies")
                panelControl_proxies.Visible = true;
            else if (str == "simpleButton_billing")
                panelControl_billing.Visible = true;
            else if (str == "simpleButton_accounts")
                panelControl_accounts.Visible = true;
            else if (str == "simpleButton_rates")
                panelControl_rates.Visible = true;
            else if (str == "simpleButton_setting")
                panelControl_settings.Visible = true;

        }
        private void adjustActiveTabs(DevExpress.XtraTab.XtraTabPage tab)
        {


            foreach (DevExpress.XtraTab.XtraTabPage item in tabs)
                item.PageVisible = false;

            tab.PageVisible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adjustUI();
            //xtraTabPage_proxies.PageVisible = false;
            adjustActiveTabs(xtraTabPage_tasks);
            addTask();
        }



        void addTask()
        {






        }


        //public void select_data_from_db()
        //{
        //    // connectivity.sqlCompact.Open();
        //    sqlConnector.command = new SqlCeCommand("SELECT * FROM Billing_Information", sqlConnector.connection);
        //    SqlCeDataAdapter da = new SqlCeDataAdapter(sqlConnector.command);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    foreach (DataRow r in dt.Rows)
        //    {
        //        ucBillingInfo ucBilling = new ucBillingInfo();
        //        var id = r[0];
        //        var Name = r[1];
        //        var Email = r[2];
        //        var Phone_Number = r[3];
        //        var Billing_City = r[5];
        //        var Billing_Address = r[6];
        //        var Bank = r[7];
        //        var Card_Number = r[8];
        //        var Caed_vvalue = r[9];
        //        var Card_Expire = r[10];

        //        //Show Data in pannel 

        //        ucBilling.StoreName = Name.ToString();
        //        ucBilling.StoreEmail = Email.ToString();
        //        ucBilling.Store_Phone = Phone_Number.ToString();
        //        ucBilling.Store_City = Billing_City.ToString();
        //        ucBilling.Store_address = Billing_Address.ToString();
        //        ucBilling.Store_Bank_card = Bank.ToString();
        //        ucBilling.Store_Card = Card_Number.ToString();
        //        ucBilling.Store_card_value = Caed_vvalue.ToString();
        //        ucBilling.Store_card_Expire = Card_Expire.ToString();

        //        flowLayoutPanel_billing.Controls.Add(ucBilling);
        //    }

        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton_rates_Click(object sender, EventArgs e)
        {
            adjustActiveMenuColor(((SimpleButton)sender).Name);
            adjustActiveTabs(xtraTabPage_rates);
        }

        private void simpleButton_proxies_Click(object sender, EventArgs e)
        {
            adjustActiveMenuColor(((SimpleButton)sender).Name);
            adjustActiveTabs(xtraTabPage_proxies);
        }

        private void simpleButton_billing_Click(object sender, EventArgs e)
        {
            adjustActiveMenuColor(((SimpleButton)sender).Name);
            adjustActiveTabs(xtraTabPage_billing);
        }

        private void simpleButton_accounts_Click(object sender, EventArgs e)
        {
            adjustActiveMenuColor(((SimpleButton)sender).Name);
            adjustActiveTabs(xtraTabPage_accounts);
        }

        private void simpleButton_import_Click(object sender, EventArgs e)
        {
            adjustActiveMenuColor(((SimpleButton)sender).Name);
            adjustActiveTabs(xtraTabPage_tasks);
        }

        private void simpleButton_setting_Click(object sender, EventArgs e)
        {
            adjustActiveMenuColor(((SimpleButton)sender).Name);
            adjustActiveTabs(xtraTabPage_settings);
        }

        private void panelControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelControl69_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton_createTask_Click(object sender, EventArgs e)
        {
            frmTaskInfo obj_frmTask = new frmTaskInfo("I");
            obj_frmTask.ShowDialog();

            //flowLayoutPanel_tasks.Controls.Add(obj_frmTask.obj_task);
            //listTasks.Add(obj_frmTask.obj_task);
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {


            // flowLayoutPanel1.Controls.Remove(); 


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton30_Click(object sender, EventArgs e)
        {
            frmProxyInfo obj_Proxies = new frmProxyInfo("I");
            obj_Proxies.ShowDialog();

            //flowLayoutPanel_proxies.Controls.Add(obj_Proxies.obj_ucProxies);
            //listTasks.Add(obj_Proxies.obj_ucProxies);

        }

        private void sbCreateProfile_Click(object sender, EventArgs e)
        {
            frmBillingInfo billingForm = new frmBillingInfo("I");
            billingForm.ShowDialog();

            //if (billingForm.IsValidated)
            //{
            //    flowLayoutPanel_billing.Controls.Add(billingForm.ucBilling);
            //    //listBilling.Add(obj_billing.ucBilling);
            //}
        }

        private void sbCreateAccount_Click(object sender, EventArgs e)
        {
            frmAccountInfo accountForm = new frmAccountInfo("I");
            accountForm.ShowDialog();
        }
    }




}
