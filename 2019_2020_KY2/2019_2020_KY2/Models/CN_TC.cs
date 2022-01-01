using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2019_2020_KY2.Models
{
    public class CN_TC
    {
        string maCongnhan, maTrieuChung;

        public CN_TC()
        {
        }

        public CN_TC(string maCongnhan, string maTrieuChung)
        {
            this.maCongnhan = maCongnhan;
            this.maTrieuChung = maTrieuChung;
        }

        public string MaCongnhan { get => maCongnhan; set => maCongnhan = value; }
        public string MaTrieuChung { get => maTrieuChung; set => maTrieuChung = value; }
    }
}
