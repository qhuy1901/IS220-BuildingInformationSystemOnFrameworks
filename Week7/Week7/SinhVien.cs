using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Week7
{
    public class SinhVien // chú ý ở đây phải là public class
    {
        private string maSV;
        private string tenSV;
        private double dtb;

        public SinhVien()
        {

        }
        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }

        public string TenSV
        {
            get { return tenSV; }
            set { tenSV = value; }
        }

        public double Dtb
        {
            get { return dtb; }
            set { dtb = value; }
        }
    }
}
