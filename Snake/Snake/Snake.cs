using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Shape
    {
        Direction direction;

        public Snake(Point tail, int length, Direction _direction) {
            pList = new List<Point>();
            direction = _direction;
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;

        }

        internal void HandleMove(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
        }
        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.isHit(food))
            {
                food.sym = head.sym;
                food.Draw();
                pList.Add(food);
                return true;
            }else
            {
                return false;
            }
        }

        public bool isHitTail()
        {
            Point head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.isHit(pList[i]))
                    return true;
            }
            return false;
        }
    }
}
