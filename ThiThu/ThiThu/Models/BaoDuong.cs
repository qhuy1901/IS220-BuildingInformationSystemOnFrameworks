using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThiThu.Models
{
    public class BaoDuong
    {
        string maBD;
        string ngayNhan, ngayTra;
        string soKM, noiDung, soXe;

        public BaoDuong()
        {
        }

        public BaoDuong(string maBD, string ngayNhan, string ngayTra, string soKM, string noiDung, string soXe)
        {
            this.maBD = maBD;
            this.ngayNhan = ngayNhan;
            this.ngayTra = ngayTra;
            this.soKM = soKM;
            this.noiDung = noiDung;
            this.soXe = soXe;
        }

        public string MaBD { get => maBD; set => maBD = value; }
        public string NgayNhan { get => ngayNhan; set => ngayNhan = value; }
        public string NgayTra { get => ngayTra; set => ngayTra = value; }
        public string SoKM { get => soKM; set => soKM = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string SoXe { get => soXe; set => soXe = value; }
    }
}
