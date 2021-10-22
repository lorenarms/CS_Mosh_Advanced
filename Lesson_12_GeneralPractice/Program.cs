using System;
using System.Collections.Generic;
using System.Linq;
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
            var tesla = new Vehicle(2, 45000, "Tesla", new Doors());

            tesla.ModifyDoors();

            Console.WriteLine($"The number of doors is now {tesla.GetDoors()}.");
            


            WriteLine("Press 'Enter' to Exit.");
            ReadKey();
            Environment.Exit(0);
        }
    }
}
