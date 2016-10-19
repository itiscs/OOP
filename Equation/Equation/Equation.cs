using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    class Equation
    {
        protected int count_sol;
        public virtual void Solve()
        {
            PrintSolution();
        }

        public virtual void PrintSolution()
        {
            Console.WriteLine("don't know type");
        }
    }
    
    class Equation0:Equation
    {
        protected double c;

        public Equation0(double c)
        {
            this.c = c;
        }
        public override void Solve()
        {
            if (c == 0)
                count_sol = int.MaxValue;
            else
                count_sol = 0;
        }
        public override void PrintSolution()
        {
            if (count_sol == 0)
                Console.WriteLine("Корней нет");
            else
                Console.WriteLine("Корень любое число");
        }
    }
    class Equation1 : Equation0
    {
        protected double b;
        protected double x1;

        public Equation1(double b, double c):base(c)
        {
            this.b = b;
        }
        public override void Solve()
        {
            count_sol = 1;
            x1 = -c / b;
        }
        public override void PrintSolution()
        {
            Console.WriteLine($"Корень = {x1}");
        }

    }
    class Equation2 : Equation1
    {
        protected double a;
        protected double x2;

        public Equation2(double a,double b, double c) : base(b,c)
        {
            this.a = a;
        }
        public new void Solve()
        {
            double discr = b * b - 4 * a * c;
            if (discr < 0)
                count_sol = 0;
            else
            {
                count_sol = 2;
                x1 = (-b + Math.Sqrt(discr)) / 2 * a;
                x2 = (-b - Math.Sqrt(discr)) / 2 * a;
            }
        }
        public override void PrintSolution()
        {
            if(count_sol==0)
                Console.WriteLine("Корней нет");
            else
            {
                Console.WriteLine($"Корни x1={x1}   x2={x2}");                
            }
        }

    }

}
