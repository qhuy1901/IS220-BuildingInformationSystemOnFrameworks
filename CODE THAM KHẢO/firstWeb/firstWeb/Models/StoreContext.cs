using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace firstWeb.Models
{
    public class StoreContext
    {
        public string ConnectionString { get; set; }//biết thành viên 

        public StoreContext(string connectionString) //phuong thuc khoi tao
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection() //lấy connection 
        {
            return new MySqlConnection(ConnectionString);
        }
        //lấy danh sách các khoa
        public List<Khoa> GetKhoas()
        {
            List<Khoa> list = new List<Khoa>();

            //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from KHOA";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Khoa()
                        {
                            MaKhoa = reader["MaKhoa"].ToString(),
                            TenKhoa = reader["TenKhoa"].ToString(),
                        });
                    }
                    reader.Close(); 
                }
                
                conn.Close();
                
            }
            return list;
        }
        public List<SinhVien> GetSinhViens()
        {
            List<SinhVien> list = new List<SinhVien>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from SINHVIEN";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SinhVien()
                        {
                            MaSinhVien = reader["MaSinhVien"].ToString(),
                            TenSinhVien = reader["TenSinhVien"].ToString(),
                            DiemTrungBinh = Convert.ToInt32(reader["DiemTrungBinh"]),
                            MaBoMon = reader["MaBoMon"].ToString(),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<SinhVien> GetSinhViens(string mbm)
        {
            List<SinhVien> list = new List<SinhVien>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from SINHVIEN where MaBoMon=@mbm";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("mbm", mbm);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SinhVien()
                        {
                            MaSinhVien = reader["MaSinhVien"].ToString(),
                            TenSinhVien = reader["TenSinhVien"].ToString(),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }

        public int InsertKhoa(Khoa kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into KHOA values(@makhoa, @tenkhoa)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("makhoa", kh.MaKhoa);
                cmd.Parameters.AddWithValue("tenkhoa", kh.TenKhoa);

                return (cmd.ExecuteNonQuery());

            }
        }
        public int UpdateKhoa(Khoa kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update KHOA set TenKhoa = @tenkhoa where MaKhoa=@makhoa";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tenkhoa", kh.TenKhoa);
                cmd.Parameters.AddWithValue("makhoa", kh.MaKhoa);
                return (cmd.ExecuteNonQuery());
            }
        }
        
        public int XoaKhoa(string Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from KHOA where MaKhoa=@makhoa";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("makhoa", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int XoaSinhVien(string Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from SINHVIEN where MaSinhVien=@maSinhVien";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("maSinhVien", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int InsertBoMon(BoMon bm)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into BOMON values(@mabomon, @tenbomon,@makhoa)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("mabomon", bm.MaBoMon);
                cmd.Parameters.AddWithValue("tenbomon", bm.TenBoMon);
                cmd.Parameters.AddWithValue("makhoa", bm.MaKhoa);
                return (cmd.ExecuteNonQuery());

            }
        }
        public Khoa ViewKhoa(string Id)
        {
            //Khoa kh = new Khoa("MK01","HTTT");
            Khoa kh = new Khoa();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from KHOA where MaKhoa=@makhoa";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("makhoa", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    kh.MaKhoa=reader["MaKhoa"].ToString();
                    kh.TenKhoa = reader["TenKhoa"].ToString();
                }
            }
            return (kh);
        }

        public int TimSinhVienTheoTen(string ten)
        {
            int i = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from SINHVIEN where TenSinhVien=@tensinhvien";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tensinhvien", ten);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        i++;
                    }
                }
            }
            return i;
        }
        //liệt kê n sinh viên
        public List<SinhVien> LietKeNSinhVien(int n) {

            List<SinhVien> list = new List<SinhVien>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from SINHVIEN limit @sosinhvien";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("sosinhvien", n); 
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SinhVien()
                        {
                            MaSinhVien = reader["MaSinhVien"].ToString(),
                            TenSinhVien = reader["TenSinhVien"].ToString(),
                            DiemTrungBinh = Convert.ToDouble(reader["DiemTrungBinh"]),
                            MaBoMon = reader["MaBoMon"].ToString(),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<SinhVien> SinhVienMax(){
            List<SinhVien> list = new List<SinhVien>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from SINHVIEN where DiemTrungBinh = (Select Max(DiemTrungBinh) from SINHVIEN)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SinhVien()
                        {
                            MaSinhVien = reader["MaSinhVien"].ToString(),
                            TenSinhVien = reader["TenSinhVien"].ToString(),
                            DiemTrungBinh = Convert.ToDouble(reader["DiemTrungBinh"]),
                            //MaBoMon = reader["MaBoMon"].ToString(),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<BoMon> GetBoMons()
        {
            List<BoMon> list = new List<BoMon>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from BOMON";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new BoMon()
                        {
                            MaBoMon = reader["MaBoMon"].ToString(),
                            TenBoMon = reader["TenBoMon"].ToString(),
                            
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        //Số sinh viên trong bộ môn
        public List<object> SoSinhVienTrongBoMon()
        {
            List<object> list = new List<object>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string str = "select b.TenBoMon, count(*) as SL from BOMON b,SINHVIEN s where b .MaBoMon = s .MaBoMon group by s.MaBoMon";

                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ob = new {tenbomon= reader["TenBoMon"].ToString(), soluong= Convert.ToInt32(reader["SL"]) };
                        list.Add(ob); 
                   
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;

        }
        
        /*
        public IDictionary<string,int> SoSinhVienTrongBoMon()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string str = "select b.TenBoMon, count(*) as SL from BOMON b,SINHVIEN s where b .MaBoMon = s .MaBoMon group by s.MaBoMon";

                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dict.Add(reader["TenBoMon"].ToString(), Convert.ToInt32(reader["SL"]));

                    }
                    reader.Close();
                }

                conn.Close();

            }
            return dict;

        }*/ 
        public StoreContext()
        {
        }
    }
}
