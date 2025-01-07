using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.Aggregation
{
    internal class Department
    {
        public int Code { get; set; }
        public /*required*/ string? Name { get; set; }
        public List<Employee>? Employee { get; set; }
    }
}
