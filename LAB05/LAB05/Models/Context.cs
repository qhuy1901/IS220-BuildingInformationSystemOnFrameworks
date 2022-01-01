using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB05.Models
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
                            SDT = reader["SDT"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();

            }
            return list;
        }

        public List<HopDong> GetListHD(string MaKH)
        {
            List<HopDong> list = new List<HopDong>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from hopdong where MaKH=@makh";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("makh", MaKH);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new HopDong()
                        {
                            MaHD = reader["MaHD"].ToString(),
                            TenHD = reader["TenHD"].ToString(),
                            NgayLap = (DateTime)reader["NgayLap"],
                            TongTien = Convert.ToInt32(reader["TongTien"]),
                        }) ;
                    }
                    reader.Close();
                }
                conn.Close();

            }
            return list;
        }

        public KhachHang GetKhachHangInfo(string MaKH)
        {
            KhachHang kh = new KhachHang();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from khachhang where MaKH=@makh";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("makh", MaKH);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        kh.MaKH = reader["MaKH"].ToString();
                        kh.HoTen = reader["HoTen"].ToString();
                    }
                    reader.Close();
                }
                conn.Close();

            }
            return kh;
        }

        public List<Xe> GetListXe()
        {
            List<Xe> list = new List<Xe>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from xe";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Xe()
                        {
                            MaXe = reader["MaXe"].ToString(),
                            TenXe = reader["TenXe"].ToString(),
                            MauXe = reader["MauXe"].ToString(),
                            SoCho = Convert.ToInt32(reader["SoCho"].ToString()),
                            TenHang = reader["TenHang"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();

            }
            return list;
        }

        public Xe GetXeInfo(string MaXe)
        {
            Xe xe = new Xe();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from xe where MaXe = @maxe";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("maxe", MaXe);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        xe.MaXe = reader["MaXe"].ToString();
                        xe.TenXe = reader["TenXe"].ToString();
                        xe.MauXe = reader["MauXe"].ToString();
                        xe.SoCho = Convert.ToInt32(reader["SoCho"].ToString());
                        xe.TenHang = reader["TenHang"].ToString();
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return xe;
        }

        public int UpdateXe(Xe xe)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update xe set TenXe  = @tenxe, MauXe = @mauxe, SoCho = @socho, TenHang = @tenhang where MaXe=@maxe";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tenxe", xe.TenXe);
                cmd.Parameters.AddWithValue("mauxe", xe.MauXe);
                cmd.Parameters.AddWithValue("socho", xe.SoCho);
                cmd.Parameters.AddWithValue("tenhang", xe.TenHang);
                cmd.Parameters.AddWithValue("maxe", xe.MaXe);
                return (cmd.ExecuteNonQuery());
            }
        }

        public int DeleteXe(string MaXe)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from cthd where MaXe=@MaXe";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaXe", MaXe);
                cmd.ExecuteNonQuery();

                str = "delete from xe where MaXe=@MaXe";
                MySqlCommand cmd2 = new MySqlCommand(str, conn);
                cmd2.Parameters.AddWithValue("MaXe", MaXe);

                return (cmd2.ExecuteNonQuery());
            }
        }

        public int TimKhachHangTheoTen(string ten)
        {
            int i = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from khachhang where HoTen=@Hoten";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("HoTen", ten);
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
        public int InsertKhachHang(KhachHang kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into khachhang (MaKH, HoTen, SDT) values(@maKH, @hoTen, @sdt)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("maKH", kh.MaKH);
                cmd.Parameters.AddWithValue("hoTen", kh.HoTen);
                cmd.Parameters.AddWithValue("sdt", kh.SDT);
                return (cmd.ExecuteNonQuery());
            }
        }
    }
}
