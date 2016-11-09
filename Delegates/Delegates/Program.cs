using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate int OperDeleg(int a, int b);
        delegate void Deleg2();

        static void Hello1()
        {
            Console.WriteLine("Hello!");
        }

        static void Hello2()
        {
            Console.WriteLine("Hello, world!");
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Minus(int a, int b)
        {
            return a - b;
        }

        static int Mult(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            int a = 5, b = 3;


            OperDeleg d = new OperDeleg(Sum);

            Console.WriteLine($"{a} + {b} = {d(a, b)}");

            d = Minus;

            Console.WriteLine($"{a} - {b} = {d(a, b)}");

            d = Mult;

            Console.WriteLine($"{a} * {b} = {d(a, b)}");

            //d = delegate (int k, int l)
            //{
            //    return k / l;
            //};
            d = (k, l) => k / l; 

            Console.WriteLine($"{a} / {b} = {d(a, b)}");

            //d = delegate (int k, int l)
            //{
            //    return k % l;
            //};

            d = (k, l) =>  k % l;

            Console.WriteLine($"{a} % {b} = {d(a, b)}");

            
            Deleg2 d2 = new Deleg2(Hello1);

            d2();

            d2 = Hello2;
            // d2 += Hello2;

            d2();

            d2 = delegate ()
            {
                Console.WriteLine("Hello from anonym!");
            };

            d2();

            d2 = () => { Console.WriteLine("Hello from lambda!"); };
            d2();



        }
    }
}
