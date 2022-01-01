using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaQuangHuy_19520113.Models
{
    public class NhanVien
    {
        private string maNV, hoTen, soDT;
        private DateTime ngvl;

        public NhanVien()
        {
        }

        public NhanVien(string maNV, string hoTen, string soDT, DateTime ngvl)
        {
            this.MaNV = maNV;
            this.HoTen = hoTen;
            this.SoDT = soDT;
            this.Ngvl = ngvl;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public DateTime Ngvl { get => ngvl; set => ngvl = value; }
    }
}
