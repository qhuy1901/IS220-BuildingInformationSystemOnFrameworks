using System;
using System.Collections.Generic;
using System.Text;

namespace TranAnhTuan_17521224
{
    class MangMotChieu<T>
    {
        private int n;
        private T[] array;

        public int N { get => n; set => n = value; }
        public T[] Array { get => array; set => array = value; }

        public void nhapMang()
        {
            n=int.Parse(Console.ReadLine());
            array = new T[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap gia tri phan tu thu " + i + ": ");
               // Array[i] = Console.ReadLine();
               array[i]= (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            }
        }

        public void xuatMang()
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write(array[i]+ "\t");
            }
        }

        public T tinhTong()
        {
            dynamic tong=0;
            for(int i = 0; i < n; i++)
            {
                tong += array[i];
            }
            return tong;
        }



    }
}

//class Program
//{
//    static void Main(string[] args)
//    {
//        MangMotChieu<int> mangMotChieuInt = new MangMotChieu<int>();
//        mangMotChieuInt.nhapMang();
//        mangMotChieuInt.tinhTong();
//        mangMotChieuInt.xuatMang();



//        MangMotChieu<float> mangMotChieuFloat = new MangMotChieu<float>();
//        mangMotChieuFloat.nhapMang();
//        mangMotChieuFloat.tinhTong();
//        mangMotChieuFloat.xuatMang();
//        Console.ReadLine();
//    }
//}