using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThiThu.Models
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

        public List<BaoDuong> getlistbaoduong(string SoXe)
        {
            List<BaoDuong> list = new List<BaoDuong>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT * FROM BAODUONG WHERE SoXe = @SoXe";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("SoXe", SoXe);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BaoDuong bd = new BaoDuong()
                        {
                            MaBD = reader[0].ToString(),
                            NgayNhan = reader[1].ToString(),
                            NgayTra = reader[2].ToString(),
                            SoKM = reader[3].ToString(),
                            NoiDung = reader[4].ToString()
                        };
                        list.Add(bd);

                    }
                }
            }
            return list;
        }

        public List<object> getctbd(string MaBD)
        {
            List<object> list = new List<object>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT CV.MaCV, TenCV, DonGia, MaBD FROM CT_BD JOIN CONGVIEC CV WHERE CT_BD.MACV = CV.MACV AND MaBD = @MaBD";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaBD", MaBD);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var obj = new
                        {
                            MaCV = reader[0].ToString(),
                            TenCV = reader[1].ToString(),
                            DonGia = Convert.ToInt32(reader[2]),
                            MaBD = reader[3].ToString(),
                        };
                        list.Add(obj);
                    }
                }
            }
            return list;
        }
        public void xoactbd(string MaCV, string MaBD)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "DELETE FROM CT_BD WHERE MaCV = @MaCV AND MaBD = @MaBD";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaCV", MaCV);
                cmd.Parameters.AddWithValue("MaBD", MaBD);
                cmd.ExecuteNonQuery();
            }
        }
        public BaoDuong getbaoduonginfo(string MaBD)
        {
            BaoDuong bd = new BaoDuong();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT* FROM BAODUONG WHERE MABD = @MABD";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MABD", MaBD);
                
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        bd.MaBD = reader[0].ToString();
                        bd.NgayNhan = reader[1].ToString();
                        bd.NgayTra = reader[2].ToString();
                        bd.SoKM = reader[3].ToString();
                        bd.NoiDung = reader[4].ToString();
                    }
                }
            }
            return bd;
        }

        public void suabaoduong(string MaBD, BaoDuong bd)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "UPDATE BAODUONG SET NgayNhan = @NgayNhan, NgayTra = @NgayTra, NoiDung = @NoiDung, SoKM = @SoKM WHERE MaBD = @MaBD";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("NgayNhan", bd.NgayNhan);
                cmd.Parameters.AddWithValue("NgayTra", bd.NgayTra);
                cmd.Parameters.AddWithValue("NoiDung", bd.NoiDung);
                cmd.Parameters.AddWithValue("SoKM", bd.SoKM);
                cmd.Parameters.AddWithValue("MaBD", MaBD);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
