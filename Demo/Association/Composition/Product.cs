using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.Composition
{
    internal class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public decimal UnitPrice { get; set; }
        public int UnitsOfStock { get; set; }

        public Product(string name)
        {
            Name = name;
        }
    }
}
