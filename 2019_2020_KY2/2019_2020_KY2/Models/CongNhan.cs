using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2019_2020_KY2.Models
{
    public class CongNhan
    {
        string maCongNhan, tenCongNhan;
        Boolean gioiTinh;
        int namSinh;
        string nuocVe;

        public CongNhan()
        {
        }

        public CongNhan(string maCongNhan, string tenCongNhan, bool gioiTinh, int namSinh, string nuocVe)
        {
            this.maCongNhan = maCongNhan;
            this.tenCongNhan = tenCongNhan;
            this.gioiTinh = gioiTinh;
            this.namSinh = namSinh;
            this.nuocVe = nuocVe;
        }

        public string MaCongNhan { get => maCongNhan; set => maCongNhan = value; }
        public string TenCongNhan { get => tenCongNhan; set => tenCongNhan = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public string NuocVe { get => nuocVe; set => nuocVe = value; }
    }
}
