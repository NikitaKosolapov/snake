using System;
using System.Collections.Generic;

namespace snake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine line1 = new HorizontalLine(5, 10, 8, '+');
            line1.Drow();

            VerticalLine line2 = new VerticalLine(1, 20, 10, '&');
            line2.Drow();

            Console.ReadLine();
        }
    }
}
