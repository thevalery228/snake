﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Snake : Figure
	{
		Direction direction;
		public int eatedFoodCount = 0;
		public Snake(Point tail, int length, Direction _direction)
		{
			direction = _direction;
			pointsList = new List<Point>();
			for (int i = 0; i < length; i++)
			{
				Point p = new Point(tail);
				p.Move(i, direction);
				pointsList.Add(p);
			}
		}

		public void Move()
		{
			Point tail = pointsList.First();
			pointsList.Remove(tail);
			Point head = GetNextPoint();
			pointsList.Add(head);

			tail.Clear();
			head.Draw();
		}

		public Point GetNextPoint()
		{
			Point head = pointsList.Last();
			Point nextPoint = new Point(head);
			nextPoint.Move(1, direction);
			return nextPoint;
		}

		public bool IsHitTail()
		{
			var head = pointsList.Last();
			for (int i = 0; i < pointsList.Count - 2; i++)
			{
				if (head.IsHit(pointsList[i]))
					return true;
			}
			return false;
		}

		public void HandleKey(ConsoleKey key)
		{
			if (key == ConsoleKey.LeftArrow) direction = Direction.LEFT;
			if (key == ConsoleKey.RightArrow) direction = Direction.RIGHT;
			if (key == ConsoleKey.DownArrow) direction = Direction.DOWN;
			if (key == ConsoleKey.UpArrow) direction = Direction.UP;
		}

		public bool Eat(Point food)
		{
			Point head = GetNextPoint();
			if (head.IsHit(food))
			{
				food.sym = head.sym;
				pointsList.Add(food);
				return true;
			}
			else
				return false;
		}

		public void Clear() { foreach (Point p in pointsList) { p.Clear(); } }
    }
}
