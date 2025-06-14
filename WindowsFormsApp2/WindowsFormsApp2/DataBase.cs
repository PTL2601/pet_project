using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-JSKGSSU\SQLEXPRESS; Initial Catalog = DataBase; Integrated Security = True");

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
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
