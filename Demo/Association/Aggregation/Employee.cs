using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.Aggregation
{
    internal class Employee
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }

        public decimal Salary { get; set; }

        public Department? Department { get; set; }
    }
}
