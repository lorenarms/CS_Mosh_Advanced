using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_20_MoreEventsAndSubscribers
{
    internal class Props
    {
        public static event Action Activate;
        public static event Action Finish;


        public void PropActivated(string propName)
        {
            propName = propName.ToUpper();

            Activate?.Invoke();
        }

        public void PropFinished(string propName)
        {
            Finish?.Invoke();
        }


    }

    public class Dresser
    {
        public Dresser()
        {
            Props.Activate += DresserActivated;
            Props.Finish += DresserFinished;
        }

        public void DresserActivated()
        {
            
            WriteLine("Dresser is activated");
        }

        public void DresserFinished()
        {
            WriteLine("Dresser Finished");

        }
    }

    public class Cabinet
    {
        public Cabinet()
        {
            Props.Activate += CabinetActivated;
            Props.Finish += CabinetFinished;
        }
        public void CabinetActivated()
        {
            WriteLine("Cabinet is activated");
        }

        public void CabinetFinished()
        {
            WriteLine("Cabinet Finished");
        }
    }
}
