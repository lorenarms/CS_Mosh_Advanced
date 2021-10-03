using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_HashTable_02
{
    class Driver
    {
        public static void Main(string[] args)
        {
            bool run = true;
            int selection;
            try
            {
                while (run)
                {
                    Console.WriteLine("Select a menu item:\n1: Create a table\n2: Add to the table\n3: Remove an item\n4: Print all items\n9: Exit");
                    int.TryParse(Console.ReadLine(), out selection);
                    switch (selection)
                    {
                        case 1:
                        {
                            Console.Clear();
                                Console.WriteLine("You wish to create a table.");
                                Console.ReadKey();
                                break;
                        }
                        case 2:
                        {
                            Console.Clear();
                                Console.WriteLine("You are adding an element.");
                                Console.ReadKey();
                                break;

                        }
                        case 3:
                        {
                            Console.Clear();
                                Console.WriteLine("Removing an element now...");
                                Console.ReadKey();
                                break;
                        }
                        case 4:
                        {
                            Console.Clear();
                                Console.WriteLine("Printing!");
                                Console.ReadKey();
                                break;

                        }
                        case 9:
                        {
                            Console.Clear();
                                Console.WriteLine("Exiting program, goodbye!");
                                Console.ReadKey();
                                run = false;
                            break;
                        }
                        case 888:
                        {
                            Console.Clear();
                            Console.WriteLine("SECRET MENU!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        default:

                        {
                            Console.Clear();
                            Console.WriteLine("That was most likely an invalid entry, please try again.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    }
                    





                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
                throw;
            }
            


            Console.WriteLine("Program end. Press any key to exit");
            Console.ReadKey();
        }
    }
}
