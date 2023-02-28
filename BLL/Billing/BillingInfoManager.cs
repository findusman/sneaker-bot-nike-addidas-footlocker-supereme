using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication1.DataAccessLayer;
using System.Data;

namespace DXApplication1.BLL.Billing
{
    public class BillingInfoManager
    {
        private DataAccess dataAccess;

        public BillingInfoManager()
        {
            dataAccess = new DataAccess();
        }
        public string saveBillingInfo(PRESENTATION_LAYER.UserControls.ucBillingInfo model, string mode)
        {
            string status = "";
            try
            {
                string query;
                if (mode == "I")
                    query = "INSERT INTO Billing_Information (FirstName, LastName, Email, Telephone, StreetAddress, UnitNo, ZipCode, City, State, CardNo, MM, YY, CSC, CardHolder, IsOther) VALUES ('" + model.FirstName + "', '" + model.LastName + "', '" + model.Email + "', '" + model.Telephone + "', '" + model.StreetAddress + "', '" + model.UnitNo + "', '" + model.ZipCode + "', '" + model.City + "', '" + model.State + "', '" + model.CardNo + "', '" + model.MM + "', '" + model.YY + "', '" + model.CSC + "', '" + model.CardHolder + "', " + model.IsOther + ");";
                else
                    query = "UPDATE Billing_Information SET FirstName = '" + model.FirstName + "', LastName = '" + model.LastName + "', Email = '" + model.Email + "', Telephone = '" + model.Telephone + "',  StreetAddress = '" + model.StreetAddress + "', UnitNo = '" + model.UnitNo + "', ZipCode = '" + model.ZipCode + "', City = '" + model.City + "', State = '" + model.State + "', CardNo = '" + model.CardNo + "', MM = '" + model.MM + "', YY = '" + model.YY + "', CardHolder = '" + model.CardHolder + "', IsOther = " + model.IsOther  + " WHERE BillingID = " + model.BillingID + ";";

                status = dataAccess.executeQuery(query, mode);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return status;
        }

        public string deleteBillingInfo(int billingID)
        {
            string status = "";
            try
            {
                string query = "DELETE FROM Billing_Information WHERE BillingID = " + billingID + ";";
                status = dataAccess.executeQuery(query, "D");
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return status;
        }

        public DataTable selectBillingInfo()
        {
            DataTable Datatable;
            try
            {
                string query = "SELECT * FROM Billing_Information;";
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
