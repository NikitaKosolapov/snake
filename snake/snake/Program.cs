﻿using System;
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

            Point p3 = new Point(6, 3, '&');
            p2.Draw();

            Point p4 = new Point(8, 2, '%');
            p2.Draw();

            List<Char> charList = new List<Char>
            {
                '!',
                '@',
                '#',
                '$',
                '%',
                '&',
                '?'
            };

            foreach (char i in charList)
            {
                Console.WriteLine(i);
            }


            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt( 0 );

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            Console.ReadLine();
        }
    }
}
