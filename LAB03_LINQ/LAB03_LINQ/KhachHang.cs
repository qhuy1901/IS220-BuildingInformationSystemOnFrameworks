using System;
using System.Collections.Generic;
using System.Text;

namespace LAB03_LINQ
{
    public class KhachHang
    {
        private string maKH, hoTen, dChi, soDT;
        private DateTime ngSinh, ngDK;
        private int doanhSo;

        public KhachHang()
        {
        }

        public KhachHang(string maKH, string hoTen, string dChi, string soDT, DateTime ngSinh, DateTime ngDK, int doanhSo)
        {
            this.maKH = maKH;
            this.hoTen = hoTen;
            this.dChi = dChi;
            this.soDT = soDT;
            this.ngSinh = ngSinh;
            this.ngDK = ngDK;
            this.doanhSo = doanhSo;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DChi { get => dChi; set => dChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public DateTime NgSinh { get => ngSinh; set => ngSinh = value; }
        public DateTime NgDK { get => ngDK; set => ngDK = value; }
        public int DoanhSo { get => doanhSo; set => doanhSo = value; }
    }
}
