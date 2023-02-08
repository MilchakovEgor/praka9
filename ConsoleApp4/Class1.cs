using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disp_zadach
{
    internal class Menu
    {
        public int position = 0;
        public void strelki(ConsoleKeyInfo key)
        {


            if (key.Key == ConsoleKey.UpArrow & position > 0)
            {
                position--;
                process.pos--;
                Console.SetCursorPosition(0, (position + 1));
                Console.WriteLine("  ");
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                position++;
                process.pos++;
                Console.SetCursorPosition(0, (position - 1));
                Console.WriteLine("  ");
            }
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");


        }

    }
}