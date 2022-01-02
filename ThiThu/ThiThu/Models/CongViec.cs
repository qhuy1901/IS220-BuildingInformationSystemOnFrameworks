using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThiThu.Models
{
    public class CongViec
    {
        string maCV, tenCV;
        int donGia;

        public CongViec(string maCV, string tenCV, int donGia)
        {
            this.maCV = maCV;
            this.tenCV = tenCV;
            this.donGia = donGia;
        }

        public string MaCV { get => maCV; set => maCV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }
        public int DonGia { get => donGia; set => donGia = value; }
    }
}
