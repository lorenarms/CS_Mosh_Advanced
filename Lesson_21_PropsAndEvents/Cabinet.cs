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
        public event EventHandler<object> CabinetFinished;
        private bool finished = false;

        public bool Start(object next)
        {
            WriteLine("Cabinet is Active");
            
            // check if cabinet is finished first
            if (finished)
            {
                WriteLine("You have finished this prop.");
                return finished;
            }

            // Cabinet logic
            
            Completed(next);
            return finished;
        }

        private void Completed(object next)
        {
            finished = true;
            CabinetFinished?.Invoke(this, next);
        }
    }
}
