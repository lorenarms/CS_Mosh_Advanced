using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_20_MoreEventsAndSubscribers
{
    public class Dresser
    {
        public event EventHandler<object> DresserFinished;

        public void Start(object next)
        {
            WriteLine("Dresser is Active");

            // Dresser game logic
            

            Completed(next);
        }

        private void Completed(Object o)
        {
            DresserFinished?.Invoke(this, o);
        }
    }
}
