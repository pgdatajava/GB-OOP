using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        //create list
        //protected to show by  inheritance
        protected List<Point> pList;
        
        //drawing function
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }



    }
}
