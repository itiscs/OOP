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
            Fraction f = new Fraction(1,3);
            Fraction g = new Fraction(3, 7);
            Fraction h;

            h = f + g;   // operator+(f,g)

            // Console.WriteLine("{0}/{1}", f.Chis, f.Znam);
            Console.WriteLine("{0} + {1} = {2}",f,g,h);


        }
    }
}
