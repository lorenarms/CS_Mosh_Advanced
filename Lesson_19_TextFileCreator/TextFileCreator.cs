using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using RandomIDGenerator;

namespace Lesson_19_TextFileCreator
{
    class TextFileCreator
    {
        static void Main(string[] args)
        {
            // ask use to decide how many files to create
            Write("How many files to create: ");
            string input = ReadLine();
            int num = 1;
            
            // try to parse the input; default is 1 if input is invalid
            try
            {
                num = Int32.Parse(input);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            Write("Base-name of files (default is 'textFile'): ");
            string name = ReadLine();

            if (name.Equals("\n") || name.Equals(""))
            {
                name = "textFile";
            }
            else if (name.Contains("\n"))
            {
                name = "textFile_";
            }

            Write("What is your Windows Username (this is used for the directory)? ");
            string username = ReadLine();

            Write("Is '" + username + "' correct? y/n ");
            string confirm = ReadLine();
            if (confirm != null)
            {
                confirm.ToLower();
                while (confirm != null && !(confirm.Equals("y") || confirm.Equals("yes") ))
                {
                    Write("What is your Windows Username (this is used for the directory)? ");
                    username = ReadLine();

                    Write("Is '" + username + "' correct? y/n ");
                    confirm = ReadLine();
                }
            }


            // create new GenerateID object
            var newID = new GenerateID();
            
            // loop to create files and write text
            for (int i = 1; i <= num; i++)
            {
                // name the file and the path 
                string folder = "C:\\Users\\" + username + "\\Desktop\\New folder\\";
                string path = "C:\\Users\\" + username + "\\Desktop\\New folder\\" + name + i + ".txt";

                string text;

                // create bytes of random string
                var bytes = System.Text.Encoding.UTF8.GetBytes(newID.generateUniqueID());
                
                // create SHA512 of bytes
                using (var hash = System.Security.Cryptography.SHA512.Create())
                {
                    var hashedInputBytes = hash.ComputeHash(bytes);

                    // Convert to text
                    // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
                    var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                    foreach (var b in hashedInputBytes)
                        hashedInputStringBuilder.Append(b.ToString("X2"));
                    text = hashedInputStringBuilder.ToString();
                   

                }

                // try to either create or write to the file
                try
                {
                    if (File.Exists(folder))
                    {
                        //writes to file
                        System.IO.File.WriteAllText(path, text);
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(folder);
                        System.IO.File.WriteAllText(path, text);

                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    WriteLine("Files not created! Error");
                }


            }
            WriteLine("Files created successfully. Press 'enter' to close this window.");
            ReadKey();
            

        }
    }
}
