using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encapsulation
{
    internal struct Employee
    {
        //*** Encapsulation: Separates data definition[Fields] from its Use [Getters & Setters]
        #region Attributes

        private int id;
        private string? name;
        private decimal salary;
        //private decimal deduction; // Derived Attribute
        #endregion



        #region 1.Applying Encapsulation through Setters ad Getters [Old Approach]

        //Getter
        public int GetId()
        {
            return id;
        }
        //Setter
        public void SetId(int val)
        {
            id = val;
        }
        #endregion

        #region Properties
        // Applying Encapsulation through properties [New Approach] (Recommended)


        //2.1 Full Property
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string? Name
        {

            set
            {
                //Data Validation

                // name = value?.Length<=10? value : value.Substring(0,10 );
                name = NameIsValid(value);

            }
            // init { }
            get
            {
                return name;
            }
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                // salary = value >= 5000 ? value : 5000;
                salary = SalaryIsValid(value);
            }
        }

        //ReadOnly Property
        public decimal Deduction
        {
            get { return salary * .2M; }
        }


        //2.2 Automatic Property
        // Compiler Will Generate Backing Field 'Hidden Private Attribute'
        // int <age>_backingField; 
        public int Age { get; set; }
        #endregion

        #region Code Snippet for Property
        // Propfull : is a Code Snippet for [ Full Property ]

        //private string address;

        //public string Address
        //{
        //    get { return address; }
        //    set { address = value; }
        //}


        // prop : is a Code Snippet for [ Automatic Property ]

        // public string Address { get; set; }

        #endregion
        #region Constructor
        public Employee(int id, string? name, decimal salary)
        {
            this.id = id;
            this.name = NameIsValid(name);
            this.salary = SalaryIsValid(salary);
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"ID={this.id} \n Name={this.name} \n Salary={this.salary:c}";
        }

        private string? NameIsValid(string? name)
        {
            return name is null ? null : name.Length <= 10 ? name : name.Substring(0, 10);

        }

        private decimal SalaryIsValid(decimal name)
        {
            return salary >= 5000 ? salary : 5000;

        }
        #endregion

    }
}
