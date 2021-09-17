using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_07_HashTable
{
    
    class Driver
    {
        
        static void Main(string[] args)
        {
            Hashtable myTable = new Hashtable();

            int j = 1;
            myTable.Add(j, "First");
            j++;
            myTable.Add(j, "Second");
            myTable.Add(3, "Third");
            object i = 4;
            myTable.Add(i, "Fourth");
            
            //myTable.Add(i, "Fifth");

            Console.WriteLine("Key and Value pairs from the hash table:");

            foreach(DictionaryEntry e in myTable)
            {
                Console.WriteLine("{0} and {1} ", e.Key, e.Value);
            }

            Console.ReadKey();

        }

    }
}
