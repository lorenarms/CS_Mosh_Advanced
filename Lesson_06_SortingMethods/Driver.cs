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
            Stopwatch watch = new Stopwatch();
            Random rnd = new Random();
            int[] numbers = new int[10000];
            int NUMBERS_SIZE = numbers.Length - 1;

            for (int j = 0; j < 10000; j++)
            {
                numbers[j] = rnd.Next(100, 999);
                //Console.WriteLine(rnd.Next(100, 999));
            }


            double ticks = TimeSpan.TicksPerMillisecond;

            
            var sort = new Sorting();

            //Console.WriteLine("Original Array");
            //foreach (int n in numbers)
            //{
            //    Console.Write(n + " ");
            //}

            watch.Start();
            Sorting.MergeSort(numbers, 0, NUMBERS_SIZE);
            watch.Stop();

            TimeSpan ts = watch.Elapsed;

            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //ts.Hours, ts.Minutes, ts.Seconds,
            //ts.Milliseconds / 10);
            
            double ms = ts.Ticks / ticks;

            Console.WriteLine("\nSorted Array");
            //foreach (int n in numbers)
            //{
            //    Console.Write(n + " ");
            //}
            Console.WriteLine("Time elapsed: " + ms + " milliseconds.");
            Console.WriteLine("{0} {1:0.00} {2}", "Time Elapsed: ", ms / 1000, " seconds.");


            Console.WriteLine("\nThis is working...");
            Console.ReadKey();

            ///
            ///
            ///





        }
    }
}
