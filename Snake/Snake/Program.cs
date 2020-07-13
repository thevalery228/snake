using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            upLine.Draw();
            downLine.Draw();

            VerticalLine vline = new VerticalLine(5, 8, 18, '+');
            vline.Draw();

            Console.ReadKey();
        }
    }
}