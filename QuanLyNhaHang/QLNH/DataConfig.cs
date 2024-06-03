using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLNH
{
    public class DataConfig
    {
        private string conn = "Data Source=.;Initial Catalog=QLNH;User ID=sa;Password=123456;Encrypt=False";
        private SqlConnection connection;

        public DataConfig()
        {
            connection = new SqlConnection(conn);
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }

        public DataTable ExecuteQuery(string query)
        {
            //connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();

            return data;
        }
    }
}
