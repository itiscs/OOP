using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Fraction
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
            return c;
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            Fraction c = new Fraction(); // c = a * b
            c.chis = a.chis * b.chis;
            c.znam = a.znam * b.znam;
            return c;
        }


        public override string ToString()
        {
            return String.Format("{0}/{1}", chis, znam);
        }






    }
}
