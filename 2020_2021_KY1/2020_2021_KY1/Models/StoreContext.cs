using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2020_2021_KY1.Models
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
        public void InsertCanHo(CanHo ch)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into CANHO values(@macanho, @tenchuho)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("macanho", ch.MaCanHo);
                cmd.Parameters.AddWithValue("tenchuho", ch.TenChuHo);
                cmd.ExecuteNonQuery();
            }
        }

        public List<object> GetNhanVienTheoSoLanSua(int SoLanSua)
        {
            List<object> list = new List<object>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = @"select TENNHANVIEN, SODIENTHOAI, COUNT(*) 
                            from NV_BT JOIN NHANVIEN NV ON NV_BT.MANHANVIEN = NV.MANHANVIEN 
                            GROUP BY TENNHANVIEN, SODIENTHOAI
                            HAVING COUNT(*) >= @solansua";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("solansua", SoLanSua);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var obj = new { 
                            TenNhanVien = reader[0].ToString(), 
                            SoDienThoai = reader[1].ToString(),
                            SoLanSua = Convert.ToInt32(reader[2])
                        };
                        list.Add(obj);
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }

        public List<NhanVien> GetAllNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from NHANVIEN";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NhanVien nv = new NhanVien
                        {
                            MaNhanVien = reader["MaNhanVien"].ToString(),
                            TenNhanVien = reader["TenNhanVien"].ToString(),
                            SoDienThoai = reader["SoDienThoai"].ToString(),
                            GioiTinh = Convert.ToInt32(reader["GioiTinh"])
                        };
                        list.Add(nv);
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }

        public List<NV_BT> GetThietBiTheoNhanVien(string MaNhanVien)
        {
            List<NV_BT> list = new List<NV_BT>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = @"select * FROM NV_BT WHERE MANHANVIEN = @manhanvien";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("manhanvien", MaNhanVien);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NV_BT obj = new NV_BT
                        {
                            MaThietBi = reader["MaThietBi"].ToString(),
                            MaCanHo = reader["MaCanHo"].ToString(),
                            LanThu = Convert.ToInt32(reader["LanThu"]),
                            NgayBaoTri = (DateTime)reader["NgayBaoTri"]
                        };
                        list.Add(obj);
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public NV_BT GetBaoTri(string MaNhanVien, string MaThietBi, string MaCanHo, int LanThu)
        {
            NV_BT bt = new NV_BT();
            using (MySqlConnection conn = GetConnection())
            {
                //System.Diagnostics.Debug.WriteLine(MaNhanVien + " " + MaThietBi + " " + MaCanHo + " " + LanThu);
                conn.Open();
                string str = @"select * FROM NV_BT where MaNhanVien=@manhanvien AND MaThietBi=@mathietbi AND MaCanHo=@macanho AND LanThu=@lanthu";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("manhanvien", MaNhanVien);
                cmd.Parameters.AddWithValue("mathietbi", MaThietBi);
                cmd.Parameters.AddWithValue("macanho", MaCanHo);
                cmd.Parameters.AddWithValue("lanthu", LanThu);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        bt.MaNhanVien = reader["MaNhanVien"].ToString();
                        bt.MaCanHo = reader["MaCanHo"].ToString();
                        bt.MaThietBi = reader["MaThietBi"].ToString();
                        bt.LanThu = Convert.ToInt32(reader["LanThu"]);
                        bt.NgayBaoTri = (DateTime)reader["NgayBaoTri"];
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return bt;
        }
        public int XoaBaoTri(string MaNhanVien, string MaThietBi, string MaCanHo, int LanThu)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from NV_BT where MaNhanVien=@manhanvien AND MaThietBi=@mathietbi AND MaCanHo=@macanho AND LanThu=@lanthu";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("manhanvien", MaNhanVien);
                cmd.Parameters.AddWithValue("mathietbi", MaThietBi);
                cmd.Parameters.AddWithValue("macanho", MaCanHo);
                cmd.Parameters.AddWithValue("lanthu", LanThu);
                return (cmd.ExecuteNonQuery());
            }
        }

        public void UpdateBaoTri(NV_BT bt, string MaNhanVien, string MaThietBi, string MaCanHo, int LanThu)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = @"update nv_bt
                            set MaThietBi=@updatemathietbi, MaCanHo=@updatemacanho, LanThu=@updatelanthu, NgayBaoTri=@updatengaybaotri
                            where MaNhanVien=@manhanvien AND MaThietBi=@mathietbi AND MaCanHo=@macanho AND LanThu=@lanthu";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("manhanvien", MaNhanVien);
                cmd.Parameters.AddWithValue("mathietbi", MaThietBi);
                cmd.Parameters.AddWithValue("macanho", MaCanHo);
                cmd.Parameters.AddWithValue("lanthu", LanThu);
                cmd.Parameters.AddWithValue("updatemathietbi", bt.MaThietBi);
                cmd.Parameters.AddWithValue("updatemacanho", bt.MaCanHo);
                cmd.Parameters.AddWithValue("updatelanthu", bt.LanThu);
                cmd.Parameters.AddWithValue("updatengaybaotri", bt.NgayBaoTri);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
