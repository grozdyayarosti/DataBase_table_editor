using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace test_DataBase2
{
    class ConnectionDB
    {
        SqlConnection sqlConnection;
        //new SqlConnection("Server = 192.168.0.104, 666; Database=MyDBase;User Id = sa;Password=mssql");
        //new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB2"].ConnectionString);

        private static string strokeConnection;

        public string StrokeConnection 
        {
            get { return strokeConnection ; } 
            set { strokeConnection = value; }
        }
        public ConnectionDB() 
        {
            sqlConnection = new SqlConnection(strokeConnection);
        }

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()

            => sqlConnection;
    }
}
