using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Exercise10
{
    class DrawTitle
    {
        public static void DrawNewTitle(int row, string title)
        {
            int width = Console.WindowWidth;
            int sWidth = title.Length;
            int center = width - sWidth;
            center = center / 2;
            SetCursorPosition(center, row);
            WriteLine(title);
        }

    }
}
