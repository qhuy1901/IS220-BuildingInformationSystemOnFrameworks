using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaQuangHuy_19520113.Models
{
    public class Context
    {
        public string ConnectionString { get; set; }

        public Context(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection() 
        {
            return new MySqlConnection(ConnectionString);
        }

        // Lấy danh sách khách hàng
        public List<KhachHang> GetListKhachHang()
        {
            List<KhachHang> list = new List<KhachHang>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from khachhang";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new KhachHang()
                        {
                            MaKH = reader["MaKH"].ToString(),
                            HoTen = reader["HoTen"].ToString(),
                        });
                        System.Diagnostics.Debug.WriteLine(reader["MaKH"].ToString());
                    }
                    reader.Close();
                }
                conn.Close();

            }
            return list;
        }
        public List<NhanVien> GetListNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from nhanvien";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhanVien()
                        {
                            MaNV = reader["MaNV"].ToString(),
                            HoTen = reader["HoTen"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();

            }
            return list;
        }

        public KhachHang ViewKhachHang(string MaKH)
        {
            
            KhachHang kh = new KhachHang();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from khachhang where MAKH=@makh";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("makh", MaKH);
                System.Diagnostics.Debug.WriteLine(str);
                using (var reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        kh.MaKH = reader["MaKH"].ToString();
                        kh.HoTen = reader["HoTen"].ToString();
                    }    
                }
            }
            return kh;
        }

        public int UpdateKhachHang(KhachHang kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update khachhang set HoTen = @tenKH where MaKH=@maKH";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tenKH", kh.HoTen);
                cmd.Parameters.AddWithValue("maKH", kh.MaKH);
                return (cmd.ExecuteNonQuery());
            }
        }

        public int DeleteKhachHang(string MaKH)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from khachhang where MaKH=@MaKH";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaKH", MaKH);
                return (cmd.ExecuteNonQuery());
            }
        }

        public int InsertKhachHang(KhachHang kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into khachhang (MaKH, HoTen) values(@maKH, @hoTen)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("maKH", kh.MaKH);
                cmd.Parameters.AddWithValue("hoTen", kh.HoTen);
                return (cmd.ExecuteNonQuery());
            }
        }

        public int InsertHoaDon(HoaDon hd)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into hoadon (sohd, makh, trigia) values(@sohd, @makh, @trigia)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("sohd", hd.SoHD);
                cmd.Parameters.AddWithValue("makh", hd.MaKH);
                cmd.Parameters.AddWithValue("trigia", hd.TriGia);
                return (cmd.ExecuteNonQuery());
            }
        }

        

        //Số hóa đơn của khách khách hàng
        public List<object> SoHoaDonKhachHang()
        {
            List<object> list = new List<object>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string str = "select KH.HoTen, count(*) as SoLuongHD from Khachhang KH, HoaDon HD where KH.MaKH = HD.MaKH group by KH.HoTen";

                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ob = new { TenKH= reader["HoTen"].ToString(), SoLuongHD = Convert.ToInt32(reader["SoLuongHD"]) };
                        list.Add(ob);

                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;

        }

        public int InsertSanPham(SanPham sp)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into sanpham values(@masp, @tensp, @dvt, @nuocsx, @gia)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("masp", sp.MaSP);
                cmd.Parameters.AddWithValue("tensp", sp.TenSP);
                cmd.Parameters.AddWithValue("dvt", sp.Dvt);
                cmd.Parameters.AddWithValue("nuocsx", sp.NuocSX);
                cmd.Parameters.AddWithValue("gia", sp.Gia);
                return (cmd.ExecuteNonQuery());
            }
        }

        public List<SanPham> LietKeNSP(int n)
        {

            List<SanPham> list = new List<SanPham>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from sanpham limit @sop";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("sop", n);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SanPham()
                        {
                            MaSP = reader["MaSP"].ToString(),
                            TenSP = reader["TenSP"].ToString(),
                            Dvt = reader["Dvt"].ToString(),
                            NuocSX = reader["NuocSX"].ToString(),
                            Gia = Convert.ToInt32(reader["Gia"].ToString()),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }

        public List<HoaDon> GetListHD(string Manv)
        {
            List<HoaDon> list = new List<HoaDon>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from hoadon where Manv=@manv";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("manv", Manv);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new HoaDon()
                        {
                            SoHD = Convert.ToInt32(reader["SoHD"]),
                            MaKH = reader["MaKH"].ToString(),
                            NgHD = (DateTime)reader["NGHD"],
                            TriGia = Convert.ToInt32(reader["TriGia"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close();

            }
            return list;
        }

        public int DeleteHD(int SoHD)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from cthd where SOHD=@soHD";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("soHD", SoHD);
                cmd.ExecuteNonQuery();

                str = "delete from HOADON where SoHD=@soHD";
                MySqlCommand cmd2 = new MySqlCommand(str, conn);
                cmd2.Parameters.AddWithValue("soHD", SoHD);

                return (cmd2.ExecuteNonQuery());
            }
        }
    }
}
