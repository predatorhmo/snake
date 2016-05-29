using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalRow
    {
        List<Point> pList;

        public VerticalRow(int yU, int yD, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yU; y <= yD; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
