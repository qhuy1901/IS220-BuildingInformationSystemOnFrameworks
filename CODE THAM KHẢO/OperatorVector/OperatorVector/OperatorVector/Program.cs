using System;

namespace OperatorVector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(1,2);
            Vector v2 = new Vector(3,4);
            Vector v3 = new Vector();
            Vector v4 = new Vector();
            v3 = v1 + 2;
            v3.Xuat();
            v4 =++v3;
            v4.Xuat();
            v4 += v1;
            v4.Xuat();
            
            if (v1 == v2)
                Console.WriteLine("bang nhau");
            else
                Console.WriteLine("Khac nhau");
        }
    }
}
