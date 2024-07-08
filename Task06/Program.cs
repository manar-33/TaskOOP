using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Channels;
using System.Xml.Schema;

namespace OOP01
{
    //enum WeekDays : int
    //{
    //    mon, tue, wed, thur, fri, sat, sun
    //}
    //enum Season
    //{ Spring, Summer, Autumn, Winter }
    //enum Colors
    //{ Red ,
    //     Green ,
    //     Blue
    //}


    //public class Employee
    //{
    //   public string name;
    //    int age;
    //   public Permissions permissions;
    //}
   
    //[Flags]
    //public enum Permissions : byte
    //{
    //    Delete = 1,
    //    Execute = 2,
    //    Read = 4,
    //    Write = 8
    //}
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //for (int i = 0; i < 7; i++)
            //{
            //   // WeekDays wd = WeekDays.mon;
            //    WeekDays wd = (WeekDays)i;

            //    Console.WriteLine(wd);
            //}
            #endregion
            #region Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //        int M;
            //        bool flag;

            //        do
            //        {
            //            Console.WriteLine("please enter the month");
            //            flag = int.TryParse(Console.ReadLine(), out M);

            //        }while (!flag);
            //        switch (M)
            //{ 
            //    case 12: 
            //    case 1: 
            //    case 2: 
            //        Console.WriteLine("Winter"); 
            //        break; 
            //    case 3: 
            //    case 4: 
            //    case 5: 
            //        Console.WriteLine("Spring"); 
            //        break; 
            //    case 6: 
            //    case 7: 
            //    case 8: 
            //        Console.WriteLine("Summer"); 
            //        break; 
            //    case 9: 
            //    case 10: 
            //    case 11: 
            //        Console.WriteLine("Autumn"); 
            //        break; 
            //    default: 

            //        Console.WriteLine("Invalid Month number"); 
            //        break; 
            //} 
            #endregion
            #region  Create an enum called "Colors" with the basic colors(Red, Green, Blue) as its members.Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            // bool flag = Enum.TryParse<Colors>(Colors, true, out Colors colors);

            //Console.WriteLine("Please enter color");
            //string color = Console.ReadLine();
            //if (color == "Red" || color == "Green" || color == "Blue")
            //{
            //    Console.WriteLine("Primary Color");
            //}
            //else
            //{
            //    Console.WriteLine("It is not a Primary Color");
            //}
            #endregion
            #region Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.  Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

            //Employee employee = new Employee();
            //employee.permissions = (Permissions)5;
            //Console.WriteLine(employee.permissions);
            //if ((employee.permissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("Read is existed");
            //}
            //else { Console.WriteLine("Read is not existed"); }



            #endregion
            #region Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
         
            //Points P1;
            //P1 = new Points(5,7);
            //Points P2;
            //P2= new Points(3,4);
            //decimal Distance;
            //Distance = ((P2.X - P1.X) * (P2.X - P1.X)) + ((P2.Y - P1.Y) * (P2.Y - P1.Y));
            //Console.WriteLine(Distance);

            #endregion
        }
    }
}
