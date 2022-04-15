using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_21_PropsAndEvents
{
    internal class Door
    {
        public event EventHandler<ClassPasser> DoorFinished;
        public bool Finished { get; } = false;
        public bool Active { get; private set; } = false;

        public void Start(ClassPasser cp)
        {
            WriteLine(Active ? "The Door is open" : "The Door is still locked! Solve the Lamp to unlock...");
            DoorFinished?.Invoke(this, cp);
            // door logic
        }

        public void Activate()
        {
            Console.WriteLine("Door is Open!");
            Active = true;
        }
    }
}
