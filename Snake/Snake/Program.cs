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

            SampleCollection<int> numList = new SampleCollection<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            for (int i=0; i<numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }

            numList.RemoveAt(0);

            SampleCollection<Point> pList = new SampleCollection<Point>();
            pList.Add(p1);
            pList.Add(p2);

            Console.ReadKey();
        }
    }
}