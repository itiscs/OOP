using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associations
{
    class Order
    {
        public int Number { get; set; }
        public string Address { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Express { get; set; }
        public Customer Customer { get; set; }
        public List<OrderLine> Lines {get;set;}

        public Order(int number, string address, bool express)
        {
            this.Lines = new List<OrderLine>();
            this.Address = address;
            this.Number = number;
            this.Express = express;
            this.CreationDate = DateTime.Now;
        }

        public override string ToString()
        {
            string s = $"Заказ - {Number} {Customer.FullName}  {Address} {CreationDate} {Express}\n";
            foreach (OrderLine ol in Lines)
                s += $"{ol}\n";

            return s;
        }



    }
}
