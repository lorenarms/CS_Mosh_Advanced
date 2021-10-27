using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Driver
{

    public static int ComputeClosestToZero(int[] ts)
    {
        // Write your code here
        // To debug: Console.Error.WriteLine("Debug messages...");
        if (ts == null || ts.Length == 0)
        {
            return 0;
        }

        int min = 10000;
        int abs = 0;

        foreach (int temperature in ts)
        {
            abs = Math.Abs(temperature);
            if (abs < Math.Abs(min))
            {
                min = temperature;
            }
        }
        if (min < 0)
        {
            foreach (int temperature in ts)
            {
                if (temperature == Math.Abs(min))
                {
                    min = temperature;
                }
            }
        }

        return min;
    }

    // reverse a string
    public static string ReverseString(string str)
    {
        string strRev = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            Console.WriteLine("i = " + i);
            strRev += str[i];
        }

        return strRev;


    }

    // bubble sort

    public static int[] BubbleSortInts(int[] arr)
    {
        int temp = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] < arr[j])
                {
                    //Console.WriteLine("i = " + i + " j = " + j);
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }


        return arr;
    }

    // using built in method to find an element in an array
    public static string FindElementInArray(int[] ts, int num)
    {
        //int found = Array.Find(ts, element => element.Equals(num));

        //if (found == num)
        //{
        //    return "Element found!";
        //}

        int found = Array.BinarySearch(ts, num);

        if (found < 0)
        {
            return "Sorry, not found";
        }
        else 
        {
            return "Element found! index: " + found;
        }


        return "Sorry, not found";
    }

    /* Ignore and do not change the code below */
    #region
    static void Main(string[] args)
    {
        int[] ts = new int[] {9, 3, 6, 12, 76, 34, -3, -2, -56, -13, 2, -1, 1, 34};
        //int n = int.Parse(Console.ReadLine());
        //int[] ts = new int[n];
        //inputs = Console.ReadLine().Split(' ');
        //for (int i = 0; i < n; i++)
        //{
        //    ts[i] = int.Parse(inputs[i]);
        //}
        //var stdtoutWriter = Console.Out;
        //Console.SetOut(Console.Error);
        //int solution = ComputeClosestToZero(ts);

        //Console.WriteLine(solution);
        ts = BubbleSortInts(ts);

        foreach (var a in ts)
        {
            Console.Write(a + " ");
        }

        string numToFind = Console.ReadLine();
        int.TryParse(numToFind, out int num);
        Console.WriteLine(FindElementInArray(ts, num));

        //string str = Console.ReadLine();
        //Console.WriteLine(ReverseString(str));
        //int[] arr = new int[] {4, 7, 1, 4, 8, 0, 8, 9, 2};

        //int[] sorted = BubbleSortInts(arr);

        //foreach (int a in sorted)
        //{
        //    Console.Write(a + " ");
        //}



        Console.ReadKey();
    }
    #endregion
}