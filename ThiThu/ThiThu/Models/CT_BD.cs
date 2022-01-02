using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThiThu.Models
{
    public class CT_BD
    {
        string mabd, macv;

        public CT_BD(string mabd, string macv)
        {
            this.mabd = mabd;
            this.macv = macv;
        }

        public string Mabd { get => mabd; set => mabd = value; }
        public string Macv { get => macv; set => macv = value; }
    }
}
