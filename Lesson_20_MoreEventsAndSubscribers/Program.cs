using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_20_MoreEventsAndSubscribers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // These are the props that exist in the game
            Cabinet c = new Cabinet();
            Dresser d = new Dresser();

            // Each prop is subscribed to the PropCompleted event
            c.CabinetFinished += PropCompleted;
            d.DresserFinished += PropCompleted;

            // Start the sequence
            c.Start(d);         // pass object of the next prop in sequence
            d.Start(0);    // pass '0' for the last prop
            
            ReadKey();
        }

        public static void PropCompleted(object sender, object obj)
        {
            string s = sender.ToString();
            string o = obj.ToString();

            // check if the obj passed is '0' which means the game is finished
            var finished = obj.Equals(0) ? o = "FINISHED" : o;

            WriteLine($"{s} Completed, {o} Starting up");
        }
    }
}
