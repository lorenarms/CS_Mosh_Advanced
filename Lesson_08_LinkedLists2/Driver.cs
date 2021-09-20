using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_08_LinkedLists2
{
    public static class Constants
    {
        public static int DEFAULT_SIZE = 100;
    }
    public class Employee
    {
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public int _id { get; set; }

        public Employee()
        {
            _firstName = null;
            _lastName = null;
            _id = 100000;
        }

        public Employee(string fname, string lname, int id)
        {
            _firstName = fname;
            _lastName = lname;
            _id = id;
        }


    }

    public class HashTable
    {
        public List<IndexList> _empTable = new List<IndexList>();
        public class IndexList
        {
            public List<Employee> _empIndexTable;

            IndexList()
            {
                _empIndexTable = new List<Employee>(Constants.DEFAULT_SIZE);
            }
        }

        public HashTable()
        {
            _empTable = new List<IndexList>(Constants.DEFAULT_SIZE);
        }

        public int Hash(int key)
        {
            return key % Constants.DEFAULT_SIZE;
        }

        public void Insert(Employee emp)
        {
            //IndexList l;
            int index = Hash(emp._id);
            //Console.WriteLine("index: " + index);

            var l = _empTable.ElementAt(index);
            l._empIndexTable.Add(emp);
            
            //_empTable.ElementAt(index)._empIndexTable.Add(emp);
        }

        public void PrintAll()
        {
            IndexList l;
            for (int i = 0; i < Constants.DEFAULT_SIZE; i++)
            {
                l = _empTable.ElementAt(i);
                foreach(Employee e in l._empIndexTable)
                {
                    Console.WriteLine(e._id);
                }
            }
        }

    
    }



    class Driver
    {
        
        static void Main(string[] args)
        {
            Random randomNumber = null;
            randomNumber = new Random();

            HashTable EmployeeTable = new HashTable();

            for (int j = 0; j < 90; j++)
            {
                int id = randomNumber.Next(100000, 999999);

                var emp = new Employee("John", "Doe", id);
                
                EmployeeTable.Insert(emp);
            }
            Console.WriteLine("Employees added to hash table...");

            EmployeeTable.PrintAll();

            Console.ReadKey();

        }
    }
}
