using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH4
{
    class Ctime
    {
        private int iGio, iPhut, iGiay;

        public int Giay{
            set { this.iGiay = value; }
            get { return this.iGiay; }
        }
        public Ctime(int gio, int phut, int giay)
        {
            this.iGio = gio;
            this.iPhut = phut;
            this.iGiay = giay;
        }
        
        public void KiemTraTime()
        {
            if (iGiay > 60)
            {
                int temp = iGiay;
                iGiay = temp / 60;
                temp = temp % 60;
                iPhut = iPhut + temp;
            }
            if (iPhut > 60)
            {
                int temp0 = iPhut;
                iPhut = temp0 / 60;
                temp0 = temp0 % 60;
                iGio = iGio + temp0;
            }
            if (iGio > 24)
            {
                int temp1 = iGio;
                iGio = temp1 % 24;

            }
            else
            {
                if (iGio == 24)
                {
                    iGio = 0;
                }
            }
        }

        public static Ctime operator ++(Ctime a)
        {
            a.iGiay++;
            a.KiemTraTime();
            return a;
        }
        public static Ctime operator --(Ctime a)
        {
            a.iGiay--;
            a.KiemTraTime();
            return a;
        }

        public static Ctime operator +(Ctime a, int i)
        {
            a.iGiay=a.iGiay+i;
            a.KiemTraTime();
            return a;
        }
    }
}
