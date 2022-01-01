using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LAB03_LINQ
{
    public class CTHD
    {
        private int soHD;
        private string maSP;
        private int sl;

        public CTHD()
        {
        }

        public CTHD(int soHD, string maSP, int sl)
        {
            this.SoHD = soHD;
            this.MaSP = maSP;
            this.Sl = sl;
        }
        [Key]
        public int SoHD { get => soHD; set => soHD = value; }
        [Column("MASP")]
        public string MaSP { get => maSP; set => maSP = value; }
        public int Sl { get => sl; set => sl = value; }
    }
}
