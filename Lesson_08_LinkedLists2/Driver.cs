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
        public int _id { get; set; }

        public Employee()
        {
           _id = 100000;
        }

        public Employee(int id)
        {
            _id = id;
        }


    }

    public class IndexList
    {
        public List<Employee> empList;

        IndexList()
        {
            empList = new List<Employee>();
        }
    }

    public class HashTable
    {
        public List<IndexList> empTable = new List<IndexList>(Constants.DEFAULT_SIZE);
        

        public HashTable()
        {
            empTable = new List<IndexList>();
           
            
            
        }

        public int Hash(int key)
        {
            return key % Constants.DEFAULT_SIZE;
        }

        public void Insert(Employee emp)
        {
            int index = Hash(emp._id);
            
            empTable[index].empList.Add(emp);
        }

        public void PrintAll()
        {
            IndexList l;
            for (int i = 0; i < Constants.DEFAULT_SIZE; i++)
            {
                foreach(Employee e in empTable[i].empList)
                {
                    Console.WriteLine("ID: " + e._id);
                }
            }
        }

    
    }



    class Driver
    {
        
        static void Main(string[] args)
        {
            Hash hash = new Hash();
            while (true)
            {
                string line = Console.ReadLine();
                char command = line[0];
                string argument = line.Substring(1);
                int.TryParse(argument, out int employeeNum);
                switch (command)
                {
                    case '+':
                        hash.add(employeeNum);
                        break;
                    case '-':
                        hash.remove(employeeNum);
                        break;
                    case '?':
                        Console.WriteLine(hash.contains(employeeNum) ? "YES" : "NO");
                        break;
                    case '#':
                        Console.WriteLine(hash.count);
                        break;
                    case 'Q':
                        return;
                }
            }

        }
    }
}
