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
        public event EventHandler<ClassPasser> DresserFinished;
        private bool _finished = false;
        private bool _active = false;
        

        public bool Start(ClassPasser cp)
        {
            if (!_active)
            {
                WriteLine("Dresser is not active.");
                return false;
            }
            
            // check if prop is finished first
            if (_finished)
            {
                WriteLine("You have finished this prop.");
                return _finished;
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
                    // event trigger
                    _finished = true;
                    DresserFinished?.Invoke(this, cp);

                    return true;
                }

                WriteLine("That code is incorrect, try again!");
                ReadKey();
                Clear();

            }

            return false;
        }

        public void Activate()
        {
            WriteLine("Dresser is now active");
            _active = true;
        }


    }
}
