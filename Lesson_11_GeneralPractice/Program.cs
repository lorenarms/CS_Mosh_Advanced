using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Lesson_11_GeneralPractice.Libraries;
using static System.Console;
using static Lesson_11_GeneralPractice.Libraries.Delegates;

namespace Lesson_11_GeneralPractice
{
    class Program
    {
        public void Start()
        {
            var tesla = new FourWheeled(4, true, 45000, "Model S", "Sedan", "Car");
            
            
            tesla.PrintVehicle();
            tesla.ShowVehiclePrice(CalculateVehicleTax, tesla);
            tesla.ShowVehiclePrice(CalculateVehicleWithDiscount, tesla);

            
            

            try
            {

                Console.WriteLine("Input a number: ");
                var str = Console.ReadLine();
                int num = str.ParseStringToInt();
                while ( num == -999)
                {
                    Console.WriteLine("That is not a valid entry");
                    str = Console.ReadLine();
                    num = str.ParseStringToInt();
                }

                Console.WriteLine($"Your number times itself is {num * num}.");

                double dub = str.ParseStringToDouble();
                Console.WriteLine($"Your number x 3.75 is {dub * 3.750:F3}.");

            }
            
            catch (FormatException ex)
            {
                Console.WriteLine("Improper input exception");
                
            }
            
            Write("Press 'Enter' to Exit.");
            
            ReadKey();
            Environment.Exit(0);
        }


        

        

        

    }
}
