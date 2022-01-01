using System;
using System.Collections.Generic;
using System.Text;

namespace _19520113_Week7
{
    class SinhVien
    {
        private string ten;
        private double dtb;
        private string mssv;
        private bool gioiTinh;

        public SinhVien() { }
        public SinhVien(string ten, double dtb, bool gioiTinh, string mssv)
        {

            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.mssv = mssv;
            this.dtb = dtb;
        }

        public string Ten
        {
            set { ten = value; }
            get { return ten; }
        }

        public double Dtb
        {
            set { dtb = value; }
            get { return dtb; }
        }

        public string Mssv
        {
            set { mssv = value; }
            get { return mssv; }
        }

        public bool GioiTinh
        {
            set { gioiTinh = value; }
            get { return gioiTinh; }
        }

    }
}
