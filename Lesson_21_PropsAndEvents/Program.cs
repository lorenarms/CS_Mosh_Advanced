using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Lesson_21_PropsAndEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dresser d = new Dresser();
            Cabinet c = new Cabinet();

            d.DresserFinished += PropCompleted;
            c.CabinetFinished += PropCompleted;


            var userPropChoice = 0;

            // game loop
            while (userPropChoice != -999)
            {
                WriteLine("Which prop do you want to try?");
                Int32.TryParse(ReadLine(), out userPropChoice);
                
                // conditionals for which prop to play
                if (userPropChoice == 1)
                {
                    c.Start(d);
                }
                else if (userPropChoice == 2)
                {
                    d.Start(0);
                }
            }

            Console.WriteLine("You finished!");

            ReadKey();
        }

        public static void PropCompleted(object sender, object next)
        {
            string s = sender.ToString();
            string n = next.ToString();

            var finished = next.Equals(0) ? n = "FINISHED" : n;

            WriteLine($"{s} Completed, {n} Activated");
        }
    }
}
