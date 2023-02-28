using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXApplication1.Global;

namespace DXApplication1.PRESENTATION_LAYER.UserControls
{
    public partial class ucProxyInfo : DevExpress.XtraEditors.XtraUserControl
    {
        private BLL.Proxy.ProxyInfoManager proxyManager;

        public int ProxyID { get; set; }
        public string IP { get; set; }
        public string Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public ucProxyInfo()
        {
            InitializeComponent();
            IP = "";
            Port = "";
            User = "";
            Password = "";

            proxyManager = new BLL.Proxy.ProxyInfoManager();
        }

        public void save(bool isAddToDatabase, string mode)
        {
            lcIP.Text = IP;
            lcPort.Text = Port;
            lcUser.Text = User;
            //lcPassword.Text = Password;

            if (isAddToDatabase)
            {
                var status = proxyManager.saveProxyInfo(this, mode);
                int id = 0;
                int.TryParse(status, out id);

                if (id > 0)
                {
                    this.ProxyID = id;
                    Global.globalObjects.FlowLayoutPanel_proxies.Controls.Add(this);
                }
                else if (status != "ok")
                    MessageBox.Show(status);
            }
            else
                Global.globalObjects.FlowLayoutPanel_proxies.Controls.Add(this);
        }

        private void peDelete_Click(object sender, EventArgs e)
        {
            var status = proxyManager.deleteProxyInfo(ProxyID);

            if (status == "ok")
                globalObjects.FlowLayoutPanel_proxies.Controls.Remove(this);
            else
                MessageBox.Show(status);
        }

        private void peEdit_Click(object sender, EventArgs e)
        {
            PRESENTATION_LAYER.Forms.frmProxyInfo proxyForm = new PRESENTATION_LAYER.Forms.frmProxyInfo(this, "U");
            proxyForm.ShowDialog();
        }
    }
}
