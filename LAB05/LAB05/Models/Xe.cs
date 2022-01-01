using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB05.Models
{
    public class Xe
    {
        private string maXe, tenXe, mauXe;
        private int soCho;
        private string tenHang;

        public Xe()
        {
        }

        public Xe(string maXe, string tenXe, string mauXe, int soCho, string tenHang)
        {
            this.maXe = maXe;
            this.tenXe = tenXe;
            this.mauXe = mauXe;
            this.soCho = soCho;
            this.tenHang = tenHang;
        }

        public string MaXe { get => maXe; set => maXe = value; }
        public string TenXe { get => tenXe; set => tenXe = value; }
        public string MauXe { get => mauXe; set => mauXe = value; }
        public int SoCho { get => soCho; set => soCho = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
    }
}
