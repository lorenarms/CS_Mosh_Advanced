using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Lesson_12_GeneralPractice.Libraries;
using Lesson_12_GeneralPractice.Objects;
using static System.Console;

namespace Lesson_12_GeneralPractice
{
    class Program
    {
        public void Start()
        {

            string[] names = { "Lawrence", "Angie", "Trinity", "Sofia" };
            int num = 0;

            // loop try-catch block
            while (num != 999)
            {
                try
                {
                    //var tesla = new Vehicle(2, 45000, "Tesla", new Doors());

                    //tesla.ModifyDoors();

                    //Console.WriteLine($"The number of doors is now {tesla.GetDoors()}.");


                    // nullable types
                    Nullable<DateTime> date = null;
                    DateTime? dateTwo = null;

                    Console.WriteLine(date.GetValueOrDefault());
                    Console.WriteLine(date.HasValue);
                    // Console.WriteLine(date.Value);


                    // parse string to integer
                    string str = Console.ReadLine();
                    int.TryParse(str, out num);

                    Console.WriteLine(names[num]);


                }

                // exception when index is out of bounds in array
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("That index does not exist");
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("The object is null and a value cannot be displayed");
                    // throw new Exception("New Exception was thrown");
                }
            }


            WriteLine("Press 'Enter' to Exit.");
            ReadKey();
            Environment.Exit(0);
        }
    }
}
