using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_17_ReshapeString
{
    class Driver
    {
        public static void Main(string[] args)
        {
            WriteLine("Enter a string of characters with spaces: ");
            string str = ReadLine();
            
            
            //string str = "abcde fghijk lmno p";
            WriteLine("Original string: " + str);

            //TODO: add option to change what number the string is reshaped by (n)

            str = ReshapeString(str, 3);
            WriteLine("Reshaped string:\n" + str);

            ReadKey();
        }


        // reshape a string with no spaces and laidd out in lines of at
        // most 'n' characters
        // do not add a trailing '\n' character

        public static string ReshapeString(string str, int n)
        {
            int l = str.Length;

            for (int i = 0; i < l; i++)
            {
                if (str[i] == ' ')
                {
                    string sub1 = str.Substring(0, i);
                    string sub2 = str.Substring(i + 1, l - 1 - i);
                    str = sub1 + sub2;
                    l = str.Length;
                }
            }


            int e = l % n;
            if (e > 0)
            {
                e = n - e;
                for (int i = 0; i < e; i++)
                {
                    str += " ";
                }
            }

            int c = 0;
            for (int i = 0; i < l; i++)
            {
                if (c == n)
                {
                    str = str.Insert(i, "\n");
                    l = str.Length;
                    c = 0;
                    
                }
                else
                {
                    c++;
                }
            }

            str = str.Substring(0, str.Length - e);


            return str;
        }
    }
}
