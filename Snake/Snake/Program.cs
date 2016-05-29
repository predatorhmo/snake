using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1, y1 = 3;
            char ch = '*';
            Draw(x1, y1, ch);

            int x2 = 3, y2 = 6;
            char ch2 = '#';
            Draw(x2, y2, ch2);

            Console.ReadKey();

        }

        static void Draw(int x, int y, char ch)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(ch);
        }
    }
}
