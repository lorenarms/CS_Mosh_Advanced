using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Exercise10
{
    class Application
    {
        public void Start()
        {

            SetWindowSize(120, 30);
            //string title = "Welcome to the color service";
            string title = @"
                                                    ___                          
                                                   /\_ \                         
                                         ___    ___\//\ \     ___   _ __   ____  
                                        /'___\ / __`\\ \ \   / __`\/\`'__\/',__\ 
                                       /\ \__//\ \L\ \\_\ \_/\ \L\ \ \ \//\__, `\
                                       \ \____\ \____//\____\ \____/\ \_\\/\____/
                                        \/____/\/___/ \/____/\/___/  \/_/ \/___/ 
";

            int width = Console.WindowWidth;
            
            int sWidth = 42;
            int center = width - sWidth;
            center = center / 2;
            SetCursorPosition(center, 0);
            WriteLine(title);

            int pos = CursorTop + 1;
            DrawTitle.DrawNewTitle(pos, "Press any key to start...");
            
            ReadKey(true);
            Clear();
            

             

            List<Color> colors = new List<Color>();
            colors.Add(new Color("Blue", 2.50));
            colors.Add(new Color("Yellow", 3.45));
            colors.Add(new Color("Red", 4.25));

            MainMenu();




            WriteLine("Press any key to continue...");
            ReadKey(true);
        }
        private void MainMenu()
        {
            bool inMenu = true;
            do
            {
                string prompt = "MAIN MENU: please make a selection using the arrow keys";
                string[] options = { "     Add a color      ", "    Remove a color    ", 
                    "   Show all Colors    ", "    About this app    ", "       Exit app       " };
                int startPosition = CursorTop + 1;
                Menu mainMenu = new Menu(prompt, options, startPosition);
                int selection = mainMenu.RunMenu();

                switch (selection)
                {
                    case 0:
                        {

                            break;
                        }
                    case 1:
                        {

                            break;
                        }
                    case 2:
                        {

                            break;
                        }
                    case 3:
                        {
                            Clear();
                            WriteLine(@"
                                                    ___                          
                                                   /\_ \                         
                                         ___    ___\//\ \     ___   _ __   ____  
                                        /'___\ / __`\\ \ \   / __`\/\`'__\/',__\ 
                                       /\ \__//\ \L\ \\_\ \_/\ \L\ \ \ \//\__, `\
                                       \ \____\ \____//\____\ \____/\ \_\\/\____/
                                        \/____/\/___/ \/____/\/___/  \/_/ \/___/ 
                                    ");
                            string[] title = { "COLORS application", "Created by Lawrence Artl III", "Copyright 2020", "Press any key to continue..." };
                            for (int i = 0; i < title.Length; i++)
                            {
                                DrawTitle.DrawNewTitle(CursorTop + 1, title[i]);
                            }
                            ReadKey(true);
                            Clear();
                            //MainMenu();
                            break;

                        }

                    case 4:
                        {
                            
                            string eForExit = "Press 'e' to exit the program. Press any other key to cancel.";
                            DrawTitle.DrawNewTitle(CursorTop + 1, eForExit);
                            ConsoleKeyInfo keyInfo = ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.E)
                            {
                                Environment.Exit(0);
                                break;
                            }
                            else
                                Clear();
                            MainMenu();
                            break;
                        }
                    default: { break; }
                }
            } while (inMenu);

        }
    }
}
