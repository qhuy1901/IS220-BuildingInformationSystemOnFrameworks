using System;
namespace firstWeb.Models
{
    public class Khoa
    {
        private string maKhoa;
        private string tenKhoa;

        public string MaKhoa{
            get { return maKhoa; }
            set { maKhoa = value; }
        }
        public string TenKhoa {
            get { return tenKhoa;}
            set { tenKhoa = value; }
        }
        public Khoa()
        {
         /*   maKhoa = "";
            tenKhoa = "";*/
        }
        public Khoa(string makhoa, string tenkhoa)
        {
            this.maKhoa = makhoa;
            this.tenKhoa = tenkhoa; 
        }
       // public StoreContext context;
    }
}
