using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Shape
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool isHit(Shape shape)
        {
            foreach (Point p in pList)
            {
                if (shape.isHit(p))
                    return true;
            }
            return false;
        }

        protected bool isHit(Point point)
        {
            foreach (Point p in pList)
            {
                if (p.isHit(point))
                    return true;
            }
            return false;
        }
    }
}
