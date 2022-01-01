using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            var ds = new List<SinhVien>
            {
                    new SinhVien{MaSV="19520001", Dtb=7.6, TenSV="Nguyễn Minh Quân"},
                    new SinhVien{MaSV="19520002", Dtb=8.8, TenSV="Lương Thị Kim Dung"},
                    new SinhVien{MaSV="19520003", Dtb=9.2, TenSV="Vương Đức Long"},
                    new SinhVien{MaSV="19520004", Dtb=6.4, TenSV="Trần Ngọc Kim Bích"},
                    new SinhVien{MaSV="19520005", Dtb=8.1, TenSV="Nguyễn Lê Minh"},
            };

            Console.WriteLine("Danh sách SV có dtb >= 5: ");
            var ds1 = ds.Where(d => d.Dtb >= 5);

            foreach (var obj in ds1)
            {
                Console.WriteLine(obj.Ten + " " + obj.Dtb + " " + obj.GioiTinh + " " + obj.Mssv);
            }


        }
    }
}
