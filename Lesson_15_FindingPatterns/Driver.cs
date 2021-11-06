using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Lesson_15_FindingPatterns
{
    class Driver
    {
        public static void Main()
        {
            Console.WriteLine(PatternCount("AA AADRAARAASSAA"));
            Console.ReadKey();
        }

        public static int PatternCount(string sDNA)
        {
            Regex reParts = new Regex("(\\w\\w)\\s(\\w+)");
            
            Match m = reParts.Match(sDNA);

            if (m.Success)
            {
                Console.WriteLine(m.Groups.Count);
                Console.WriteLine(m.Groups[0].Value);
                Console.WriteLine(m.Groups[1]);
                Console.WriteLine(m.Groups[2]);
                var t = Regex.Matches(m.Groups[2].Value, m.Groups[1].Value);
                foreach (var a in t)
                {
                    Console.WriteLine(a);
                }
                return Regex.Matches(m.Groups[2].Value, m.Groups[1].Value).Count;
                
            }
            else
            {
                return 0;
            }
        }
    }
}
