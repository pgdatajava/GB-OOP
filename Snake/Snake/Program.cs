using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a symbol object
            Point p1 = new Point(1, 3, '*');
            p1.Draw();


            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            //class List
            List<int> numList = new List<int>();
            //add elements in the List
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            //cycle
            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            //remove the element from the List
            numList.Remove(0);

            //create List of Point class objects
            List<Point> pList = new List<Point>();
            //add existing Point objects
            pList.Add(p1);
            pList.Add(p2);


            Console.ReadKey();
        }
       
    }
}
