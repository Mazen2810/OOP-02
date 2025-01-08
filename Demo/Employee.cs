using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    enum Gender
    {
        M,G
    }
    enum SecurityLevel
    {
        guest, Developer, secretary , DBA   
    }
     class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public double Salary { get; set; }
        public DateTime HiringDate { get; set; }
        public Gender Gender { get; set; }



        public Employee(int Id, string Name, SecurityLevel SecurityLevel, double Salary, DateTime HiringDate,Gender Gender)
        {
            this.Id = Id;
            this.Name = Name;
            this.SecurityLevel = SecurityLevel;
            this.Salary = Salary;
            this.HiringDate = HiringDate;
            this.Gender = Gender;
        }

        public override string ToString()
        {
            return $"ID: {Id} \nName: {Name} \nSecurity Level: {SecurityLevel} \nSalary: {Salary.ToString("C", CultureInfo.GetCultureInfo("ar-EG"))} \nHiring Date: {HiringDate} \nGender: {Gender}";
        }

    }
}
