using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_21_PropsAndEvents
{
    internal class Lamp
    {
        private bool _active = false;
        
        public void Start(object next)
        {
            WriteLine(!_active ? "Lamp is not active" : "Lamp is active");
            
            // Lamp logic
        }
       
        // Lamp is activated when previous prop in sequence is finished, event raised
        public void Activate()
        {
            WriteLine("Lamp is now active");
            _active = true;
        }
    }
}