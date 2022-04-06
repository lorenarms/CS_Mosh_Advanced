using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Lesson_21_PropsAndEvents
{
    internal class Dresser
    {
        public event EventHandler<object> DresserFinished;
        public bool finished = false;

        public bool Start(object nextProp)
        {
            WriteLine("Dresser is Activated");

            // check if prop is finished first
            if (finished)
            {
                WriteLine("You have finished this prop.");
                return finished;
            }

            // Dresser game logic
            
            var userInputCode = -999;

            while (userInputCode != 999)
            {
                WriteLine("Input the code for the dresser...");
                var userInputString = ReadLine();
                int.TryParse(userInputString, out userInputCode);

                
                if (userInputCode == 1234)
                {
                    Completed(nextProp);
                    return true;
                }

                WriteLine("That code is incorrect, try again!");
                ReadKey();
                Clear();

            }

            return false;
        }

        private void Completed(Object nextProp)
        {
            finished = true;
            DresserFinished?.Invoke(this, nextProp);
        }
    }
}
