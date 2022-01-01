using System;
namespace firstWeb.Models
{
    public class SinhVien
    {
        private string maSinhVien;
        private string tenSinhVien;
        private double diemTrungBinh;
        private string maBoMon;
        public string MaSinhVien {
            get { return maSinhVien; }
            set { maSinhVien = value; }
        }
        public string TenSinhVien {
            get { return tenSinhVien; }
            set { tenSinhVien = value; }
        }
        public double DiemTrungBinh
        {
            get { return diemTrungBinh; }
            set { diemTrungBinh = value; }
        }
        public string MaBoMon
        {
            get { return maBoMon; }
            set { maBoMon = value; }
        }
        public SinhVien()
        {
        }
    }
}
