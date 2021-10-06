using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_10_HashTable_02
{
    class TableApp
    {
        public void Start()
        {
            
            String[] options = { "Create a table", "Add to the table", "Remove an item", "Print all items", "Exit" };
            
            var table = new Hashtable();
            table = null;
            ICollection keys = null;
            bool run = true;
            var newMenu = new Menu(options, 1, 1, 0);
            //newMenu.ModifyMenuLeftJustified(options);
            newMenu.ModifyMenuCentered(options);
            newMenu.CenterMenuToConsole();
            
            try
            {
                while (run)
                {
                    Clear();
                    int selection = newMenu.RunMenu();
                    switch (selection)
                    {
                        case 1:
                        {
                            Console.Clear();
                            if (table == null)
                            {
                                table = new Hashtable();
                                keys = table.Keys;
                                    Console.WriteLine("A new table has been created!");
                            }
                            else
                            {
                                Console.WriteLine("A table already exists.");
                            }
                            Console.ReadKey();
                            break;
                        }
                        case 2:
                        {
                            if (table == null)
                            {
                                Clear();
                                Console.WriteLine("Please create a table first.");
                                ReadKey();
                                Clear();
                                break;
                            }
                            else
                            {
                                AddElement(table);
                            }

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
                                if (table != null)
                                {
                                    foreach(DictionaryEntry e in table)
                                    {
                                        var emp = (Employee) e.Value;
                                        int thisId = emp.GetID();
                                        string thisName = emp.GetName();
                                        Console.WriteLine(thisId + " - " + thisName);
                                        
                                    }
                                }
                                
                                Console.ReadKey();
                                break;

                        }
                        case 5:
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
                        case 0:
                        {
                            Environment.Exit(0);
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
            
        }

        public static void AddElement(Hashtable table)
        {
            int newId = 0;
            string fullName = null;
            //int day, month, year;
            DateTime birthDateTime;
            bool add = true;
            while (add)
            {
                Console.Clear();
                Console.Write("Enter the employee's first and\nlast name, separated by a space: ");
                fullName = Console.ReadLine();
                while (!fullName.Contains(' '))
                {
                    Console.Write("\nYou entered: " + fullName + ". Please check that you included " +
                                      "the\nfirst name, a space, and the last name: ");
                    fullName = Console.ReadLine();
                }
                Random rand = new Random();
                newId = rand.Next(100, 999);
                while (table.ContainsKey(newId))
                {
                    newId = rand.Next(100, 999);
                }

                string s = ReadLine();
                while (TryParse(s, out int day))
                {

                }

                //Console.WriteLine("Enter the employee's Birth day as DD: ");
                //day = int.TryParse(Console.ReadLine());

                //birthDateTime.

                Console.WriteLine("The new employee is " + fullName);
                Console.WriteLine("Their employee ID will be: " + newId);
                Console.WriteLine("Is this correct? y/n ");
                string selection = Console.ReadLine();
                if (selection == "y")
                {
                    add = false;
                }
                

            }

            Employee newEmployee = new Employee(newId, fullName);
            table.Add(newId, newEmployee);
        }
    }
}
