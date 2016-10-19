using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equation> sp = new List<Equation>();
            sp.Add(new Equation0(0));
            sp.Add(new Equation1(4, -8));
            sp.Add(new Equation2(1, -2, 1));
            
            //Equation0 e0 = new Equation0(4);
            //Equation1 e1 = new Equation1(4,-8);
            //Equation2 e2 = new Equation2(1,-2,1);

            //Equation e = e2;
            foreach (Equation e in sp)
            {
                e.Solve();
                e.PrintSolution();
            }

        }

        static void MainOld(string[] args)
        {
            Test a = new Test();
            Derived d = new Derived();
            SubDerived s = new SubDerived();

            Test ad = d, a2 = s;
            Derived dd = s;

            ad.Method1();
            a2.Method1();

            dd.Method1();
            dd.Method2();
           
        }
    }
}
