using System;
using System.Collections.Generic;
using static System.Console;

namespace snake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.SetWindowSize(80, 28);

            //Отрисовка рамки

            HorizontalLine upLine = new HorizontalLine(0, Console.BufferWidth - 1, 0, '*');
            HorizontalLine downLine = new HorizontalLine(0, Console.BufferWidth - 1, Console.BufferHeight - 1, '*');
            VerticalLine leftLine = new VerticalLine(0, Console.BufferHeight - 1, 0, '*');
            VerticalLine rigthLine = new VerticalLine(0, Console.BufferHeight - 1, Console.BufferWidth - 1, '*');

            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rigthLine.Drow();



            //Отрисовка точек 
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();
            ReadLine();
        }
    }
}
