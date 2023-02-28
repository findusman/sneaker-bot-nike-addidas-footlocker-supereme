using DXApplication1.Global;
using DXApplication1.PRESENTATION_LAYER.Forms;
using System;
using System.Windows.Forms;

namespace DXApplication1.PRESENTATION_LAYER.UserControls
{
    public partial class ucTaskInfo : DevExpress.XtraEditors.XtraUserControl
    {
        private BLL.Task.TaskInfoManager taskInfoManager;

        public int TaskID { get; set; }
        public int AccountID { get; set; }
        public int BillingID { get; set; }
        public int ProxyID { get; set; }
        public string ProductTitle { get; set; }
        public string Website { get; set; }
        public string URL { get; set; }
        public string ProductSize { get; set; }
        public string ProductColor { get; set; }

        public ucTaskInfo()
        {
            InitializeComponent();
            ProductTitle = "";
            Website = "";
            URL = "";
            ProductSize = "";
            ProductColor = "";

            taskInfoManager = new BLL.Task.TaskInfoManager();
        }

        public void save(bool isAddToDatabase, string mode)
        {
            lcProductTitle.Text = ProductTitle;
            lcWebsite.Text = Website;
            //lcBillingInfo.Text = Telephone;
            lcSize.Text = ProductSize;
            //lcCardNo.Text = CardNo;

            if (isAddToDatabase)
            {
                var status = taskInfoManager.saveTaskInfo(this, mode);
                int id = 0;
                int.TryParse(status, out id);

                if (id > 0)
                {
                    this.TaskID = id;
                    Global.globalObjects.FlowLayoutPanel_tasks.Controls.Add(this);
                }
                else if (status != "ok")
                    MessageBox.Show(status);
            }
            else
                Global.globalObjects.FlowLayoutPanel_tasks.Controls.Add(this);
        }

        private void peDelete_Click(object sender, EventArgs e)
        {
            var status = taskInfoManager.deleteTaskInfo(TaskID);

            if (status == "ok")
                globalObjects.FlowLayoutPanel_tasks.Controls.Remove(this);
            else
                MessageBox.Show(status);
        }

        private void peEdit_Click(object sender, EventArgs e)
        {
            frmTaskInfo taskForm = new frmTaskInfo(this, "U");
            taskForm.ShowDialog();
        }
    }
}
