using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaQuangHuy_19520113.Models
{
    public class HoaDon
    {
        private int soHD;
        private DateTime ngHD;
        private string maKH, maNV;
        private double triGia;

        public HoaDon()
        {
        }

        public HoaDon(int soHD, DateTime ngHD, string maKH, string maNV, double triGia)
        {
            this.SoHD = soHD;
            this.NgHD = ngHD;
            this.MaKH = maKH;
            this.MaNV = maNV;
            this.TriGia = triGia;
        }
        public int SoHD { get => soHD; set => soHD = value; }
        public DateTime NgHD { get => ngHD; set => ngHD = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public double TriGia { get => triGia; set => triGia = value; }
    }
}
