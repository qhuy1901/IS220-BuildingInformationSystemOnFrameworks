using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaQuangHuy_19520113.Models
{
    public class SanPham
    {
        private string maSP, tenSP, dvt, nuocSX;
        private int gia;

        public SanPham()
        {
        }

        public SanPham(string maSP, string tenSP, string dvt, string nuocSX, int gia)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.Dvt = dvt;
            this.NuocSX = nuocSX;
            this.Gia = gia;
        }

        //[Key]
        //[Column("MASP")]
        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string Dvt { get => dvt; set => dvt = value; }
        public string NuocSX { get => nuocSX; set => nuocSX = value; }
        public int Gia { get => gia; set => gia = value; }
    }
}
