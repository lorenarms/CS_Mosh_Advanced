using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

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

    public static int ComputeClosestToNum(int[] ts, int keyNum)
    {
        if (ts == null || ts.Length == 0)
        {
            return 0;
        }

        int min = 10000;
        int abs = 0;
        int foundNum = 0;

        foreach (int number in ts)
        {
            if (keyNum > 0 && number > 0)
            {
                abs = Math.Abs(keyNum - number);
            }
            else if (keyNum > 0 && number < 0)
            {
                int tempNumber = Math.Abs(number);
                abs = tempNumber + keyNum;
            }
            else if (keyNum < 0 && number < 0)
            {
                abs = Math.Abs(keyNum - number);
            }
            else if (keyNum < 0 && number > 0)
            {
                int tempNumber = Math.Abs(keyNum);
                abs = number + tempNumber;
            }
            else
            {
                return 0;
            }

            if (abs < min)
            {
                min = abs;
                foundNum = number;
            }
        }
        Console.WriteLine("The found number closest to " + keyNum + " is " + foundNum);
        return min;
    }

    // reverse a string
    public static string ReverseString(string str)
    {
        string strRev = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
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

    // Find smallest of three numbers passed as integer array
    public static int FindSmallest(int[] arr)
    {
        int smallest;

        if (arr[0] < arr[1])
        {
            if (arr[2] < arr[0])
            {
                smallest = arr[2];
            }
            else
            {
                smallest = arr[0];
            }

        }
        else
        {
            if (arr[1] < arr[2])
            {
                smallest = arr[1];
            }
            else
            {
                smallest = arr[2];
            }
        }


        return smallest;
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
    }

    // find modulo 3 and 5 of array of numbers
    public static void FizzBuzz(int[] num)
    {

        foreach (var a in num)
        {

            if ((a % 3 == 0) && (a % 5 == 0))
            {
                Console.WriteLine("FizzBuzz");
            }

            else if (a % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }

            else if (a % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("Silence");
            }

        }
        
        

    }

    //find prime number in array of numbers
    public static void FindPrime(int[] nums)
    {
        bool prime = true;
        foreach (var a in nums)
        {
            for (int i = 2; i < a - 1; i++)
            {
                if (a % i == 0)
                {
                    prime = false;
                }
            }

            if (prime)
            {
                Console.WriteLine(a + " is prime.");
            }
            else
            {
                Console.WriteLine(a + " is not prime.");
            }

            prime = true;
        }
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

        //foreach (var a in ts)
        //{
        //    Console.Write(a + " ");
        //}

        //Console.WriteLine();

        Console.WriteLine("Difference is " + ComputeClosestToNum(ts, -54));
        Console.WriteLine("Difference is " + ComputeClosestToNum(ts, 32));
        Console.WriteLine("Difference is " + ComputeClosestToNum(ts, -1000));
        Console.WriteLine("Difference is " + ComputeClosestToNum(ts, 1));

        //string numToFind = Console.ReadLine();
        //int.TryParse(numToFind, out int num);
        //Console.WriteLine(FindElementInArray(ts, num));


        // input string of 3 numbers separated by commas

        Console.WriteLine("Enter numbers as a string, separated by a ','");

        string nums = Console.ReadLine();
        
        string[] newNums = nums.Split(',').ToArray();

        int[] numbers = new int[newNums.Length];

        for (int i = 0; i < newNums.Length; i++)
        {
            int.TryParse(newNums[i], out numbers[i]);
        }


        Console.WriteLine("Smallest number is " + FindSmallest(numbers));
        FizzBuzz(numbers);
        FindPrime(numbers);
        


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