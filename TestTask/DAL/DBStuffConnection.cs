using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.DAL
{
    internal class DBStuffConnection
    {
      //  static string connectionString = ConfigurationManager.ConnectionStrings["TestTask.Properties.Settings.stuffConnectionString"].ConnectionString;
     //   SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=stuff; Integrated Security=true");
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-HNH9CST;Initial Catalog=stuff;Integrated Security=True");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
