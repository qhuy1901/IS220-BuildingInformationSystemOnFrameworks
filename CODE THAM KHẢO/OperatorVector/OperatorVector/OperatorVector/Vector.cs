using System;
namespace OperatorVector
{
    
    public class Vector
    {
        private double x, y;
        public double X {
            get { return x; }
            set { x = value; }
        }
        public double Y {
            get { return y; } 
            set { y = value; }
        }
        public Vector()
        {
            x = 0;
            y = 0;
        }
        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Xuat()
        {
            Console.WriteLine($"{x}/{y}");
        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            Vector tam = new Vector
            {
                X = v1.X + v2.X,
                Y = v1 .Y + v2 .Y
            };
            return tam; 
        }
        
        public static Vector operator ++(Vector v)
        {
            v.X++;
            v.Y++;
            return v; 
        }
        public static Vector operator +(Vector v, double x)
        {
            Vector tam = new Vector
            {
                X = v.X + x,
                Y = v.Y + x
            };
            return tam; 
        }
        public static bool operator !=(Vector x1, Vector x2)
        {
            if ((x1.X != x2.X) || (x1.Y != x2.Y))
                return true;
            else
                return false;
        }
        public static bool operator ==(Vector x1, Vector x2)
        {
            if ((x1.X == x2.X) && (x1.Y == x2.Y))
                return true;
            else
                return false; 
        }
    }
}
