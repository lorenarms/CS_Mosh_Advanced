using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_21_PropsAndEvents
{
    internal class Door
    {
        public event EventHandler<ClassPasser> DoorFinished;
        private bool _finished = false;
        private bool _active = false;

        public void Start(ClassPasser cp)
        {
            // door logic
        }

        public void Activate()
        {
            Console.WriteLine("Door is Open!");
            _active = true;
        }
    }
}
