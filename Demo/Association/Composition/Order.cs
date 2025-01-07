using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.Composition
{
    internal class Order
    {
        //Association Relationship [Composition] : has a
        //                                       : OrderItem has a Item 
        public int Id { get; set; }

        public string? UserEmail { get; set; }

        public decimal SubTotal { get; set; }
        public List<OrderItem>? Items { get; set; }

        public Order(string UserEmail, List<OrderItem> Items)
        {
            UserEmail = UserEmail;
            Items = Items;

        }
    }
}
