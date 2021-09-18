using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Runtime;


namespace Lesson_06_SortingMethods
{
    
    class Driver
    {
        static void Main(string[] args)
        {
            Stopwatch watch = null;
            Random randomNumber = null;
            Sorting sort = null;
            const double TICKS = TimeSpan.TicksPerMillisecond;

            try
            {
                watch = new Stopwatch();
                randomNumber = new Random();
                sort = new Sorting();

                int[] numbers = new int[10000];
                int NUMBERS_SIZE = numbers.Length - 1;

                Console.WriteLine("Creating new array...");
                for (int j = 0; j < 10000; j++)
                {
                    numbers[j] = randomNumber.Next(100, 999);
                }

                watch.Start();
                Sorting.MergeSort(numbers, 0, NUMBERS_SIZE);
                watch.Stop();

                var ts = watch.Elapsed;
                double ms = ts.Ticks / TICKS;
                
                Console.WriteLine("\nSorted Array via 'MergeSort'");
                Console.WriteLine("Time elapsed: " + ms + " milliseconds.");
                Console.WriteLine("{0} {1:0.000} {2}", "Time Elapsed: ", ms / 1000, " seconds.\n");

                Console.WriteLine("Creating new array...");
                for (int j = 0; j < 10000; j++)
                {
                    numbers[j] = randomNumber.Next(100, 999);
                    
                }

                watch.Start();
                Sorting.QuickSort(numbers, 0, NUMBERS_SIZE);
                watch.Stop();

                ts = watch.Elapsed;
                ms = ts.Ticks / TICKS;

                Console.WriteLine("\nSorted Array via 'QuickSort'");
                Console.WriteLine("Time elapsed: " + ms + " milliseconds.");
                Console.WriteLine("{0} {1:0.000} {2}", "Time Elapsed: ", ms / 1000, " seconds.");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                
            }
            
            
            Console.WriteLine("\nThis is working...");
            Console.ReadKey();

        }
    }
}
