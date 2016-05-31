using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Shape> wList;

        public Walls(int width, int height)
        {
            wList = new List<Shape>();
            HorisontalRow hrTop = new HorisontalRow(0, width - 2, 0, '+');
            VerticalRow vrRight = new VerticalRow(0, height - 1, width - 2, '+');
            HorisontalRow hrBottom = new HorisontalRow(0, width - 2, height - 1, '+');
            VerticalRow vrLeft = new VerticalRow(0, height - 1, 0, '+');

            wList.Add(hrTop);
            wList.Add(hrBottom);
            wList.Add(vrLeft);
            wList.Add(vrRight);
        }

        public bool isHit(Shape shape)
        {
            foreach(Shape wall in wList)
            {
                if (wall.isHit(shape))
                    return true;
            }
            return false;
        }

        public void Draw()
        {
            foreach(Shape wall in wList)
            {
                wall.Draw();
            }
        }

    }
}
