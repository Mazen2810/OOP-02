using Demo.Encapsulation;

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
        }
    }
}
