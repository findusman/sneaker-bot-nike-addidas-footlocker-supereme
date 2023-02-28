using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication1.DataAccessLayer;
using System.Data;

namespace DXApplication1.BLL.Task
{
    public class TaskInfoManager
    {
        private DataAccess dataAccess;

        public TaskInfoManager()
        {
            dataAccess = new DataAccess();
        }
        public string saveTaskInfo(PRESENTATION_LAYER.UserControls.ucTaskInfo model, string mode)
        {
            string status = "";
            try
            {
                string query;
                if (mode == "I")
                    query = "INSERT INTO Task_Information (AccountID ,BillingID ,ProxyID ,Name ,Website ,URL ,Size ,Color) VALUES (" + model.AccountID + ", " + model.BillingID + ", " + model.ProxyID + ", '" + model.ProductTitle + "', '" + model.Website + "', '" + model.URL + "', '" + model.ProductSize + "', '" + model.ProductColor + "');";
                else
                    query = "UPDATE Task_Information SET AccountID = " + model.AccountID + ", BillingID = " + model.BillingID + ", ProxyID = " + model.ProxyID + ", Name = '" + model.ProductTitle + "',  Website = '" + model.Website + "', URL = '" + model.URL + "', Size = '" + model.ProductSize + "', Color = '" + model.ProductColor + "' WHERE TaskID = " + model.TaskID + ";";

                status = dataAccess.executeQuery(query, mode);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return status;
        }

        public string deleteTaskInfo(int taskID)
        {
            string status = "";
            try
            {
                string query = "DELETE FROM Task_Information WHERE TaskID = " + taskID + ";";
                status = dataAccess.executeQuery(query, "D");
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return status;
        }

        public DataTable selectTaskInfo()
        {
            DataTable Datatable;
            try
            {
                string query = "SELECT * FROM Task_Information;";
                Datatable = dataAccess.executeSelectionQuery(query);
            }
            catch
            {
                return null;
            }

            return Datatable;
        }
    }

}
