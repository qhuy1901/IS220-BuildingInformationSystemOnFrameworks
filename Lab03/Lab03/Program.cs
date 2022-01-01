using MySql.Data.MySqlClient;
using System;
using System.Text;

namespace Lab03
{
    class Program
    {
        // Cập nhật giá tăng 5% đối với những sản phẩm do “Thai Lan” sản xuất (cho quan hệ SANPHAM)
        static void Cau1(MySqlConnection conn)
        {
            var sql = "Update SANPHAM SET GIA = 1.05 * GIA where NUOCSX='Thai Lan'";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        // Cập nhật giá giảm 5% đối với những sản phẩm do “Trung Quoc” sản xuất có giá từ 10.000 trở xuống (cho quan hệ SANPHAM).
        static void Cau2(MySqlConnection conn)
        {
            var sql = "Update SANPHAM SET GIA = 0.95 * GIA where NUOCSX='Trung Quoc' AND GIA < 10000";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        // In ra danh sách các sản phẩm (MASP,TENSP) do “Trung Quoc” sản xuất
        static void Cau3(MySqlConnection conn)
        {
            string sql = "SELECT MASP, TENSP FROM SANPHAM where NUOCSX='Trung Quoc'";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}"); 

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        // In ra danh sách các sản phẩm (MASP, TENSP) có đơn vị tính là “cay”, ”quyen”
        static void Cau4(MySqlConnection conn)
        {
            string sql = "SELECT MASP, TENSP FROM SANPHAM where DVT='cay' OR DVT='quyen'";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        // In ra danh sách các sản phẩm (MASP,TENSP) có mã sản phẩm bắt đầu là “B” và kết thúc là “01”
        static void Cau5(MySqlConnection conn)
        {
            string sql = "SELECT MASP, TENSP FROM SANPHAM where MASP LIKE 'B%01'";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }
        // In ra danh sách các sản phẩm (MASP,TENSP) do “Trung Quốc” sản xuất có giá từ 30.000 đến 40.000.
        static void Cau6(MySqlConnection conn)
        {
            string sql = "SELECT MASP, TENSP FROM SANPHAM where NUOCSX='Trung Quoc' AND (GIA BETWEEN 30000 AND 40000)";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        // In ra danh sách các sản phẩm (MASP,TENSP) do “Trung Quoc” hoặc “Thai Lan” sản xuất có giá từ 30.000 đến 40.000.
        static void Cau7(MySqlConnection conn)
        {
            string sql = "SELECT MASP, TENSP FROM SANPHAM where (NUOCSX = 'TRUNG QUOC' OR NUOCSX = 'THAILAN') AND (GIA BETWEEN 30000 AND 40000)";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        // In ra các số hóa đơn, trị giá hóa đơn bán ra trong ngày 1/1/2007 và ngày 2/1/2007.
        static void Cau8(MySqlConnection conn)
        {
            string sql = "SELECT SOHD, TRIGIA FROM HOADON WHERE NGHD = '2007-1-1' OR NGHD = '2007-1-2'";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        // In ra các số hóa đơn, trị giá hóa đơn trong tháng 1/2007, sắp xếp theo ngày (tăng dần) và trị giá của hóa đơn(giảm dần).
        static void Cau9(MySqlConnection conn)
        {
            string sql = "SELECT SOHD, TRIGIA FROM HOADON WHERE (MONTH(NGHD)=1 AND YEAR(NGHD) = 2007) ORDER BY NGHD ASC, TRIGIA DESC";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        // In ra danh sách các khách hàng (MAKH, HOTEN) đã mua hàng trong ngày 1/1/2007
        static void Cau10(MySqlConnection conn)
        {
            string sql = "SELECT KH.MAKH, HOTEN FROM HOADON HD, KHACHHANG KH WHERE KH.MAKH = HD.MAKH AND NGHD = '2007-1-1'";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        // In ra số hóa đơn, trị giá các hóa đơn do nhân viên có tên “Nguyen Van B” lập trong ngày 28/10/2006
        static void Cau11(MySqlConnection conn)
        {
            string sql = "SELECT HD.SOHD, TRIGIA FROM HOADON HD, NHANVIEN NV WHERE HD.MANV = NV.MANV AND NGHD = '2006-10-28' AND NV.HOTEN = 'Nguyen Van B'";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }
        static void Cau12(MySqlConnection conn)
        {
            string sql = "SELECT SP.MASP, TENSP FROM HOADON HD, KHACHHANG KH, SANPHAM SP, CTHD WHERE (MONTH(NGHD) = 10 AND YEAR(NGHD) = 2006) AND KH.HOTEN = 'Nguyen Van A' AND HD.MAKH = KH.MAKH AND CTHD.MASP = SP.MASP AND HD.SOHD = CTHD.SOHD";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        static void Cau14(MySqlConnection conn)
        {
            string sql = "SELECT DISTINCT SOHD FROM CTHD WHERE (CTHD.MASP='BB02' OR CTHD.MASP='BB01') AND (SL BETWEEN 10 AND 20)";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}");
                }
            }
        }

        static void Cau15(MySqlConnection conn) // Câu này trong github làm sai
        {
            string sql = "SELECT SOHD " +
                "FROM cthd " +
                "WHERE MASP = 'BB01' " +
                "AND SOHD in (SELECT SOHD FROM cthd WHERE MASP = 'BB02' AND SL BETWEEN 10 AND 20) " +
                "AND SL BETWEEN 10 AND 20";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}");
                }
            }
        }


        static void Cau13(MySqlConnection conn)
        {
            string sql = "SELECT DISTINCT CTHD.SOHD FROM CTHD, SANPHAM SP, HOADON HD WHERE SP.MASP = CTHD.MASP AND HD.SOHD = CTHD.SOHD AND (SP.MASP = 'BB01'OR SP.MASP = 'BB02')";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}");
                }
            }
        }

        static void Cau16(MySqlConnection conn)
        {
            string sql = "SELECT DISTINCT SP.MASP, TENSP FROM (SANPHAM SP INNER JOIN CTHD ON SP.MASP = CTHD.MASP) INNER JOIN HOADON HD ON HD.SOHD = CTHD.SOHD WHERE NGHD='2007-1-1' UNION SELECT MASP, TENSP FROM SANPHAM WHERE NUOCSX = 'TRUNG QUOC';";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        static void Cau17(MySqlConnection conn)
        {
            string sql = "SELECT MASP, TENSP FROM SANPHAM EXCEPT SELECT CTHD.MASP, TENSP FROM CTHD, SANPHAM SP WHERE CTHD.MASP = SP.MASP;";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        static void Cau18(MySqlConnection conn)
        {
            string sql = "SELECT MASP, TENSP FROM SANPHAM EXCEPT SELECT CTHD.MASP, TENSP FROM SANPHAM SP, CTHD, HOADON HD WHERE CTHD.MASP = SP.MASP AND CTHD.SOHD = HD.SOHD AND YEAR(NGHD) = 2006;";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        static void Cau19(MySqlConnection conn)
        {
            string sql = "SELECT MASP, TENSP FROM SANPHAM WHERE NUOCSX = 'TRUNGQUOC' AND MASP NOT IN( SELECT CTHD.MASP FROM CTHD, HOADON HD WHERE YEAR(NGHD) = 2006 AND CTHD.SOHD = HD.SOHD );";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        static void Cau20(MySqlConnection conn)
        {
            string sql = "SELECT SOHD FROM HOADON HD WHERE NOT EXISTS( SELECT* FROM SANPHAM SP WHERE NUOCSX = 'SINGAPORE' AND NOT EXISTS( SELECT* FROM CTHD WHERE CTHD.MASP = SP.MASP AND CTHD.SOHD = HD.SOHD));";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}");
                }
            }
        }

        static void Cau22(MySqlConnection conn)
        {
            string sql = "SELECT COUNT(*) FROM HOADON WHERE MAKH IS NULL;";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}");
                }
            }
        }

        
        static void Cau23(MySqlConnection conn)
        {
            string sql = "SELECT COUNT(DISTINCT MASP) FROM HOADON HD JOIN CTHD ON HD.SOHD = CTHD.SOHD WHERE YEAR(NGHD) = 2006;";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}");
                }
            }
        }

        static void Cau24(MySqlConnection conn)
        {
            string sql = "SELECT MAX(TRIGIA), MIN(TRIGIA) FROM HOADON;";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        static void Cau25(MySqlConnection conn)
        {
            string sql = "SELECT AVG(TRIGIA) FROM HOADON WHERE YEAR(NGHD) = 2006";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        static void Cau26(MySqlConnection conn)
        {
            string sql = "SELECT SUM(TRIGIA) DoanhThu FROM HOADON WHERE YEAR(NGHD) = 2006";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        static void Cau28(MySqlConnection conn)
        {
            string sql = "SELECT HOTEN, TRIGIA FROM HOADON JOIN KHACHHANG ON HOADON.MAKH = KHACHHANG.MAKH WHERE YEAR(NGHD) = 2006 AND TRIGIA = (SELECT MAX(TRIGIA) FROM HOADON WHERE YEAR(NGHD) =2006);";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        static void Cau29(MySqlConnection conn)
        {
            string sql = "SELECT MAKH, HOTEN FROM KHACHHANG ORDER BY DOANHSO DESC LIMIT 3;";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        static void Cau30(MySqlConnection conn)
        {
            string sql = "SELECT MASP, TENSP FROM SANPHAM WHERE GIA IN( SELECT * FROM (SELECT DISTINCT GIA FROM SANPHAM ORDER BY GIA DESC LIMIT 3)as t1);";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        static void Cau35(MySqlConnection conn)
        {
            string sql = "SELECT NUOCSX ,COUNT(MASP) FROM SANPHAM GROUP BY NUOCSX;";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        static void Cau37(MySqlConnection conn)
        {
            string sql = "SELECT NGHD, SUM(TRIGIA) FROM HOADON GROUP BY NGHD;";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        static void Cau38(MySqlConnection conn)
        {
            string sql = "SELECT MASP, SUM(SL) FROM CTHD INNER JOIN HOADON ON HOADON.SOHD = CTHD.SOHD WHERE (MONTH(NGHD)=10 AND YEAR(NGHD)=2006) GROUP BY MASP;";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        static void Cau40(MySqlConnection conn)
        {
            string sql = "SELECT SOHD, COUNT(DISTINCT MASP) FROM CTHD GROUP BY SOHD HAVING COUNT(DISTINCT MASP) >= 4;";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        static void Cau41(MySqlConnection conn)
        {
            string sql = "SELECT SOHD, COUNT(DISTINCT SP.MASP) FROM CTHD JOIN SANPHAM SP ON SP.MASP = CTHD.MASP WHERE NUOCSX = 'VIETNAM' GROUP BY SOHD HAVING COUNT(DISTINCT SP.MASP) = 3;";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }

        static void Cau42(MySqlConnection conn)
        {
            string sql = "SELECT KH.MAKH, HOTEN, COUNT(SOHD) FROM HOADON HD JOIN KHACHHANG KH ON HD.MAKH = KH.MAKH GROUP BY KH.MAKH, HOTEN HAVING COUNT(SOHD) >= ALL( SELECT DISTINCT COUNT(SOHD) AS HOADONKH FROM HOADON HD JOIN KHACHHANG KH ON HD.MAKH = KH.MAKH GROUP BY HOTEN);";
            using var cmd = new MySqlCommand(sql, conn);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Console.WriteLine($"{rdr.GetName(0)}\t{rdr.GetName(1)}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)}\t{rdr.GetString(1)}");
                }
            }
        }


        static void Main(string[] args)
        {

            MySqlConnection conn = ConnectData.GetConnection();
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Openning Connection ...");
                conn.Open();
                Console.Write("Chọn bài tập: ");
                int select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Cau1(conn);
                        break;
                    case 2:
                        Cau2(conn);
                        break;
                    case 3:
                        Cau3(conn);
                        break;
                    case 4:
                        Cau4(conn);
                        break;
                    case 5:
                        Cau5(conn);
                        break;
                    case 6:
                        Cau6(conn);
                        break;
                    case 7:
                        Cau7(conn);
                        break;
                    case 8:
                        Cau8(conn);
                        break;
                    case 9:
                        Cau9(conn);
                        break;
                    case 10:
                        Cau10(conn);
                        break;
                    case 11:
                        Cau11(conn);
                        break;
                    case 12:
                        Cau11(conn);
                        break;
                    case 14:
                        Cau14(conn);
                        break;
                    case 13:
                        Cau13(conn);
                        break;
                    case 15:
                        Cau15(conn);
                        break;
                    case 16:
                        Cau16(conn);
                        break;
                    case 17:
                        Cau17(conn);
                        break;
                    case 18:
                        Cau18(conn);
                        break;
                    case 19:
                        Cau19(conn);
                        break;
                    case 20:
                        Cau20(conn);
                        break;
                    case 23:
                        Cau23(conn);
                        break;
                    case 22:
                        Cau22(conn);
                        break;
                    case 24:
                        Cau24(conn);
                        break;
                    case 25:
                        Cau25(conn);
                        break;
                    case 28:
                        Cau28(conn);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }
    }
}
