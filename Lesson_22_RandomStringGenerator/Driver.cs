using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_22_RandomStringGenerator
{
    class Driver
    {
        static void Main(string[] args)
        {
            var generator = new RandomGenerator();
            var writeLines = new WriteAllAlines();
            List<string> linesToWriteToFile = new List<string>{};
            

            //var randomNumber = generator.RandomNumber(5, 100);
            //Console.WriteLine($"Random number between 5 and 100 is {randomNumber}");
            //linesToWriteToFile.Add(randomNumber.ToString());

            for (int i = 0; i < 20; i++)
            {
                var randomString = generator.RandomString(40);
                linesToWriteToFile.Add(randomString);

            }

            //var randomPassword = generator.RandomPassword();
            //Console.WriteLine($"Random string of 6 chars is {randomPassword}");
            //linesToWriteToFile.Add(randomPassword);

            Task writeToFile = writeLines.WriteStringsToFile(linesToWriteToFile);

            
        }
    }

    public class RandomGenerator
    {
        // Instantiate random number generator.  
        // It is better to keep a single Random instance 
        // and keep using Next on the same instance.  
        private readonly Random _random = new Random();

        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        // Generates a random string with a given size.    
        public string RandomString(int size, bool lowerCase = true)
        {
            var builder = new StringBuilder(size);

            // Unicode/ASCII Letters are divided into two blocks
            // (Letters 65–90 / 97–122):   
            // The first group containing the uppercase letters and
            // the second group containing the lowercase.  

            // char is a single Unicode character  
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length = 26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        // Generates a random password.  
        // 4-LowerCase + 4-Digits + 2-UpperCase  
        public string RandomPassword()
        {
            var passwordBuilder = new StringBuilder();

            // 4-Letters lower case   
            passwordBuilder.Append(RandomString(4, true));

            // 4-Digits between 1000 and 9999  
            passwordBuilder.Append(RandomNumber(1000, 9999));

            // 2-Letters upper case  
            passwordBuilder.Append(RandomString(2));
            return passwordBuilder.ToString();
        }
    }

    class WriteAllAlines
    {
        public async Task WriteStringsToFile(List<string> input)
        {
            //string[] lines =
            //{
            //    "First lines", "Second line", "Third line"
            //};


            // writes a file to the current program directory, wherever that is
            await File.WriteAllLinesAsync(@".\RandomTextWritten.txt", input);


        }
    }
}


