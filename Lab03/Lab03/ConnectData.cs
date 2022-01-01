using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class ConnectData
    {
        public static MySqlConnection GetConnection()
        {
            string host = "localhost";
            int port = 3307;
            string database = "quanlybanhang";
            string username = "root";
            string password = "";


            String connString = "Server=" + host + ";Database=" + database
                    + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);
            /*
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connString; 
            */

            return conn;
        }
    }
}
