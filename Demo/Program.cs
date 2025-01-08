namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region Q1: Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] person = new Person[3];
            //person[0] = new Person("Mazen", 26);
            //person[1] = new Person("Mohamed", 22);
            //person[2] = new Person("Mohamed", 21);

            //for (int i = 0; i < person.Length; i++)
            //{
            //    Console.WriteLine(person[i].ToString());
            //}
            #endregion


            #region Q2: Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Point P1 = new Point(GetCoordinates("Enter X-Coordinate for the First Point: "),GetCoordinates("Enter Y-Coordinate for the First Point: "));
            //Point P2 = new Point(GetCoordinates("Enter X-Coordinate for the Second Point: "), GetCoordinates("Enter Y-Coordinate for the Second Point: "));
            //double Distance = P1.Distance(P2);
            //Console.WriteLine($"The Distance between First Point and Second Point = {Distance}");


            //static double GetCoordinates(string message)
            //{
            //    double value;
            //    bool flag;
            //    do
            //    {
            //        Console.Write(message);
            //        flag = double.TryParse(Console.ReadLine(), out value);
            //    }while (!flag);
            //    return value;
            //}
            #endregion

            #region Q3: Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person[] person = new Person[3];

            //person[0] = new Person(GetName("Enter the Name of the first person:"), GetAge("Enter The Age of the First Person"));


            //person[1] = new Person(GetName("Enter the Name of the Second person:"), GetAge("Enter The Age of the Second Person"));

            //person[2] = new Person(GetName("Enter the Name of the Third person:"), GetAge("Enter The Age of the Third Person"));


            //Person OldPerson = person[0];

            //foreach(Person p in person)
            //{
            //    if(p.Age > OldPerson.Age)
            //        OldPerson = p;
            //}

            //Console.WriteLine($"The Oldest Person is {OldPerson.Name}, and his Age is {OldPerson.Age}");

            //static string GetName(string msg)
            //{
            //    string? Name;
            //    do
            //    {
            //        Console.WriteLine(msg);
            //        Name = Console.ReadLine();
            //    } while (Name is null);

            //    return Name;
            //}

            //static int GetAge(string msg)
            //{
            //    int Age;
            //    bool flag;

            //    do
            //    {
            //        Console.WriteLine(msg);
            //        flag = int.TryParse(Console.ReadLine(), out Age);
            //    } while (!flag);

            //    return Age;
            //}
            #endregion


            #endregion


            #region Part 02

            #region Q1: Design and implement a Class for the employees in a company
            //Employee emp01 = new Employee(100,"Mazen", SecurityLevel.Developer, 10_000,new DateTime(2025,01,01),Gender.M);


            //Console.WriteLine(emp01);
            #endregion

            #region Q3: Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)

            //Employee[] EmpArr = new Employee[3];
            //EmpArr[0] = new Employee(100, "Mazen", SecurityLevel.DBA, 10_000, new DateTime(2024, 11, 28), Gender.M);
            //EmpArr[1] = new Employee(200, "Mohamed", SecurityLevel.guest, 14_000, new DateTime(2023, 01, 28), Gender.M);
            //EmpArr[2] = new Employee(300, "Marwa", SecurityLevel.securityOfficer, 18_000, new DateTime(2024, 5, 24), Gender.F);


            //foreach (Employee emp in EmpArr)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

            #region Q4:  Sort the employees based on their hire date then Print the sorted array.
            //Employee[] EmpArr = new Employee[3];
            //EmpArr[0] = new Employee(100, "Mazen", SecurityLevel.DBA, 10_000, new DateTime(2024, 11, 28), Gender.M);
            //EmpArr[1] = new Employee(200, "Mohamed", SecurityLevel.guest, 14_000, new DateTime(2023, 01, 28), Gender.M);
            //EmpArr[2] = new Employee(300, "Marwa", SecurityLevel.securityOfficer, 18_000, new DateTime(2024, 5, 24), Gender.F);


            //for (int i = 0; i < EmpArr.Length - 1; i++)
            //{
            //    for (int j = 0; j < EmpArr.Length - 1 - i; j++)
            //    {
            //        if (EmpArr[j].HiringDate > EmpArr[j + 1].HiringDate)
            //        {
            //           Employee temp = EmpArr[j];
            //            EmpArr[j] = EmpArr[j + 1];
            //            EmpArr[j + 1] = temp;

            //        }

            //    }

                
            //}

            //foreach (Employee emp in EmpArr)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion
            #endregion
        }
    }

}
