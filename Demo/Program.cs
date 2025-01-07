using Demo.Encapsulation;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation

            Employee employee = new Employee(1001, "Ahmed Nasr", 10_000);

            employee.SetId(2002); //Set ID

            employee.Name = "Ibrahim Ali";
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.GetId()); // get Id

            Console.WriteLine(employee);
            #endregion
        }
    }
}
