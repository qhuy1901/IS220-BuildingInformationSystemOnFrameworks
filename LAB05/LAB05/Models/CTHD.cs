using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB05.Models
{
    public class CTHD
    {
        private string maHD, maXe;

        public CTHD()
        {
        }

        public CTHD(string maHD, string maXe)
        {
            this.maHD = maHD;
            this.maXe = maXe;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaXe { get => maXe; set => maXe = value; }

    }
}
