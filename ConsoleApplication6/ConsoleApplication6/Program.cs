using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Point
    {
        private double x;
        private double y;
        
        public Point():this(1)
        {
            //x = y = 1;
        }

        public Point(double p_x):this(p_x,p_x)
        {
           // x = y = p_x;
        }

        private Point(double p_x, double p_y)
        {
            x = p_x;
            y = p_y;
        }

        public static Point Create1(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point Create2(double x)
        {
            double y = 1 - x;
            return new Point(x, y);
        }


        public double M_x
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
             }
        }

        public double M_y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        //public void SetX(double p_x)
        //{
        //    x = p_x;
        //}

        //public void SetY(double p_y)
        //{
        //    y = p_y;
        //}

        //public double GetX()
        //{
        //    return x;
        //}

        //public double GetY()
        //{
        //    return y;
        //}

        //public void Show()
        //{
        //    Console.WriteLine("точка - ({0},{1})", x, y);
        //}

        public override string ToString()
        {
            return String.Format("точка - ({0},{1})", x, y);
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Point a = Point.Create2(0.6);
            Point b = Point.Create1(1, 3);
            Point c = new Point();

            //a.M_x = -5;
            //a.M_y = 6;
            //a.SetX(5);
            //a.SetY(6);
            //a.Show();

            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.WriteLine(b);
            

        }
    }
}
