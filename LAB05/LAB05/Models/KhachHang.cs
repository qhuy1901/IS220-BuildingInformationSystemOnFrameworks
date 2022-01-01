using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB05.Models
{
    public class KhachHang
    {
        private string maKH, hoTen, sDT;

        public KhachHang()
        {
        }

        public KhachHang(string maKH, string hoTen, string sDT)
        {
            MaKH = maKH;
            HoTen = hoTen;
            SDT = sDT;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SDT { get => sDT; set => sDT = value; }
    }
}
