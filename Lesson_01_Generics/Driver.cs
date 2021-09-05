using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_01_Generics
{
    public class Utilities
    {
        public T Max<T> (T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    public class TheseThings<T> where T : IComparable
    {
        public T Max (T a, T b) 
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }


    class Driver
    {

        static void Main(string[] args)
        {
            var intThings = new TheseThings<int>();
            
            var stringThings = new TheseThings<string>();
            


            var utils = new Utilities();
            var numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(12);

            var strings = new List<string>();
            strings.Add("A");
            strings.Add("B");

            Console.WriteLine(utils.Max(numbers.ElementAt<int>(0), numbers.ElementAt<int>(1)));
            Console.WriteLine(utils.Max(strings.ElementAt<string>(0), strings.ElementAt<string>(1)));

            Console.WriteLine(intThings.Max(numbers.ElementAt<int>(0), numbers.ElementAt<int>(1)));
            Console.WriteLine(stringThings.Max(strings.ElementAt<string>(0), strings.ElementAt<string>(1)));


            Console.WriteLine("This works");
            Console.ReadKey();

        }
    }
}
