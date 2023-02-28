using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.BLL.Account
{
    public class AccountInfoManager
    {
        private DataAccessLayer.DataAccess dataAccess;

        public AccountInfoManager()
        {
            dataAccess = new DataAccessLayer.DataAccess();
        }
        public string saveAccountInfo(PRESENTATION_LAYER.UserControls.ucAccountInfo model, string mode)
        {
            string status = "";
            try
            {
                string query;
                if (mode == "I")
                    query = "INSERT INTO Account_Information (Website, UserID, Password) VALUES ('" + model.Website + "', '" + model.UserID + "', '" + model.Password + "');";
                else
                    query = "UPDATE Account_Information SET Website = '" + model.Website + "', UserID = '" + model.UserID + "', Password = '" + model.Password + "' WHERE AccountID = " + model.AccountID + ";";

                status = dataAccess.executeQuery(query, mode);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return status;
        }

        public string deleteAccountInfo(int accountID)
        {
            string status = "";
            try
            {
                string query = "DELETE FROM Account_Information WHERE AccountID = " + accountID + ";";
                status = dataAccess.executeQuery(query, "D");
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return status;
        }

        public DataTable selectAccountInfos()
        {
            DataTable Datatable;
            try
            {
                string query = "SELECT * FROM Account_Information;";
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
