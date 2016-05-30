using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.SetBufferSize(120, 30);

                HorisontalRow hrUp = new HorisontalRow(0, 118, 0, '+');
                VerticalRow vrR = new VerticalRow(0, 29, 118, '+');
                HorisontalRow hrDown = new HorisontalRow(0, 118, 29, '+');
                VerticalRow vrL = new VerticalRow(0, 29, 0, '+');

                hrUp.Draw();
                vrR.Draw();
                hrDown.Draw();
                vrL.Draw();

                Point p = new Point(20, 10, '*');
                Snake sn = new Snake(p, 7, Direction.RIGHT);
                sn.Draw();

                while (true) {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        sn.HandleMove(key.Key);
                    }
                    Thread.Sleep(100);
                    sn.Move();
                }
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }


    }
}
