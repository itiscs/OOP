using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Fraction//:IComparable
    {
        private int chis;
        private int znam;

        public int Chis
        {
            get { return chis; }
            set { chis = value; }
        }

        public int Znam
        {
            get
            {
                return znam;
            }
            set
            {
                if (value > 0)
                    znam = value;
                else
                    Console.WriteLine("введите положительное число!");
            }
        }

        public Fraction() //конструктор по умолчанию
        {
            chis = 0;
            znam = 1;
        }

        public Fraction(int ch, int zn)  //конструктор со всеми полями
        {
            chis = ch;
            znam = zn;
        }

        public Fraction(Fraction f) //конструктор "копирования"
        {
            chis = f.chis;
            znam = f.znam;
        }

        public static Fraction operator+(Fraction a, Fraction b)
        { 
            Fraction c = new Fraction(); // c = a + b
            c.chis = a.chis * b.znam + a.znam * b.chis;
            c.znam = a.znam * b.znam;
            c.Socr();
            return c;
        }

        
        public static Fraction operator *(Fraction a, Fraction b)
        {
            Fraction c = new Fraction(); // c = a * b
            c.chis = a.chis * b.chis;
            c.znam = a.znam * b.znam;
            c.Socr();
            return c;
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            return a.chis * b.znam > a.znam * b.chis;
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            return a.chis * b.znam < a.znam * b.chis;
        }
        public static bool operator >=(Fraction a, Fraction b)
        {
            return a.chis * b.znam >= a.znam * b.chis;
        }
        public static bool operator <=(Fraction a, Fraction b)
        {
            return a.chis * b.znam <= a.znam * b.chis;
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.chis * b.znam == a.znam * b.chis;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return a.chis * b.znam != a.znam * b.chis;
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", chis, znam);
        }

        public override bool Equals(object obj)
        {
            return this == (Fraction)obj;
        }


        public void Socr()
        {
            int a = chis;
            int b = znam;

            while (a!=0 && b!=0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;                 
            }
            a = a + b;
            chis /= a;
            znam /= a;
        }

        public int CompareTo(object obj)
        {
            if (this < (Fraction)obj)
                return -1;
            if (this > (Fraction)obj)
                return 1;
            return 0;
        }
    }
}
