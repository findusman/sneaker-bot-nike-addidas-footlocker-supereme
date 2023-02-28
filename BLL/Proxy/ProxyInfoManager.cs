using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.BLL.Proxy
{
    public class ProxyInfoManager
    {
        private DataAccessLayer.DataAccess dataAccess;

        public ProxyInfoManager()
        {
            dataAccess = new DataAccessLayer.DataAccess();
        }
        public string saveProxyInfo(PRESENTATION_LAYER.UserControls.ucProxyInfo model, string mode)
        {
            string status = "";
            try
            {
                string query;
                if (mode == "I")
                    query = "INSERT INTO Proxy_Information (IP, Port, [User], Password) VALUES ('" + model.IP + "', '" + model.Port + "', '" + model.User + "', '" + model.Password + "');";
                else
                    query = "UPDATE Proxy_Information SET IP = '" + model.IP + "', [User] = '" + model.User + "', Port = '" + model.Port + "', Password = '" + model.Password + "' WHERE ProxyID = " + model.ProxyID + ";";

                status = dataAccess.executeQuery(query, mode);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return status;
        }

        public string deleteProxyInfo(int proxyID)
        {
            string status = "";
            try
            {
                string query = "DELETE FROM Proxy_Information WHERE ProxyID = " + proxyID + ";";
                status = dataAccess.executeQuery(query, "D");
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return status;
        }

        public DataTable selectProxyInfos()
        {
            DataTable Datatable;
            try
            {
                string query = "SELECT * FROM Proxy_Information;";
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
