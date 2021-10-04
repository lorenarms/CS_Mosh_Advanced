using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_HashTable_02
{
    class Employee
    {
        private int _id;
        private string _firstName { get; set; }
        private string _lastName { get; set; }

        public Employee()
        {

        }
        public Employee(int id, string name)
        {
            this._id = id;
            string[] s = name.Split(' ');
            _firstName = s[0];
            _lastName = s[1];
            Console.WriteLine("The new employee has been created!\n" + _lastName + ", " + _firstName);
        }
        public int GetID()
        {
            return this._id;
        }
        public string GetName()
        {
            return this._firstName + " " + this._lastName;
        }
    }

    class Driver
    {
        public static void Main(string[] args)
        {
            var table = new Hashtable();
            table = null;
            ICollection keys = null;
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
                            Console.Clear();
                                Console.WriteLine("You are adding an element.");
                                AddElement(table);
                                //Console.ReadKey();
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
            


            //Console.WriteLine("Program end. Press any key to exit");
            Console.ReadKey();
        }

        public static void AddElement(Hashtable table)
        {
            int newId = 0;
            string fullName = null;
            bool add = true;
            while (add)
            {
                Console.Clear();
                Console.Write("\nEnter the employee's first and\nlast name, separated by a space: ");
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
