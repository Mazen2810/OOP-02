using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Child : Parent
    {
        public int Z { get; set; }

        // public Child(): base() { }
        public Child(int X, int Y, int Z) : base(X, Y)
        {
            this.Z = Z;
        }

        public new int Product()
        {
            return X * Y * Z;
        }
        public override string ToString()
        {
            return $"X={X} \n Y= {Y} \n Z = {Z}";
        }

    }
}
