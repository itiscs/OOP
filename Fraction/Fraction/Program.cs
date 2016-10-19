using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(6,9);
            Fraction g = new Fraction(3, 7);
            Fraction h;
            f.Socr();
            h = f + g;   // operator+(f,g)

            // Console.WriteLine("{0}/{1}", f.Chis, f.Znam);
            //Console.WriteLine("{0} + {1} = {2}",f,g,h);

            Random r = new Random();
            Fraction[] a = new Fraction[5];
            for (int i = 0; i < 5; i++)
            {
                a[i] = new Fraction(r.Next(-10,10), r.Next(10));
                Console.WriteLine("{0} - {1}", i, a[i]);
            }
            Console.WriteLine("*************************");
            //for(int i=4; i>0; i--)
            //    for(int j = 0; j<i; j++)
            //    {
            //        if(a[j]>a[j+1])
            //        {
            //            f = a[j];
            //            a[j] = a[j + 1];
            //            a[j + 1] = f;
            //        }
            //    }
            List<Fraction> l = new List<Fraction>();
            l = a.ToList<Fraction>();
            l.Sort();

            int ii = 0;
            foreach(Fraction ff in l)
                Console.WriteLine("{0} - {1}", ii++, ff);


            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("{0} - {1}", i, a[i]);
            //}
            

        }
    }
}
