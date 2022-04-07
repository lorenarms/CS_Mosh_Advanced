using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            Lamp l = new Lamp();
            

            d.DresserFinished += DresserCompleted;
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
                    d.Start(l);
                }
                else if (userPropChoice == 3)
                {
                    l.Start(0);
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

        // each prop gets its own 'completed' event to start the next one
        private static void DresserCompleted(object sender, Lamp l)
        {
            l.Activate();
        }

    }
}
