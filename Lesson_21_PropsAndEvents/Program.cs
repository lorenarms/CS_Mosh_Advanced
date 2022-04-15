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
            // Instantiate objects of props
            Dresser d = new Dresser();
            Cabinet c = new Cabinet();
            Lamp l = new Lamp();
            Door dr = new Door();
            TreasureChest t = new TreasureChest();
            
            // Subscribe to events
            d.DresserFinished += DresserCompleted;
            c.CabinetFinished += CabinetCompleted;
            l.LampFinished += LampCompleted;
            dr.DoorFinished += DoorOpened;
            t.ChestOpen += Finished;

            // Activate first prop in sequence
            c.Activate();
            

            var userPropChoice = 0;

            // game loop
            while (userPropChoice != -999)
            {
                WriteLine("Which prop do you want to try?");
                Int32.TryParse(ReadLine(), out userPropChoice);

                
                // conditionals for which prop to play
                if (userPropChoice == 1)
                {
                    c.Start(new ClassPasser(d));
                }
                else if (userPropChoice == 2)
                {
                    d.Start(new ClassPasser(l));
                }
                else if (userPropChoice == 3)
                {
                    l.Start(new ClassPasser(dr));
                }
                else if (userPropChoice == 4)
                {
                    dr.Start(new ClassPasser(t));
                }
                else if (t.Active && dr.Active && userPropChoice == 5)
                {
                    t.Start(new ClassPasser(t));
                    userPropChoice = -999;
                }
            }

            Console.WriteLine("You finished!");

            ReadKey();
        }

        
        // each prop gets its own 'completed' event to start the next one
        private static void CabinetCompleted(object sender, ClassPasser cp)
        {
            Dresser d = (Dresser)cp.ClassToPass;
            d.Activate();
        }
      
        private static void DresserCompleted(object sender, ClassPasser cp)
        {
            Lamp l = (Lamp) cp.ClassToPass;
            l.Activate();
        }
        private static void LampCompleted(object sender, ClassPasser cp)
        {
            Door dr = (Door)cp.ClassToPass;
            dr.Activate();
        }

        private static void DoorOpened(object sender, ClassPasser cp)
        {
            TreasureChest t = (TreasureChest) cp.ClassToPass;
            t.Activate();
        }

        private static void Finished(object sender, ClassPasser cp)
        {
            WriteLine("You have finished the game!");

        }



    }
}
