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
        public HorizontalLine()
        {
            pList = new List<Point>();
            //create emty List
            Point p1 = new Point(4, 4, '*');
            Point p2 = new Point(5, 4, '*');
            Point p3 = new Point(6, 4, '*');
            //add Point objects into the List
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);

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
