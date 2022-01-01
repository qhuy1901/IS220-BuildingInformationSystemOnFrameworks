using System;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace MyConnection
{
    class Program
    {
        public static void SelectAlbum(MySqlConnection conn)
        {
            string sql = "Select * from Album";

            // Tạo một đối tượng Command.
            MySqlCommand cmd = new MySqlCommand();

            // Liên hợp Command với Connection.
            cmd.Connection = conn;
            cmd.CommandText = sql;

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        // Chỉ số (index) của cột id trong câu lệnh SQL.
                        Console.WriteLine("Id \tName \t ArtistName\t Price\t Genre");
                        int indexid = reader.GetOrdinal("id"); // 0
                        int id = Convert.ToInt32(reader.GetValue(indexid));
                        Console.Write(id+ "\t");


                        int IndexName = reader.GetOrdinal("Name");
                        String Name = reader.GetString(IndexName);
                        Console.Write(Name + "\t");

                        int IndexArtist = reader.GetOrdinal("ArtistName");
                        String ArtistName = reader.GetString(IndexArtist);
                        Console.Write(ArtistName+ "\t");

                        int indexPrice = reader.GetOrdinal("Price"); // 0
                        int Price = Convert.ToInt32(reader.GetValue(indexPrice));
                        Console.Write(Price + "\t");

                        int IndexGenre = reader.GetOrdinal("Genre");
                        String Genre = reader.GetString(IndexGenre);
                        Console.WriteLine(Genre);

                    }
                }
            }
        }
        public static void LietkeCaSi(MySqlConnection conn)
        {
            string sql = "Select * from casi";

            // Tạo một đối tượng Command.
            MySqlCommand cmd = new MySqlCommand();

            // Liên hợp Command với Connection.
            cmd.Connection = conn;
            cmd.CommandText = sql;

            using (DbDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.SingleRow))
            {
                if (reader.HasRows)
                {
                    Console.WriteLine("Mã ca si \tTên ca si \t Ngay sinh");
                    while (reader.Read())
                    {
                        int indexid = reader.GetOrdinal("MaCaSi"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("TenCaSi"); // 1
                        string name = reader.GetString(indexname);
                        Console.Write(name + "\t");
                        string birthday = Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy");
                        Console.Write(birthday + "\n");
                    }
                }
            }
        }
        public static void QuerySelect(MySqlConnection conn)
        {
            //string sql = "SELECT * FROM casi";
            string sql = "SELECT * FROM casi where MaCaSi =@macs";//truy xuat co dieu kien

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("macs","CS01");
            using MySqlDataReader rdr = cmd.ExecuteReader();
           
            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}"); //lấy tên field

                while (rdr.Read())
                {
                    //Console.WriteLine($"{rdr.GetInt16(0)}\t{rdr.GetString(1)}");
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");

                }
            }
        }
        //ket 2 bang du lieu
        public static void DanhSachCaSi(MySqlConnection conn)
        {
            /*string sql = "SELECT c.MaCaSi, TenCaSi FROM album a, casi c where MaAlBum=@maab and a.MaCaSi=c.MaCaSi and  year(NgaySinh)=@ngaysinh";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("maab","AB01");
            cmd.Parameters.AddWithValue("ngaysinh", "2020-11-27");
            */

            string sql = "SELECT c.MaCaSi, TenCaSi FROM casi c where year(NgaySinh)=@ngaysinh";
            using var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("ngaysinh", "2021");


            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}"); //lấy tên field

                while (rdr.Read())
                {
                    //Console.WriteLine($"{rdr.GetInt16(0)}\t{rdr.GetString(1)}");
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");

                }
            }
        }

        //đếm số dòng = dem so ca si
        public static int CountRow(MySqlConnection conn)
        {
            string sql = "SELECT count(*) FROM casi";
            using var cmd = new MySqlCommand(sql, conn);
            int n = int.Parse(cmd.ExecuteScalar()+"");
            return n; 
        }

        public static void CreateTable(MySqlConnection conn) {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn; 
            cmd.CommandText = "Drop table if exists casi";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE casi(id INTEGER PRIMARY KEY AUTO_INCREMENT,
                    name TEXT)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO casi(name) VALUES('Nguyễn Phi Hùng')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO casi(name) VALUES('Lam Trường')";
            cmd.ExecuteNonQuery();

        }
        public static void PreparedStatements(MySqlConnection conn)
        {
            var sql = "INSERT INTO casi(MaCaSi,TenCaSi) VALUES(@macs,@tencs)";

            using var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@macs", "CS008");
            cmd.Parameters.AddWithValue("@tencs", "Hiền Thục");

            //cmd.Prepare();//cos không có cũng được

            cmd.ExecuteNonQuery();
        }
        public static void ThemCaSi(MySqlConnection conn)
        {
            var sql = "INSERT INTO casi VALUES (N'CS10',N'Nam Em',N'2021-10-13')";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public static void UpdateCaSi(MySqlConnection conn)
        {
            var sql = "Update casi SET TenCaSi='Nam Anh' where MaCasi='CS10'";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public static void InsertCaSi(MySqlConnection conn)
        {
            var sql = "INSERT INTO casi VALUES (@macs,@tencs,@namsinh)";
            using var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@macs", "CS12");
            cmd.Parameters.AddWithValue("@tencs", "Sơn Tùng");
            cmd.Parameters.AddWithValue("@namsinh", "2000-12-21");
            /*var paraName = new MySqlParameter("Name", name);
            cmd.Parameters.Add(paraName);
            cmd.Prepare();
            */

            cmd.ExecuteNonQuery();
        }


        static void Main(string[] args)
        {

            MySqlConnection conn = ConnectData.GetConnection();
            //try
            //{
            //    Console.WriteLine("Openning Connection ...");
            //    conn.Open();
            //    InsertCaSi(conn);

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error: " + e.Message);
            //}
            /*try
            {
                Console.WriteLine("Openning Connection ...");
                conn.Open();
                UpdateCaSi(conn);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }*/
            /*try
            {
                Console.WriteLine("Openning Connection ...");
                conn.Open();
                ThemCaSi(conn);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }*/
            
            try
            {
                Console.WriteLine("Openning Connection ...");
                conn.Open();
                LietkeCaSi(conn);
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            /*
            try
            {
                Console.WriteLine("Openning Connection ...");
                conn.Open();
                //QuerySelect(conn);
                SelectAlbum(conn);
                DanhSachCaSi(conn);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            */
            /* try
             {
                 Console.WriteLine("Openning Connection ...");
                 conn.Open();
                 Console.WriteLine("Connection successful!");
                 CreateTable(conn);
             }
             catch (Exception e)
             {
                 Console.WriteLine("Error: " + e.Message);
             }*/
            /*try
            {
                Console.WriteLine("Openning Connection ...");
                conn.Open();
                Console.WriteLine("Connection successful!");
                PreparedStatements(conn);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }*/

            /*try
            {
                Console.WriteLine("Openning Connection ...");
                conn.Open();
                Console.WriteLine("Connection successful!");
                QuerySelect(conn);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }*/
            /*
            try
            {
                Console.WriteLine("Openning Connection ...");
                conn.Open();
                Console.WriteLine("Connection successful!");
                Console.WriteLine("Số dòng đọc được:"+CountRow(conn));
            }catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            */
            /* try
             {
                 conn.Open();

                 InsertCaSi(conn);

                 Console.WriteLine("Số dòng insert:");
             }
             catch (Exception e)
             {
                 Console.WriteLine("Error: " + e.Message);
             }
             try
             {
                 Console.WriteLine("Openning Connection ...");
                 //conn.Open();
                 Console.WriteLine("Connection successful!");
                 QuerySelect(conn);
             }
             catch (Exception e)
             {
                 Console.WriteLine("Error: " + e.Message);
             }*/
            /*try
            {
                conn.Open();

                //QuerySelect(conn);
                PreparedStatements(conn);

                Console.WriteLine("Số dòng insert:");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }*/

            Console.Read();
        }
    }
}
