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
        public bool Finished { get; private set; } = false;
        public bool Active { get; private set; } = false;

        public void Start(ClassPasser cp)
        {
            WriteLine(!Active ? "Lamp is not active" : "Lamp is active");

            // Lamp logic

            if (!Finished && Active)
            {
                WriteLine("Did you finish the Lamp?");
                string userFinishedLamp = ReadLine();
                if (userFinishedLamp == "yes" || userFinishedLamp == "1")
                {
                    Finished = true;
                    LampFinished?.Invoke(this, cp);

                }
                else
                {
                    Finished = false;
                }


            }
            else if (Finished)
            {
                WriteLine("Lamp is finished already.");
            }

            
        }
       
        // Lamp is activated when previous prop in sequence is finished, event raised
        public void Activate()
        {
            WriteLine("Lamp is now active");
            Active = true;
        }
    }
}