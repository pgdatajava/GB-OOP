using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    //crea and draw a symbol
    class Point
    {
        //create coordinates
        public int x;
        public int y;
        //create symbol
        public char sym;

        
        public Point()
        {
        }

        //constructor takes data from the object
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        } 

        //function draws the symbol
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
