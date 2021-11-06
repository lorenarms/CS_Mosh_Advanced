using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14_TechnicalAssessment
{
    class Driver
    {
        struct Struct
        {
            public int foo;
        }


        public static void Main(string[] args)
        {
            Struct struct1;
            struct1.foo = 5;

            Struct struct2 = struct1;
            struct2.foo = 10;

            Console.WriteLine(struct1.foo);
            Console.WriteLine(Shuffle());



            A a = new A();
            A b = new B();

            Console.ReadKey();
        }

        // returns the smallest positive interval between two values in the [numbers] array
        public static int FindSmallestInterval(int[] numbers)
        {
            Array.Sort(numbers);
            int interval = numbers[1] - numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                var difference = numbers[i + 1] - numbers[i];
                if (difference < interval)
                {
                    interval = difference;
                }
            }
            return interval;
        }

        public static int Shuffle()
        {
            int i1 = 5;
            int i2 = 2;
            int i3 = i1 / i2;

            return i3;
        }
    }


    // B derives from A to make the code above valid
    public class A
    {

    }

    public class B : A
    {

    }
}
