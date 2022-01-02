using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThiThu.Models
{
    public class KhachHang
    {
        string maKH, hoTenKH, diaChi, dienThoai;

        public KhachHang(string maKH, string hoTenKH, string diaChi, string dienThoai)
        {
            this.maKH = maKH;
            this.hoTenKH = hoTenKH;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string HoTenKH { get => hoTenKH; set => hoTenKH = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
    }
}
