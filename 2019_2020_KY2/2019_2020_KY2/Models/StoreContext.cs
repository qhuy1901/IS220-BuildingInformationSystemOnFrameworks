using _2019_2020_KY2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2019_2020_KY2.Models
{
    public class StoreContext
    {
        public string ConnectionString { get; set; }//biết thành viên 

        public StoreContext(string connectionString) //phuong thuc khoi tao
        {
            this.ConnectionString = connectionString;
        }

        public StoreContext()
        {

        }

        private MySqlConnection GetConnection() //lấy connection 
        {
            return new MySqlConnection(ConnectionString);
        }
        public void themdcl(DiemCachLy dcl)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "INSERT INTO DiemCachLy VALUES(@MaDiemCachLy, @TenDiemCachLy, @DiaChi)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaDiemCachLy", dcl.MaDiemCachLy);
                cmd.Parameters.AddWithValue("TenDiemCachLy", dcl.TenDiemCachLy);
                cmd.Parameters.AddWithValue("DiaChi", dcl.DiaChi);
                cmd.ExecuteNonQuery();
            }
        }
        public List<object> lietke(int SoTrieuChung)
        {
            List<object> ListCN = new List<object>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT C.MaCongNhan, TenCongNhan, NamSinh, NuocVe, COUNT(*) FROM CONGNHAN C JOIN CN_TC ON C.MaCongNhan = CN_TC.MaCongNhan GROUP BY C.MaCongNhan, TenCongNhan, NamSinh, NuocVe HAVING COUNT(*) >= @STC";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("STC", SoTrieuChung);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())

                    {
                        var obj = new
                        {
                            MaCongNhan = reader[0].ToString(),
                            TenCongNhan = reader[1].ToString(),
                            NamSinh = Convert.ToInt32(reader[2]),
                            NuocVe = reader[3].ToString(),
                            SoTC = Convert.ToInt32(reader[4])
                        };
                        ListCN.Add(obj);
                    }
                }
            }
            return ListCN;
        }

        public List<DiemCachLy>getAllDiemCachLy()
        {
            List<DiemCachLy> list = new List<DiemCachLy>();
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT * FROM DiemCachLy";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using(var reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        DiemCachLy dcl = new DiemCachLy()
                        {
                            MaDiemCachLy = reader[0].ToString(),
                            TenDiemCachLy = reader[1].ToString(),

                        };
                        list.Add(dcl);
                    }    
                }    
            }
            return list;
        }

        public List<CongNhan> getCN(string MaDiemCachLy)
        {
            List<CongNhan> list = new List<CongNhan>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT * FROM CONGNHAN WHERE MaDiemCachLy = @dcl";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("dcl", MaDiemCachLy);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CongNhan cn = new CongNhan()
                        {
                            MaCongNhan = reader[0].ToString(),
                            TenCongNhan = reader[1].ToString(),
                        };
                        list.Add(cn);
                    }
                }
                return list;
            }
        }
        public void delete_congnhan(string MaCongNhan)
        {
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "DELETE FROM CN_TC WHERE MaCongNhan = @macn";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("macn", MaCongNhan);
                cmd.ExecuteNonQuery();

                var str2 = "DELETE FROM CongNhan WHERE MaCongNhan = @macn";
                cmd = new MySqlCommand(str2, conn);
                cmd.Parameters.AddWithValue("macn", MaCongNhan);
                cmd.ExecuteNonQuery();
            }
        }
        public CongNhan getCNInfo(string MaCongNhan)
        {
            CongNhan cn = new CongNhan();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT* FROM CONGNHAN WHERE MaCongNhan = @macn";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("macn", MaCongNhan);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cn.MaCongNhan = reader[0].ToString();
                        cn.TenCongNhan = reader[1].ToString();
                        cn.GioiTinh = (Boolean)reader[2];
                        cn.NamSinh = Convert.ToInt32(reader[3]);
                        cn.NuocVe = reader[4].ToString();
                    }
                }
            }
            return cn;
        }

    }
}
