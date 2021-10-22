using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Lesson_12_GeneralPractice.Libraries;

namespace Lesson_12_GeneralPractice.Objects
{
    class Vehicle
    {
        private int _numDoors;
        private double _cost;
        private string _brand;

        private IModifier _modifier;

        public Vehicle()
        {

        }

        public Vehicle(int numDoors, double cost, string brand, IModifier modifier)
        {
            _numDoors = numDoors;
            _cost = cost;
            _brand = brand;
            _modifier = modifier;

        }

        public int GetDoors()
        {
            return _numDoors;
        }

        public void ModifyDoors()
        {
            Console.WriteLine("Do you want to add or remove doors?");
            string option = Console.ReadLine()?.ToLower();

            while ((!option.Contains("add") && !option.Contains("rem")))
            {
                Console.WriteLine("That is not a valid option");
                option = Console.ReadLine();
            }

            if (option.Contains("add"))
            {
                Console.WriteLine("How many doors would you like to add? ");
                int doorsToAdd;
                string str = Console.ReadLine();
                while (!int.TryParse(str, out doorsToAdd))
                {
                    Console.WriteLine("That is not valid, enter a number. ");
                    str = Console.ReadLine();
                }

                _numDoors += _modifier.AddFeature(doorsToAdd);

            }
            else if (option.Contains("rem"))
            {
                Console.WriteLine("How many doors would you like to remove? ");
                int doorsToRem;
                string str = Console.ReadLine();
                while (!int.TryParse(str, out doorsToRem))
                {
                    Console.WriteLine("That is not valid, enter a number. ");
                    str = Console.ReadLine();
                    
                }

                if (doorsToRem > _numDoors)
                {
                    Console.WriteLine("There aren't that many doors to remove.");

                }
                else
                {
                    _numDoors += _modifier.RemoveFeature(doorsToRem);
                }

                

            }


            
        }





    }
}
