using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associations
{
    class Item
    {
        public int Article { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return String.Format($"Товар - {Name}, артикул-{Article}, цена - {Price}");
        }
    }
}
