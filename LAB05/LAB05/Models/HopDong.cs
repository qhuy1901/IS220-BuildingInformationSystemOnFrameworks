using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB05.Models
{
    public class HopDong
    {
        private string maHD, tenHD;
        private DateTime ngayLap;
        private string maKH;
        private int tongTien;

        public HopDong()
        {
        }

        public HopDong(string maHD, string tenHD, DateTime ngayLap, string maKH, int tongTien)
        {
            this.maHD = maHD;
            this.tenHD = tenHD;
            this.ngayLap = ngayLap;
            this.maKH = maKH;
            this.tongTien = tongTien;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string TenHD { get => tenHD; set => tenHD = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
    }
}
