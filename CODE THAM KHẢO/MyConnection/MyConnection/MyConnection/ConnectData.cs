using System;
using MySql.Data.MySqlClient;

namespace MyConnection
{   
    public class ConnectData
    {
        public static MySqlConnection GetConnection()
        {
            string host = "localhost";
            int port = 3307;
            string database = "testcsharp";
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
