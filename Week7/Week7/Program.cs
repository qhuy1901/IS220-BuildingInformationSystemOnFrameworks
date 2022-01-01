
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week7
{
    class Program
    {
        // Tạo một danh sách có 5 sinh viên 
        static void Them5SinhVien()
        {
            using (var context = new SinhVienContent())
            {
                var ds = new List<SinhVien>
                {
                    new SinhVien{MaSV="19520001", Dtb=7.6, TenSV="Nguyễn Minh Quân"},
                    new SinhVien{MaSV="19520002", Dtb=8.8, TenSV="Lương Thị Kim Dung"},
                    new SinhVien{MaSV="19520003", Dtb=9.2, TenSV="Vương Đức Long"},
                    new SinhVien{MaSV="19520004", Dtb=6.4, TenSV="Trần Ngọc Kim Bích"},
                    new SinhVien{MaSV="19520005", Dtb=8.1, TenSV="Nguyễn Lê Minh"},
                };
                foreach(var sv in ds)
                {
                    context.SinhVien.Add(sv);
                }    
                // Thực hiện Insert vào DB các dữ liệu đã thêm.
                int rows = context.SaveChanges();
                Console.WriteLine($"Đã lưu {rows} sản phẩm");
                Console.WriteLine();
            }
        }
        public static void InDSSinhVien()
        {
            using (var context = new SinhVienContent())
            {
                var ds = context.SinhVien.ToList();
                Console.WriteLine("Danh sách sinh viên");
                
                foreach (var sv in ds)
                {
                    Console.WriteLine($"{sv.MaSV} {sv.TenSV} - {Math.Round(sv.Dtb,2)}");
                }
            }
            Console.WriteLine();
        }

        // Liệt kê sinh viên có điểm trung bình >= 5
        public static void LietKeSV()
        {
            using (var context = new SinhVienContent())
            {
                Console.WriteLine("Danh sách SV có dtb >= 5: ");
                var ds = context.SinhVien.Where(d => d.Dtb >= 5);

                foreach (var sv in ds)
                {
                    Console.WriteLine($"{sv.MaSV} {sv.TenSV} - {Math.Round(sv.Dtb, 2)}");
                }
            }
            Console.WriteLine();
        }

        // Tìm sinh viên có tên = x (x nhập)
        public static void TimSinhVienTenX()
        {
            
            Console.Write("Nhập tên sinh viên X: ");
            string tenSVX = Console.ReadLine();
            using (var context = new SinhVienContent())
            {
                Console.WriteLine($"Thông tin sính viên có tên {tenSVX} là: ");
                var ds = context.SinhVien.Where(d => d.TenSV == tenSVX);

                foreach (var sv in ds)
                {
                    Console.WriteLine($"{sv.MaSV} {sv.TenSV} - {Math.Round(sv.Dtb, 2)}");
                }
            }
            Console.WriteLine();
        }

        // Gom nhóm sinh viên theo giới tính, sau đó sắp sếp tăng theo điểm trung bình 
        public static void GomNhomVaSapXep()
        {
            using (var context = new SinhVienContent())
            {
                var ds = context.SinhVien.ToList().GroupBy(d => d.TenSV).Select(std => new
                {
                    Key = std.Key,
                    sv = std.OrderBy(x => x.Dtb)
                });

                foreach (var tenSV in ds)
                {
                    Console.WriteLine($"Tên sinh viên: {tenSV.Key}");
                    foreach (var obj in tenSV.sv)
                        Console.WriteLine("+ " + obj.TenSV + " " + obj.Dtb);
                }
            }
            Console.WriteLine();
        }

        public static void XoaSinhVienX()
        {
            Console.Write("Nhập mã sinh viên X: ");
            string maSVX = Console.ReadLine();
            using (var context = new SinhVienContent())
            {
                var sv = (from p in context.SinhVien where (p.MaSV == maSVX) select p).FirstOrDefault(); // Lấy Sinh vien có  maSV  chỉ  ra

                if(sv != null)
                {
                    context.Remove(sv);
                    Console.WriteLine($"Đã xóa sinh viên có mã số {sv.MaSV}!");
                    context.SaveChanges();
                }
                else
                    Console.WriteLine($"Sinh viên có mã số {sv.MaSV} không tồn tại!");
            }
            Console.WriteLine();
        }

        // Sắp xếp danh sách sinh viên tăng theo DTB
        public static void SapXepTang()
        {

            Console.WriteLine("Sắp xếp SV theo thứ tự tăng theo dtb : ");
            using (var context = new SinhVienContent())
            {
                var ds = context.SinhVien.OrderBy(d => d.Dtb);

                foreach (var sv in ds)
                {
                    Console.WriteLine($"{sv.MaSV} {sv.TenSV} - {Math.Round(sv.Dtb, 2)}");
                }
            }  
        }

        // Cho biết điểm trung bình cao nhất trong từng giới tính 

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            // Them5SinhVien();
            //InDSSinhVien();
            //TimSinhVienTenX();
            //SapXepTang();
            GomNhomVaSapXep();
            //XoaSinhVienX();

        }
    }
}
