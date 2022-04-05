using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_20_MoreEventsAndSubscribers
{
    public class Cabinet
    {
        public event EventHandler<object> CabinetFinished;  // passes an object (the next prop in sequence)

        public void Start(object next)  // takes in object (next prop) can take more objects if necessary
        {
            WriteLine("Cabinet is Active");

            // Cabinet game logic

            WriteLine("Name the Cabinet: ");
            string s = ReadLine();

            // end Cabinet game logic

            Completed(next);    // call method, pass the next prop object
        }

        private void Completed(Object o)
        {
            CabinetFinished?.Invoke(this, o);   // invoke the event, pass the object
        }
    }
}
