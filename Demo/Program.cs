using Demo.Encapsulation;
using Demo.Inheritance;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation

            //Employee employee = new Employee(1001, "Ahmed Nasr", 10_000);

            //employee.SetId(2002); //Set ID

            //employee.Name = "Ibrahim Ali";
            //Console.WriteLine(employee.Name);
            //Console.WriteLine(employee.GetId()); // get Id

            //Console.WriteLine(employee);
            #endregion

            #region Indexer
            //PhoneBook note = new PhoneBook(10);
            //note.AddPerson(0, "Ahmed", 111);
            //note.AddPerson(1, "Nadia", 222);
            //note.AddPerson(2, "Osama", 333);

            //note.SetNumber("Ahmed", 999);
            //Console.WriteLine(note.GetPersonNumber("Ahmed"));

            //for (int i = 0; i < note.Size; i++)
            //{
            //    Console.WriteLine(note[i]);
            //}
            //Console.WriteLine(note.ToString());
            #endregion
            #region Class

            //Car C1;
            //// Declare for Reference of type "Car"
            //// this Reference 'C1' can Refer an object of type "Car" or of another type "Inheriting from Car"
            //// or another type
            //// CLR will allocate Uninitialized bytes in stack for the Reference
            //// CLR will allocates 0 bytes in heap

            //C1 = new Car(10102, "Nissan Sentra 2025", 180);

            //C1 = new Car(3333, "KIA");

            //Console.WriteLine(C1);
            #endregion

            #region OOP Pillars 2. Inheritance [is a relationship]

            //Parent parent = new Parent(1, 2);
            //parent.X = 11;
            //parent.Y = 22;
            //Console.WriteLine(parent);
            //Console.WriteLine($" Product = {parent.product()}");


            //Child c = new Child(1, 2, 3);
            //c.X = 11;
            //c.Y = 22;
            //c.Z = 33;

            //Console.WriteLine(c.ToString());
            #endregion
        }
    }
}
