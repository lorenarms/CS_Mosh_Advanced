using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_03_LambdaExpressions
{
    public class Objects
    {
        public Objects()
        {

        }

        // func is the param type to this method
        public int MyMethod(Func<int, int, int, int> MyFunc)
        {
            return MyFunc(3, 4, 5);
        }

        // action is kind of pointless cause you can't pass as ref
        public void MyActionMethod(Action<int, int> MyAction)
        {
            int a = 4;
            int b = 5;
            MyAction(a, b);
            Console.WriteLine($"A: {a} B: {b}" );
            //return 0;
        }



    }
    class Lambda
    {
        public static void MyActionToPass(int a, int b)
        {
            a++;
            b++;
        }
        
        // func must return something
        public static int MyFuncToPass(int a, int b, int c)
        {
            return a * b * c;
            //throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            var newObject = new Objects();

            // call MyMethod and pass MyFuncToPass as param
            int funcNum = newObject.MyMethod(MyFuncToPass);
            Console.WriteLine($"Func returned: {funcNum}" );

            newObject.MyActionMethod(MyActionToPass);


            // lambda expression
            // use delegates like 'Func' and 'Action'

            Func<int, int> square = number => number * number;

            Func<int, int, int> doubleMult = (i, i1) => i * i1;

            Func<int, int, int, int> tripleMult = (i, j, k) => i * j * k;

            //int num = square(3);

            // calling the above funcs
            Console.WriteLine(square(3));

            Console.WriteLine(doubleMult(2, 3));

            Console.WriteLine(tripleMult(1, 2, 3));

            Action<double> div = i =>
            {
                i += 10;
                i *= i;
                i = 12 / i;
                Console.WriteLine($"'i' is now equal to {i:F3}");

            };

            // call the above action
            div(2);




            Console.WriteLine("Press 'enter' to exit.");
            Console.ReadKey();
            Environment.Exit(0);
        }

        


        public void NewMethod()
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
