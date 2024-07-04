using Person ;
using Point1;
namespace Assigment6C_
{
    enum WeekDays
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    [Flags]
    enum Permissions
    {
        Read = 1,
        write = 2,
        Delete = 4,
        Execute = 8
    }
    enum Colors
    {
        Red, 
        Green,
        Blue
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            #region WeekDays
            //Console.WriteLine("Week Dayes : ");
            //for (int i = 0; i < 7; i++)
            //{
            //    WeekDays Day = (WeekDays)i;
            //    Console.WriteLine(Day.ToString());
            //} 
            #endregion

            #region Person 
            //person[] persons = new person[3];
            //for (int i = 0; i < persons.Length;)
            //{
            //    Console.WriteLine($"Enter The Data Of {i + 1} Person ");
            //    Console.Write($"\tEnter The name : ");

            //    string? name = Console.ReadLine();
            //    if(name is not null)
            //    {
            //        Console.Write($"\tEnter The Age : ");
            //        bool flag = int.TryParse(Console.ReadLine(),out int age);
            //        if (flag)
            //        {
            //            persons[i] = new person(name, age);
            //            i++;
            //        }

            //    }
            //}
            //Console.WriteLine($"  The Data Of Persons");

            //for (int i = 0; i < persons.Length; i ++)
            //{
            //    Console.WriteLine(persons[i]);
            //}
            #endregion

            #region Season
            //Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter):");
            //string? input = Console.ReadLine();
            //if (input is not null)
            //{
            //    if (Enum.TryParse(input, false, out Season season))
            //    {
            //        switch (season)
            //        {
            //            case Season.Spring:
            //                Console.WriteLine("Spring: March to May");
            //                break;
            //            case Season.Summer:
            //                Console.WriteLine("Summer: June to August");
            //                break;
            //            case Season.Autumn:
            //                Console.WriteLine("Autumn: September to November");
            //                break;
            //            case Season.Winter:
            //                Console.WriteLine("Winter: December to February");
            //                break;
            //            default:
            //                Console.WriteLine("Invalid season entered.");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid season entered.");
            //    }
            //}

            #endregion
            
            #region Permissions
            //Permissions MyPermissions = Permissions.Read;

            //MyPermissions |= Permissions.Delete; // add delete permission
            //Console.WriteLine(MyPermissions); // Read , Delete
            //// Check 
            //if ((MyPermissions & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("You Have Delete Permission");
            //}
            //else
            //{
            //    Console.WriteLine("You Have not Delete Permission");
            //}
            //// Delete  Permission
            //MyPermissions &= ~Permissions.Delete;
            //Console.WriteLine(MyPermissions); 
            #endregion
            
            #region Colors
            //string? Color = Console.ReadLine();
            //if (Color is not null)
            //{
            //    if (Enum.TryParse(Color, true, out Colors result))
            //    {
            //        if (result == Colors.Red || result == Colors.Green || result == Colors.Blue)
            //        {
            //            Console.WriteLine($"{result} primary color ");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{result} not  primary color ");
            //        }
            //    }
            //} 
            #endregion
            
            #region Points
            //Point p1 = new Point(1, 2);
            //Point p2 = new Point(2, 2);
            //Console.WriteLine(p1.distance(p2)); 
            #endregion
            
            #region Max Age Person
            //    person[] persons = new person[3];
            //    for (int i = 0; i < persons.Length;)
            //    {
            //        Console.WriteLine($"Enter The Data Of {i + 1} Person ");
            //        Console.Write($"\tEnter The name : ");

            //        string? name = Console.ReadLine();
            //        if (name is not null)
            //        {
            //            Console.Write($"\tEnter The Age : ");
            //            bool flag = int.TryParse(Console.ReadLine(), out int age);
            //            if (flag)
            //            {
            //                persons[i] = new person(name, age);
            //                i++;
            //            }

            //        }
            //    }
            //    Console.WriteLine($" The Max Age  Of Persons is :");
            //    person maxage = new person("", -100000);
            //    for (int i = 0; i < persons.Length; i++)
            //    {
            //        if (persons[i].Age > maxage.Age)
            //        {
            //            maxage = persons[i];
            //        }
            //    }

            //    Console.WriteLine(maxage);

            #endregion

        }
    }
}