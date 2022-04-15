using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Lesson_21_PropsAndEvents
{
    internal class Cabinet
    {
        public event EventHandler<ClassPasser> CabinetFinished;
        public bool Finished { get; private set; } = false;
        public bool Active { get; private set; } = false;

        public bool Start(ClassPasser cp)
        {

            WriteLine("Cabinet is Active");
            
            // check if cabinet is finished first
            if (Finished)
            {
                WriteLine("You have finished this prop.");
                return Finished;
            }

            // Cabinet logic

            Finished = true;
            CabinetFinished?.Invoke(this, cp);

            return Finished;
        }

        public void Activate()
        {
            Active = true;
            WriteLine("Cabinet is now Active!");
        }

       
    }
}
