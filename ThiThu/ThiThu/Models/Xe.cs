using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThiThu.Models
{
    public class Xe
    {
        string soXe, hangXe, namSX, maKH;

        public Xe(string soXe, string hangXe, string namSX, string maKH)
        {
            this.soXe = soXe;
            this.hangXe = hangXe;
            this.namSX = namSX;
            this.maKH = maKH;
        }

        public string SoXe { get => soXe; set => soXe = value; }
        public string HangXe { get => hangXe; set => hangXe = value; }
        public string NamSX { get => namSX; set => namSX = value; }
        public string MaKH { get => maKH; set => maKH = value; }
    }
}
