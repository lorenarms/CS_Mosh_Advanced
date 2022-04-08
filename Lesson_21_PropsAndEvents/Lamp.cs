using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_21_PropsAndEvents
{
    internal class Lamp
    {

        public event EventHandler<ClassPasser> LampFinished;
        private bool _finished = false;
        private bool _active = false;
        
        public void Start(ClassPasser cp)
        {
            WriteLine(!_active ? "Lamp is not active" : "Lamp is active");

            // Lamp logic

            if (!_finished && _active)
            {
                WriteLine("Did you finish the Lamp?");
                string userFinishedLamp = ReadLine();
                if (userFinishedLamp == "yes" || userFinishedLamp == "1")
                {
                    _finished = true;
                    LampFinished?.Invoke(this, cp);

                }
                else
                {
                    _finished = false;
                }

            }
            else if (_finished)
            {
                WriteLine("Lamp is finished already.");
            }

            
        }
       
        // Lamp is activated when previous prop in sequence is finished, event raised
        public void Activate()
        {
            WriteLine("Lamp is now active");
            _active = true;
        }
    }
}