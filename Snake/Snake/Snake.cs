﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Snake(Point tail, int length, Direction direction)
        {
            pointsList = new List<Point>();
            for (int i=0; i<length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pointsList.Add(p);
            }
        }
    }
}
