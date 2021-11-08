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
        public static void DrawPicture(string[] str, string[] pat)
        {
            WriteLine("PICTURE:");
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str[0].Length; j++)
                {
                    Write(str[i][j]);
                }
                Write("\n");
            }

            WriteLine("\nPATTERN TO FIND:");
            for (int i = 0; i < pat.Length; i++)
            {
                for (int j = 0; j < pat[0].Length; j++)
                {
                    Write(pat[i][j]);
                }
                Write("\n");
            }
            WriteLine();
        }

        public static void PrintFinalPicture(string[] str, string[] pat, int[] location)
        {
            WriteLine("LOCATION:");
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str[0].Length; j++)
                {
                    if (i == location[0] && j == location[1])
                    {
                        ForegroundColor = ConsoleColor.Red;
                        //Write(str[i][j]);
                        int k = 0;
                        while (k < pat[0].Length)
                        {
                            Write(str[i][j]);
                            k++;
                            j++;
                        }

                        ResetColor();

                        if (location[0] < pat.Length)
                        {
                            location[0]++;
                        }

                        Write(str[i][j]);


                    }
                    else
                    {
                        Write(str[i][j]);
                    }
                    
                    
                }
                Write("\n");
            }
        }


        public static void Main(string[] args)
        {
            string[] str = {
                "abcdef", "ghijkl", "mnopqr", "stuvwx"
            };

            string[] pat = {"abc", "ghi", "mno"};

            DrawPicture(str, pat);



            // variables for 'height' of array
            // and length of array
            // assume all 'rows' are of same length
            int strRows = str.Length - 1;
            int strCols = str[0].Length - 1;

            // vars for 'height' of pattern
            // and length of pattern
            int patRows = pat.Length - 1;
            int patCols = pat[0].Length - 1;

            // flag for if patter is found
            bool foundPattern = false;

            int[] location = {-1, -1};

            //WriteLine("strRows: " + strRows + "\nstrCols: " + strCols);
            //WriteLine("patRows: " + patRows + "\npatCols: " + patCols);

            // outer loop through 'rows' of main array
            for (int i = 0; i < strRows; i++)
            {
                // inner loop for chars of each row
                for (int j = 0; j < strCols; j++)
                {
                    // look for matching single char first
                    if (str[i][j] == pat[0][0])
                    {
                        // marker vars
                        int l = 0;
                        int k = i;

                        // set a substring starting at row[k] and ending at length of pattern
                        string tempStr = str[k].Substring(j, patCols + 1);

                        //WriteLine("tempStr: " + tempStr);

                        // while the chars in the substring and the current pattern row match
                        while (tempStr == pat[l])
                        {
                            
                            //WriteLine("tempStr: " + tempStr);
                            //WriteLine("pat[l]: " + pat[l]);
                            
                            // check if 'l' marker equals the number of 'rows' in the pattern
                            // l marker will equal this only if the while condition was true enough times
                            if (l == patRows)
                            {
                                foundPattern = true;
                                WriteLine("Pattern Found at row " + (i + 1) + ", column " + (j + 1));
                                location[0] = i;
                                location[1] = j;
                                

                                break;
                            }

                            // increment the markers
                            l++;
                            k++;

                            // update the substring to compare pattern to
                            tempStr = str[k].Substring(j, patCols + 1);
                        }


                    }
                }
            }

            if (!foundPattern)
            {
                WriteLine("Pattern not found");
            }

            PrintFinalPicture(str, pat, location);


            ReadKey();
        }
    }
}
