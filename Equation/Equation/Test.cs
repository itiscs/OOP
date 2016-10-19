using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    class Test   // базовый
    {
        protected int pole1;
        public virtual void Method1()
        {
            Console.WriteLine("Method1");
        }
        
    }

    class Derived: Test
    {
        int pole2;

        public override void Method1()
        {
            
            Console.WriteLine("Method1 из Derived");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 из Der");            
        }
    }
    class SubDerived : Derived
    {
        

        public override void Method1()
        {

            Console.WriteLine("Method1 из SubDerived");
        }

        public new void Method2()
        {
            Console.WriteLine("Method2 из SubDer");
        }
    }


}
