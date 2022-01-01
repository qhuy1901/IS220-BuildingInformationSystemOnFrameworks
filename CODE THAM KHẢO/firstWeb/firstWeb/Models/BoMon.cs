using System;
namespace firstWeb.Models
{
    public class BoMon
    {
        private string maBoMon;
        private string tenBoMon;
        private string maKhoa;
        public string MaBoMon {
            get { return maBoMon; }
            set { maBoMon = value; }
        }
        public string TenBoMon {
            get { return tenBoMon; }
            set { tenBoMon = value; }
        }
        public string MaKhoa{
            set {maKhoa = value;}
            get { return maKhoa;}
        }
        public BoMon(string mabomon, string tenbomon, string makhoa)
        {
            this.maBoMon = mabomon;
            this.tenBoMon = tenbomon;
            this.maKhoa = makhoa; 
        }
        public BoMon()
        {
        }
    }
}
