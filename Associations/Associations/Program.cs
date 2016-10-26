using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            items.Add(new Item() { Article = 1, Name = "Сахар", Price = 50 });
            items.Add(new Item() { Article = 2, Name = "Соль", Price = 10 });
            items.Add(new Item() { Article = 3, Name = "Хлеб", Price = 20 });
            items.Add(new Item() { Article = 4, Name = "Спички", Price = 2 });

            foreach (Item it in items)
                Console.WriteLine(it);

            List<Customer> custs = new List<Customer>();
            custs.Add(new Customer() { Code = 1, FullName = "Покупатель 1", Phone = 111111, Priveleged = false });
            custs.Add(new Customer() { Code = 2, FullName = "Покупатель 2", Phone = 222222, Priveleged = false });
            custs.Add(new Customer() { Code = 3, FullName = "Покупатель 3", Phone = 333333, Priveleged = true });
            custs.Add(new Customer() { Code = 4, FullName = "Покупатель 4", Phone = 444444, Priveleged = false });

            foreach (Customer cu in custs)
                Console.WriteLine(cu);


            Order ord = new Order(101, "Казань, Кремль", true);
            Console.WriteLine("Введите номер покупателя");
            int k = int.Parse(Console.ReadLine());
            ord.Customer = custs[k - 1];

            Console.WriteLine("Введите количество товаров");
            k = int.Parse(Console.ReadLine());

            for(int i = 0;i< k; i++)
            {
                Console.WriteLine("Введите номер товара");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество");
                int kol = int.Parse(Console.ReadLine());

                ord.Lines.Add(new OrderLine() {
                    Quantity = kol, Item = items[m - 1] });
            }

            Console.WriteLine($"{ord}");

        }
    }
}
