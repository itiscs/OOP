using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associations
{
    class OrderLine
    {
        public int Quantity { get; set; }
        public Item Item { get; set; }

        public override string ToString()
        {
            return String.Format($"строка заказа - {Item.Name} {Quantity}");
        }
    }
}
