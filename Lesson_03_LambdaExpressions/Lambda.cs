using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_03_LambdaExpressions
{
    class Lambda
    {

        static void Main(string[] args)
        {
            int c = 5;
            
            Func<int, int> square = n => n * n;

            Action<int> mult = b => c = 10;
            Action act = () =>
            {
                Console.WriteLine("No parameter.");
            };

            Action<int> div = (b) =>
            {
                Console.WriteLine("b = " + b);
            };

            Console.WriteLine(square(10));

            mult(c);
            div(12);
            act();
            Console.WriteLine(c);

            Console.ReadKey();
        }

    }
}
