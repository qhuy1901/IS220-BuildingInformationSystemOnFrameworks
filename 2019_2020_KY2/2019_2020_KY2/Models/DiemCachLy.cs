using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2019_2020_KY2.Models
{
    public class DiemCachLy
    {
        string maDiemCachLy;
        string tenDiemCachLy;
        string diaChi;

        public DiemCachLy()
        {
        }

        public DiemCachLy(string maDiemCachLy, string tenDiemCachLy, string diaChi)
        {
            this.maDiemCachLy = maDiemCachLy;
            this.tenDiemCachLy = tenDiemCachLy;
            this.diaChi = diaChi;
        }

        public string MaDiemCachLy { get => maDiemCachLy; set => maDiemCachLy = value; }
        public string TenDiemCachLy { get => tenDiemCachLy; set => tenDiemCachLy = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
