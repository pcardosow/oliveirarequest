
using System.Data.SqlClient;

namespace VisualInterface.Connection
{
    class Connection
    {
        SqlConnection conn = new SqlConnection();
       
        public Connection()
        {
            conn.ConnectionString = @"Data Source=NOTE_PEDRO;Initial Catalog=DBTarefa;Integrated Security=True";
        }

        public SqlConnection RealizeConnection()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn;
           
        }

        public void Desconnection()
        {
            if(conn.State != System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
