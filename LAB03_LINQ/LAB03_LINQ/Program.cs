using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text;

namespace LAB03_LINQ
{
    class Program
    {
        // Thêm sản phẩm
        public static void ThemSP()
        {
            using (var context = new Context())
            {
                Console.WriteLine("Đã lưu sản phẩm");
                context.SanPham.Add(new SanPham()
                {
                    MaSP = "SP01",
                    TenSP = "iPhone 13 Pro Max",
                    NuocSX = "Viet Nam",
                    Dvt = "hop",
                    Gia = 1000000
                });
                // Thực hiện Insert vào DB các dữ liệu đã thêm.
                int rows = context.SaveChanges();
                Console.WriteLine($"Đã lưu {rows} sản phẩm");
            }
        }

        // Xóa sản phẩm
        public static void XoaSP()
        {
            using (var context = new Context())
            {
                var product = (from p in context.SanPham
                               where (p.MaSP == "SP01")
                               select p
                                 )
                                .FirstOrDefault(); 

                if (product != null)
                {
                    context.Remove(product);
                    Console.WriteLine($"Xóa sản phẩm có MaSP = {product.MaSP}");
                    context.SaveChanges();
                }
            }
        }

        // 1. Cập nhật giá tăng 5% đối với những sản phẩm do “Thai Lan” sản xuất có giá từ 50.000 trở xuống (cho quan hệ SANPHAM)
        static void Cau1()
        {
            using (var context = new Context())
            {
                //var products = context.SanPham
                //               .Where(p => p.NuocSX == "Thai Lan" && p.Gia < 50000).ToList();
                var products = from p in context.SanPham
                               where p.NuocSX == "Thai Lan" && p.Gia < 50000
                               select p;

                foreach (var product in products)
                {
                    product.Gia = (int)(product.Gia * 1.05);
                }
                context.SaveChanges();
            }
        }

        // 3. In ra danh sách các sản phẩm (MASP,TENSP) do “Trung Quoc” sản xuất.
        static void Cau3()
        {
            using (var context = new Context())
            {
                // Lấy List các sản phẩm từ DB
                // ok var products = context.SanPham.Where(p => p.NuocSX == "Trung Quoc").ToList();
                var products = from p in context.SanPham
                               where p.NuocSX == "Thai Lan"
                               select p;

                Console.WriteLine("Tất cả sản phẩm");
                foreach (var product in products)
                {
                    Console.WriteLine($"{product.MaSP} - {product.TenSP} - {product.NuocSX} - {product.Gia}");
                }
                Console.WriteLine();
            }
        }

        // 9. In ra các số hóa đơn, trị giá hóa đơn trong tháng 1/2007, sắp xếp theo ngày (tăng dần) và trị giá của hóa đơn(giảm dần).
        static void Cau9()
        {
            using (var context = new Context())
            {
                //var listhoadon = from hd in context.HoaDon
                //             //join ct in context.CTHD on hd.SoHD equals ct.SoHD
                //             where hd.NgHD.Year == 2007 && hd.NgHD.Month == 1
                //             orderby hd.NgHD ascending, hd.TriGia descending
                //             select new
                //             {
                //                 SoHD = hd.SoHD,
                //                 NgayHD = hd.NgHD,
                //                 TriGia = hd.TriGia
                //             };
                var listhoadon = context.HoaDon
                    .Where(hd => hd.NgHD.Year == 2007 && hd.NgHD.Month == 1)
                    .OrderBy(hd => hd.NgHD)
                    .ThenByDescending(hd => hd.TriGia)
                    .Select(hd => new { hd.SoHD, NgayHD = hd.NgHD, hd.TriGia}).ToList();

                foreach (var hoadon in listhoadon)
                {
                    Console.WriteLine($"{hoadon.SoHD} - {hoadon.NgayHD} - {hoadon.TriGia}");
                }
                Console.WriteLine();
            }
        }

        // Cho biết trị giá hóa đơn cao nhất của mỗi khách hàng
        static void HDCaoNhatMoiKH()
        {
            using (var context = new Context())
            {
                var listhoadon = context.HoaDon.ToList()
                    .GroupBy(kh => kh.MaKH)
                    .Select(std => new
                    {
                        MaKH = std.Key,
                        HoaDon = std.OrderByDescending(hd => hd.TriGia).FirstOrDefault()
                    }) ;

                foreach (var namegroup in listhoadon)
                {
                    Console.WriteLine(namegroup.MaKH);
                    //foreach(var obj in namegroup.HoaDon)
                    //{
                    //    Console.WriteLine($"{obj.SoHD} - {obj.NgHD} - {obj.TriGia}");
                    //}    
                    Console.WriteLine($"{namegroup.HoaDon.SoHD} - {namegroup.HoaDon.NgHD} - {namegroup.HoaDon.TriGia}");
                }
                Console.WriteLine();
            }
        }

        static void HDCaoNhatMoiKHc2()
        {
            using (var context = new Context())
            {
                var listhoadon = context.HoaDon.ToList().GroupBy(kh => kh.MaKH).SelectMany(a => a.Where(b => b.TriGia == a.Max(c => c.TriGia)));
                foreach (var hoadon in listhoadon)
                {
                    Console.WriteLine($"{hoadon.MaKH} - {hoadon.SoHD} - {hoadon.NgHD} - {hoadon.TriGia}");
                }
                Console.WriteLine();
            }
        }

        // 19. In ra danh sách các sản phẩm (MASP,TENSP) do “Trung Quoc” sản xuất không bán được trong năm 2006.
        static void Cau19()
        {
            using (var context = new Context())
            {
                //var listsanpham = from s in context.SanPham
                //                  where s.NuocSX == "Trung Quoc"
                //                  select new
                //                  {
                //                      SoHD = hd.SoHD,
                //                      NgayHD = hd.NgHD,
                //                      TriGia = hd.TriGia
                //                  };
                //var listsanpham = context.SanPham
                //    //.Where(s => s.NuocSX == "Trung Quoc")
                //   .Select(s => new { s.MaSP })
                //   .Except(context.CTHD.Select(ct => new { ct.MaSP })).ToList();

                //var listsanpham = context.SanPham.Select(sp => sp.MaSP)
                //   .Except(context.CTHD.Select(sp1 => sp1.MaSP)).ToList();
                //from s in context.SanPham
                //join ct in context.CTHD on s.MaSP equals ct.SoHD
                //where
                var listsanpham1 = from sp in context.SanPham
                                   where sp.NuocSX == "Trung Quoc"
                                   select new
                                   {
                                       sp.MaSP, sp.TenSP
                                   };

                var listsanpham2 = from sp in context.SanPham
                                   join c in context.CTHD on sp.MaSP equals c.MaSP
                                   join hd in context.HoaDon on c.SoHD equals hd.SoHD
                                   where sp.NuocSX == "Trung Quoc" && hd.NgHD.Year == 2006
                                   select new
                                   {
                                       c.MaSP, sp.TenSP
                                   };

                var listsanpham = listsanpham1.ToList().Except(listsanpham2);

                foreach (var sp in listsanpham)
                {
                    Console.WriteLine($"{sp.MaSP} - {sp.TenSP}");
                }
                Console.WriteLine();
            }
        }
        static void Union2List()
        {
            using (var context = new Context())
            {
                var listsanpham3 = context.SanPham
                    .Where(sp => sp.NuocSX == "Trung Quoc")
                    .Select(sp => new { sp.MaSP, sp.TenSP, sp.NuocSX }).ToList();

                var listsanpham2 = context.SanPham
                    .Where(sp => sp.NuocSX == "Thai Lan")
                    .Select(sp => new { sp.MaSP, sp.TenSP, sp.NuocSX }).ToList();

                var listsanpham = listsanpham3.Union(listsanpham2);

                foreach (var sp in listsanpham)
                {
                    Console.WriteLine($"{sp.MaSP} - {sp.TenSP} - {sp.NuocSX}");
                }
                Console.WriteLine();
            }
        }

        /*Câu 21: Có bao nhiêu sản phẩm khác nhau được bán ra trong năm 2006.*/
        /*SELECT COUNT(DISTINCT MASP) SOSPBANRA
        FROM HOADON HD JOIN CTHD ON HD.SOHD = CTHD.SOHD
        WHERE YEAR(NGHD) = 2006*/ 
        static void Cau21()
        {
            using (var context = new Context())
            {
                var listsanpham = from c in context.CTHD
                                  join hd in context.HoaDon on c.SoHD equals hd.SoHD
                                  where hd.NgHD.Year == 2006
                                  group hd by hd.MaKH into g
                                  select new
                                  {
                                      MaKH = g.Key, 
                                      Count = g.Count()
                                  };

                foreach (var sp in listsanpham)
                {
                    Console.WriteLine($"{sp}");
                }
                //Console.WriteLine(listsanpham.Count());
                Console.WriteLine();
            }
        }

        // Câu 26: Tìm họ tên khách hàng đã mua hóa đơn có trị giá cao nhất trong năm 2006.
        /*
            SELECT TOP 1 WITH TIES HOTEN, TRIGIA
            FROM HOADON JOIN KHACHHANG ON HOADON.MAKH = KHACHHANG.MAKH
            WHERE YEAR(NGHD) = 2006
            ORDER BY TRIGIA DESC
         * */
        static void Cau26()
        {
            using (var context = new Context())
            {
                var list = (from k in context.KhachHang
                                  join hd in context.HoaDon on k.MaKH equals hd.MaKH
                                  where hd.NgHD.Year == 2006
                                  orderby hd.TriGia descending
                                  select new
                                  {
                                      HoTen = k.HoTen,
                                      TriGia = hd.TriGia
                                  }).Take(1);

                foreach (var item in list)
                {
                    Console.WriteLine($"{item}");
                }
                Console.WriteLine();
            }
        }
        /*Câu 11: Tìm các số hóa đơn đã mua sản phẩm có mã số “BB01” hoặc “BB02”.*/
        /*SELECT DISTINCT CTHD.SOHD
        FROM CTHD, SANPHAM, HOADON
        WHERE(SANPHAM.MASP = 'BB01'OR SANPHAM.MASP = 'BB02')
        AND SANPHAM.MASP = CTHD.MASP
        AND HOADON.SOHD = CTHD.SOHD*/
        static void Cau11()
        {
            using (var context = new Context())
            {
                var list = (from ct in context.CTHD
                            join hd in context.HoaDon on ct.SoHD equals hd.SoHD
                            join sp in context.SanPham on ct.MaSP equals sp.MaSP
                            where (sp.MaSP == "BB01" || sp.MaSP=="BB02")
                            select new
                            {
                                soHD = ct.SoHD
                            }).Distinct();

                foreach (var item in list)
                {
                    Console.WriteLine($"{item}");
                }
                Console.WriteLine();
            }
        }

        /*Câu 36: Tính tổng số lượng của từng sản phẩm bán ra trong tháng 10/2006.*/
        /*SELECT MASP, SUM(SL) TongSanPhamBanRa
        FROM CTHD INNER JOIN HOADON ON HOADON.SOHD = CTHD.SOHD
        WHERE (MONTH(NGHD)= 10 AND YEAR(NGHD)= 2006)
        GROUP BY MASP*/
        static void Cau36()
        {
            using (var context = new Context())
            {
                var list = from ct in context.CTHD
                            join hd in context.HoaDon on ct.SoHD equals hd.SoHD
                            where (hd.NgHD.Month == 10 && hd.NgHD.Year == 2006)
                            group ct by ct.MaSP into g
                            select new
                            {
                                MaSP = g.Key,
                                TongSanPhamBanRa = g.Sum(p => p.Sl)
                            };

                foreach (var item in list)
                {
                    Console.WriteLine($"Mã sản phẩm = {item.MaSP}, Tổng bán ra = {item.TongSanPhamBanRa}");
                }
                Console.WriteLine();
            }
        }

        /*Câu 39: Tìm hóa đơn có mua 3 sản phẩm do “Viet Nam” sản xuất.*/
        /*SELECT SOHD, COUNT(*)
        FROM CTHD JOIN SANPHAM SP ON SP.MASP = CTHD.MASP
        WHERE NUOCSX = 'VIETNAM'
        GROUP BY SOHD
        HAVING COUNT(*) = 3*/

        static void Cau39()
        {
            using (var context = new Context())
            {
                var list = (from ct in context.CTHD
                           join sp in context.SanPham on ct.MaSP equals sp.MaSP // chỗ này phải đúng thứ tự ct rồi mới tới sp
                           where (sp.NuocSX == "Viet Nam")
                           group ct by ct.SoHD into g
                           where(g.Count() == 3)
                           select new
                           {
                               MaSP = g.Key,
                               SoSP = g.Count()
                           });

                var list2 = context.SanPham.Where(sp => sp.NuocSX == "Viet Nam")
                    .Join(context.CTHD, sp => sp.MaSP, ct => ct.MaSP, (sp, ct) => new
                    {
                        MaSP = sp.MaSP,
                        SoHD = ct.SoHD
                    }).GroupBy(sp => sp.MaSP)
                    .Where(g => g.Count() == 3)
                    .Select(g => new
                    {
                        MaSP = g.Key,
                        SoSP = g.Count()
                    });

                foreach (var item in list)
                {
                    Console.WriteLine($"{item}");
                }
                Console.WriteLine();
            }
        }

        /*Câu 40: Tìm khách hàng (MAKH, HOTEN) có số lần mua hàng nhiều nhất.*/
        /*SELECT TOP 1 WITH TIES KH.MAKH, HOTEN, COUNT(*) SOLANMUAHANG
        FROM HOADON HD JOIN KHACHHANG KH ON HD.MAKH = KH.MAKH
        GROUP BY KH.MAKH, HOTEN
        ORDER BY COUNT(*) DESC*/

        static void Cau40()
        {
            using (var context = new Context())
            {
                var list = (from kh in context.KhachHang
                            join hd in context.HoaDon on kh.MaKH equals hd.MaKH// chỗ này phải đúng thứ tự ct rồi mới tới sp
                            group kh by new { kh.MaKH, kh.HoTen} into g
                            where (g.Count() > 1)
                            orderby g.Count() descending
                            select new
                            {
                                MaKH = g.Key.MaKH,
                                HoTen = g.Key.HoTen,
                                SoLanMuaHang = g.Count()
                            }).Take(1);

                foreach (var item in list)
                {
                    Console.WriteLine($"{item}");
                }
                Console.WriteLine();
            }
        }

        /*Câu 18: Tìm số hóa đơn đã mua tất cả các sản phẩm do Singapore sản xuất.*/
        //          SELECT SOHD
        //          FROM HOADON HD
        //          WHERE NOT EXISTS(SELECT*
        //                    FROM SANPHAM SP
        //                    WHERE NUOCSX = 'SINGAPORE'
        //                    AND NOT EXISTS(   SELECT*
        //                                        FROM CTHD
        //                                        WHERE CTHD.MASP = SP.MASP
        //                                        AND CTHD.SOHD = HD.SOHD))
        static void Cau18()
        {
            using (var context = new Context())
            {
                var list = from hd in context.HoaDon
                           where !context.SanPham.Any(sp => (sp.NuocSX == "Singapore") 
                           && (!context.CTHD.Any(ct => (ct.MaSP == sp.MaSP) && (ct.SoHD == hd.SoHD))))
                           select hd.SoHD;

                foreach (var item in list)
                {
                    Console.WriteLine($"{item}");
                }
                Console.WriteLine();
            }
        }

        /*Câu 28: In ra danh sách các sản phẩm (MASP, TENSP) có giá bán bằng 1 trong 3 mức giá cao nhất.*/
        //      SELECT MASP, TENSP
        //      FROM SANPHAM
        //      WHERE GIA IN(SELECT DISTINCT TOP 3 GIA
        //                FROM SANPHAM
        //                ORDER BY GIA DESC)
        //SELECT MASP, TENSP FROM SANPHAM WHERE GIA IN( SELECT * FROM (SELECT DISTINCT GIA FROM SANPHAM ORDER BY GIA DESC LIMIT 3)as t1);
        static void Cau28() // Câu này chưa đc
        {
            using (var context = new Context())
            {
                var list = from sp in context.SanPham
                           where (from sp2 in context.SanPham
                                  orderby sp2.Gia descending
                                  select sp2.Gia).Contains(sp.Gia)
                           select new
                           {
                               MaSP = sp.MaSP,
                               TenSP = sp.MaSP
                           };

                foreach (var item in list)
                {
                    Console.WriteLine($"{item}");
                }
                Console.WriteLine();
            }
        }

        /*Câu 34: Với từng nước sản xuất, tìm giá bán cao nhất, thấp nhất, trung bình của các sản phẩm.*/
        //SELECT NUOCSX, MAX(GIA) GiaBanCaoNhat, MIN(GIA) GiaBanThapNhat, AVG(GIA) GiaBanTB
        //FROM SANPHAM
        //GROUP BY NUOCSX
        static void Cau34()
        {
            using (var context = new Context())
            {
                var list = from sp in context.SanPham
                           group sp by new { sp.NuocSX} into g
                           select new
                           {
                               NuocSX = g.Key.NuocSX,
                               GiaBanCaoNhat = g.Max(p => p.Gia),
                               GiaBanThapNhat = g.Min(p => p.Gia),
                               GiaBanTB = g.Average(p=>p.Gia)
                           };

                foreach (var item in list)
                {
                    Console.WriteLine($"{item}");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Cau34();
        }
    }
}
