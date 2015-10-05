using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    //draw horizontal line
    class HorizontalLine
    {
        //create List
        List<Point> pList;

        //constructor
        //takes data for left and right and osZ and symbol
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            //cycke
            for (int x = xLeft; x<=xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }
           

        }

        //drawing method
        public void Draw()
        {
            foreach (Point p in pList)
            {
                //calling Point object's function
                p.Draw();
            }
        }
    }
}
