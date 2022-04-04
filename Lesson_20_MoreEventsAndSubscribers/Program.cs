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
            var props = new Props();
            var dresser = new Dresser();
            var cabinet = new Cabinet();


            props.PropActivated("dresser");
            //props.PropActivated("Cabinet");



            ReadKey();
        }
    }
}
