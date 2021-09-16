using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_SortingMethods
{
    class Sorting
    {
       public static int Partition(int[] numbers, int i, int k)
        {
            int l = 0;
            int h = 0;
            int midPoint = 0;
            int pivot = 0;
            int temp = 0;
            bool done = false;

            midPoint = i + (k - i) / 2;
            pivot = numbers[midPoint];
            l = i;
            h = k;
            while (!done)
            {
                while(numbers[l] < pivot)
                {
                    ++l;
                }
                while(pivot < numbers[h])
                {
                    --h;
                }
                if (l >= h)
                {
                    done = true;
                }
                else
                {
                    temp = numbers[l];
                    numbers[l] = numbers[h];
                    numbers[h] = temp;

                    ++l;
                    --h;
                }
            }
            return h;
        }

        public static void QuickSort(int[] numbers, int i, int k)
        {
            int j = 0;

            if (i >= k) { return; }
            j = Partition(numbers, i, k);
            QuickSort(numbers, i, j);
            QuickSort(numbers, j + 1, k);

            return;
        }
    }

    class Driver
    {
        static void Main(string[] args)
        {
            int[] numbers  = { 6, 3, 7, 4, 8, 1, 2 , 9, 10, 13, 15, 12, 2, 5, 6, 16, 5};
            int NUMBERS_SIZE = numbers.Length - 1;
            var sort = new Sorting();

            Console.WriteLine("Original Array");
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }

            Sorting.QuickSort(numbers, 0, NUMBERS_SIZE);



            Console.WriteLine("\nSorted Array");
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }



            Console.WriteLine("\nThis is working...");
            Console.ReadKey();
        }
    }
}
