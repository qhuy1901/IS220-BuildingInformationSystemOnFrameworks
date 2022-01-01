using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19520113_Week7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var ds = new List<SinhVien>
            {
                new SinhVien{Ten="Tung", Dtb = 6.3, GioiTinh=true, Mssv="19520001"},
                new SinhVien{Ten="Minh", Dtb = 7.3, GioiTinh=true, Mssv="19520002"},
                new SinhVien{Ten="Nam", Dtb = 8.3, GioiTinh=true, Mssv="19520003"},
                new SinhVien{Ten="Trang", Dtb = 6.3, GioiTinh=false, Mssv="19520004"},
                new SinhVien{Ten="Yến", Dtb = 10, GioiTinh=false, Mssv="19520005"},
            };


            foreach (var obj in ds)
            {
                Console.WriteLine(obj.Ten + " " + obj.Dtb + " " + obj.GioiTinh + " " + obj.Mssv);
            }

            Console.WriteLine("Danh sách SV có dtb >= 5: ");
            var ds1 = ds
                .Where(d => d.Dtb >= 5);

            foreach (var obj in ds1)
            {
                Console.WriteLine(obj.Ten + " " + obj.Dtb + " " + obj.GioiTinh + " " + obj.Mssv);
            }

            Console.Write("Nhập tên SV x: ");
            string tenSVX = Console.ReadLine();

            var ds2 = ds
                .Where(d => d.Ten == tenSVX);
            foreach (var obj in ds2)
            {
                Console.WriteLine(obj.Ten + " " + obj.Dtb + " " + obj.GioiTinh + " " + obj.Mssv);
            }

            Console.WriteLine("Sắp xếp SV theo thứ tự dtb tăng: ");
            var ds3 = ds
            .OrderBy(d => d.Dtb);

            foreach (var obj in ds2)
            {
                Console.WriteLine(obj.Ten + " " + obj.Dtb + " " + obj.GioiTinh + " " + obj.Mssv);
            }

            var ds4 = ds
            .GroupBy(d => d.GioiTinh)
            .Select(std => new
            {
                Key = std.Key,
                sv = std.OrderBy(x => x.Dtb)
            });

            foreach (var namegroup in ds4)
            {
                Console.WriteLine(namegroup.Key);
                foreach (var obj in namegroup.sv)
                    Console.WriteLine(obj.Ten + " " + obj.Dtb + " " + obj.GioiTinh + " " + obj.Mssv);
            }

            var ds6 = ds.GroupBy(s => s.GioiTinh).SelectMany(a => a.Where(b => b.Dtb == a.Max(c => c.Dtb)));
            foreach (SinhVien sv in ds6)
            {
                Console.WriteLine("MSSV: {0} - Ten: {1}, DiemTB: {2}, GioiTinh: {3}", sv.Mssv, sv.Ten, sv.Dtb, sv.GioiTinh);
            }
        }
    }
}

