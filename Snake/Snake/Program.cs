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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(5, 6, '#');
            p2.Draw();

            HorisontalRow hr = new HorisontalRow(5, 15, 7, '_');
            hr.Draw();

            VerticalRow vr = new VerticalRow(8, 20, 15, '|');
            vr.Draw();

            Console.ReadKey();

        }


    }
}
