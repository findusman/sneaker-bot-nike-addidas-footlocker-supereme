using System.Data;
using System.Data.SqlServerCe;

namespace DXApplication1.DataAccessLayer
{
    public class DataAccess
    {
        private SqlCeConnection connection;
        private SqlCeCommand command;

        public DataAccess()
        {
            connection = new SqlCeConnection(@"Data Source=" + System.Windows.Forms.Application.StartupPath + @"\SneakerBot_Database.sdf; Persist Security Info=False;");
            command = new SqlCeCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
        }

        public ConnectionState GetState()
        {
            return connection.State;
        }

        public string executeQuery(string query, string mode)
        {
            string msg = "ok";
            try
            {
                connection.Open();
                command.CommandText = query;
                command.ExecuteNonQuery();
                if (mode == "I")
                {
                    command.CommandText = "SELECT @@IDENTITY;";
                    msg = command.ExecuteScalar().ToString();
                }
                connection.Close();
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }

            return msg;
        }

        public DataTable executeSelectionQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                command.CommandText = query;
                SqlCeDataAdapter da = new SqlCeDataAdapter(command);
                da.Fill(dt);
                connection.Close();
            }
            catch
            {
                return null;
            }

            return dt;
        }
    }
}
