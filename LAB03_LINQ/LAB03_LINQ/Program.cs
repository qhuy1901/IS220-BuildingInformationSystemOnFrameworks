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

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Cau21();
        }
    }
}
