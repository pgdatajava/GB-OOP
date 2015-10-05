using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    //draw horizontal line
    //inheritance class Figure
    class HorizontalLine : Figure
    {
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

        
    }
}
