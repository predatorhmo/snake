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



                Walls wall = new Walls(120, 30);
                wall.Draw();

                Point p = new Point(20, 10, '*');
                Snake snake = new Snake(p, 7, Direction.RIGHT);
                snake.Draw();

                FoodCreator foodCreator = new FoodCreator(120, 30, '%');
                Point food = foodCreator.CreateFood();
                food.Draw();
                while (true) {
                    if(wall.isHit(snake) || snake.isHitTail())
                    {
                        break;
                    }
                    if (snake.Eat(food))
                    {
                        food = foodCreator.CreateFood();
                        food.Draw();
                    }
                    else
                    {
                        snake.Move();
                    }

                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        snake.HandleMove(key.Key);
                    }
                    Thread.Sleep(100);
                    //snake.Move();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }


    }
}
