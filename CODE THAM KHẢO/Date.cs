using System;
namespace ThuTrongTu
{
    public class Date
    {
        private int day, month, year;
        public Date() { }
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public void Xuat()
        {
            System.Console.WriteLine("{0}/{1}/{2}", this.day, this.month, this.year);
        }
        public bool KiemTraNhuan(int nam)
        {
            if ((nam % 4 == 0 && nam % 100 != 0)||(nam%400==0))
                return true;
            else
                return false;
        }
        public string TinhThu()
        {
            int i;
            int s = 0;
            string[] thu = { "thứ 5", "Thứ 6", "Thứ 7", "chủ nhật", "Thứ 2", "Thứ 3", "Thứ 4" };
            for (i = 1970; i < this.year; i++)
            {
                if (KiemTraNhuan(i) == true)
                    s += 366;
                else
                    s += 365;
            }
            for (i = 1; i < this.month; i++)
            {
                switch (i)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        s+= 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        s+= 30;
                        break;
                    case 2:
                        if ((this.year % 4==0 && this.year % 100 != 0)||(this.year%400==0))
                            s+= 29;
                        else
                            s+= 28;
                        break;
                }
            }
            s+= this.day;
            s--;
            Console.WriteLine("s =" + s);
            return thu[s%7];
        }
    }
}
