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

            myTable[2] += "17";

            ICollection Key = myTable.Keys;



            foreach (var val in Key)
            {
                Console.WriteLine(val + " : " + myTable[val]);
            }

            myTable.Add(5, "Fifth");
            myTable.Add(6, 17);

            myTable[6] = 17;

            Console.WriteLine();

            foreach (var val in Key)
            {
                Console.WriteLine(val + " : " + myTable[val]);
            }

            Console.WriteLine();


            Console.WriteLine("Key and Value pairs from the hash table:");

            foreach (DictionaryEntry e in myTable)
            {
                Console.WriteLine("{0} and {1} ", e.Key, e.Value);
            }

            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            var cities = new Hashtable()
            {
                {"UK", "London, Manchester, Birmingham" },
                {"USA", "Chicago, New York, Washington" },
                {"India", "Mumbai, New Delhi, Pune" }
            };

            string citiesOfUSA = (string)cities["USA"];

            Console.WriteLine(citiesOfUSA);

            cities["USA"] += " Los Angeles, Boston";
            

            citiesOfUSA = (string)cities["USA"];

            Console.WriteLine(citiesOfUSA);


            Console.ReadKey();

        }

    }
}
