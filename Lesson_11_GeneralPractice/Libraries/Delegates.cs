using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_GeneralPractice.Libraries
{
    class Delegates
    {
        private const double Tax = 0.15;
        private const double Discount = 0.05;

        public static void CalculateVehicleTax(Vehicle vehicle)
        {
            double costWithTax = 0;
            costWithTax = (vehicle.GetCost() * Tax) + vehicle.GetCost();
            Console.WriteLine($"The total cost of a {vehicle.GetName()} is {costWithTax:C2}.");
        }

        public static void CalculateVehicleWithDiscount(Vehicle vehicle)
        {
            double costWithTax = (vehicle.GetCost() * Tax) + vehicle.GetCost();
            double costWithDiscount = costWithTax - (vehicle.GetCost() * Discount);
            Console.WriteLine($"The cost of a {vehicle.GetName()} with a discount of 5% is {costWithDiscount:C2}.");
        }



    }
}
