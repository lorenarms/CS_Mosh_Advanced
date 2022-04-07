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
        private bool _finished = false;


        public bool Start(ClassPasser cp)
        {

            WriteLine("Cabinet is Active");
            
            // check if cabinet is finished first
            if (_finished)
            {
                WriteLine("You have finished this prop.");
                return _finished;
            }

            // Cabinet logic

            _finished = true;
            CabinetFinished?.Invoke(this, cp);

            return _finished;
        }

       
    }
}
