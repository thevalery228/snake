﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT) x += offset;
            if (direction == Direction.LEFT) x -= offset;
            if (direction == Direction.UP) y -= offset;
            if (direction == Direction.DOWN) y += offset;
        }

        public void Clear()
        {
            char oldSym = sym;
            sym = ' ';
            Draw();
            //sym = oldSym;
        }
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
