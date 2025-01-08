namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
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



        }
    }
}
