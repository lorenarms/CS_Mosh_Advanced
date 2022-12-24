/*
 * Program: Finding a Pattern in a String (multi-line)
 * Author: Lawrence Artl III
 *
 * This program takes in a text file that contains a string (single or
 * multi-line) and attempts to find a user-input pattern of a shorter string
 * within the larger string.
 *
 * For example: if the string in the text file is
 *
 *  fgh
 *  uty
 *  iyu
 *
 * and the user enters 'ty', the program will find the first instance of 'ty'
 * and then print the full string with the found pattern printed in red.
 *
 * This program is based off of a question from a technical interview involving
 * finding a pattern in a picture using a similar method (hence why the string is
 * referred to as a 'picture' throughout the program). 
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_18_FindingPatternsWithLoops
{
    class Driver
    {
        public static void DrawPicture(string[] pictureAsString)
        {
            WriteLine("PICTURE:");
            for (int i = 0; i < pictureAsString.Length; i++)
            {
                for (int j = 0; j < pictureAsString[0].Length; j++)
                {
                    Write(pictureAsString[i][j]);
                }
                Write("\n");
            }

            WriteLine();


        }

        public static void DrawPattern(string[] patternToFind)
        {
            WriteLine("\nPATTERN TO FIND:");
            for (int i = 0; i < patternToFind.Length; i++)
            {
                for (int j = 0; j < patternToFind[0].Length; j++)
                {
                    Write(patternToFind[i][j]);
                }
                Write("\n");
            }
            WriteLine();
        }

        public static void PrintFinalPicture(string[] pictureAsString, string[] patternToFind, int[] locationOfPattern)
        {
            int patLength = patternToFind.Length;
            int patHeight = patternToFind[0].Length;
            int patRow = locationOfPattern[0];

            WriteLine("LOCATION:");
            for (int i = 0; i < pictureAsString.Length; i++)
            {
                for (int j = 0; j < pictureAsString[0].Length; j++)
                {
                    if (i == locationOfPattern[0] && j == locationOfPattern[1])
                    {
                        ForegroundColor = ConsoleColor.Red;
                        int k = 0;
                        while (k < patternToFind[0].Length)
                        {
                            Write(pictureAsString[i][j]);
                            k++;
                            j++;
                        }

                        ResetColor();

                        if (locationOfPattern[0] < patLength + patRow - 1)
                        {
                            locationOfPattern[0]++;
                        }

                        // conditional to stop error of trying to write out of bounds of array
                        if (j < pictureAsString[0].Length)
                        {
                            Write(pictureAsString[i][j]);
                        }
                    }
                    else
                    {
                        Write(pictureAsString[i][j]);
                    }
                    //Write(pictureAsString[i][j]);

                }
                Write("\n");
            }
        }

        public static int[] FindPattern(
            string[] pictureAsString, 
            string[] patternToFind, 
            int pictureWidth, 
            int pictureHeight, 
            int patternWidth,
            int patternHeight)
        {
            int[] currentLocation = {-1, -1};

            // flag for if patter is found
            bool patternFound = false;

            // outer loop through 'rows' of main array
            for (int i = 0; i < pictureHeight; i++)
            {
                // inner loop for chars of each row
                for (int j = 0; j < pictureWidth; j++)
                {

                    // look for matching single char first
                    // only finds the first instance (foundPattern stops any others)
                    // doesn't check if the found char is too close to the end of the string
                    if (pictureAsString[i][j] == patternToFind[0][0] && !patternFound && (j < pictureWidth - patternWidth))
                    {
                        // marker vars
                        int l = 0;
                        int k = i;

                        // set a substring starting at row[k] and ending at length of pattern
                        string currentSubString = pictureAsString[k].Substring(j, patternWidth + 1);


                        // while the chars in the substring and the current pattern row match
                        while (currentSubString == patternToFind[l])
                        {
                            // check if 'l' marker equals the number of 'rows' in the pattern
                            // l marker will equal this only if the while condition was true enough times
                            if (l == patternHeight)
                            {
                                patternFound = true;
                                currentLocation[0] = i;
                                currentLocation[1] = j;
                                break;
                            }

                            // increment the markers
                            l++;
                            k++;

                            // update the substring to compare pattern to
                            currentSubString = pictureAsString[k].Substring(j, patternWidth + 1);
                        }


                    }
                }
            }


            return currentLocation;
        }

        public static void Main(string[] args)
        {

            // TODO: add option to either 1. import text file with pre-made string or 2. generate random string in text file
                
            string[] pictureAsString = System.IO.File.ReadAllLines(@"C:\Users\Lawrence\Git Repos\Personal_CSharp_Mosh_Advanced\Lesson_18_FindingPatternsWithLoops\strings.txt");


            // TODO: add option to search for multi-line pattern; see below for examples

            //string[] str = {
            //    "abcdef", "ghijkl", "mnopqr", "stuvwx"
            //};

            //string[] pat = {"abc", "ghi", "mno", "stu"};
            //string[] pat = {"abc"};
            //string[] pat = {"abc", "ghi"};
            //string[] pat = {"abc", "ghi", "mno"};
            //string[] pat = {"ghi", "mno", "stu"};
            //string[] pat = {"mno", "stu" };
            //string[] pat = {"big", "lte"};
            //string[] pat = {"ij", "op" };

            DrawPicture(pictureAsString);

            WriteLine("Input a lowercase string to find: ");
            string input = ReadLine();
            string[] pattern = {input};

            DrawPattern(pattern);

            // assume all 'rows' are of same length
            int pictureHeight = pictureAsString.Length;
            int pictureWidth = pictureAsString[0].Length;
            
            int patternToFindHeight = pattern.Length - 1;
            int patternToFindWidth = pattern[0].Length - 1;

            int[] locationOfPattern = FindPattern(pictureAsString, pattern, pictureWidth, pictureHeight, patternToFindWidth, patternToFindHeight);

            if (locationOfPattern[0] == -1 && locationOfPattern[1] == -1)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Pattern not found.");
                ResetColor();
                
            }
            else
            {
                Write("Pattern Found at ");
                ForegroundColor = ConsoleColor.Green;
                Write("row " + (locationOfPattern[0] + 1));
                ResetColor();
                Write(" and ");
                ForegroundColor = ConsoleColor.Green;
                Write("column " + (locationOfPattern[1] + 1));
                ResetColor();
                WriteLine();
                PrintFinalPicture(pictureAsString, pattern, locationOfPattern);

            }
            

            ForegroundColor = ConsoleColor.DarkMagenta;
            WriteLine("Press Enter to Exit");

            ReadKey();
        }
    }
}
