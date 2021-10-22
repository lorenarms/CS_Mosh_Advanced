using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_GeneralPractice
{
    class FourWheeled : Vehicle
    {
        private string _class;

        public FourWheeled(int d, bool e, double c, string n, string t, string cl) : base(d, e, c, n, t, new ChangeDoors(), new ModifyVehicleCost())
        {
            _class = cl;
        }

        public string ToString()
        {
            //return "This " + _class + " has " + this.NumDoors + " and costs " + this.Cost;
            return $"This {_class} is a {this.GetName()}, has {this.GetNumDoors()} doors and costs {this.GetCost():C2}";
        }

        public void PrintVehicle()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
