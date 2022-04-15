using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_21_PropsAndEvents
{
    internal class TreasureChest
    {
        public event EventHandler<ClassPasser> ChestOpen;
        public bool Open { get; private set; } = false;
        public bool Active { get; private set; } = false;

        public void Activate()
        {
            Active = true;
            WriteLine("The treasure chest is now activated!");
            

        }

        public void Start(ClassPasser cp)
        {
            WriteLine("The chest is open! You win the treasure!");
            ChestOpen?.Invoke(this, cp);
        }

    }
}
