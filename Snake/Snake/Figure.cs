using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Figure
	{
		protected List<Point> pointsList;

		public virtual void Draw()
		{
			foreach (Point p in pointsList)
			{
				p.Draw();
			}
		}

		internal bool IsHit(Figure figure)
		{
			foreach (var p in pointsList)
			{
				if (figure.IsHit(p))
					return true;
			}
			return false;
		}

		private bool IsHit(Point point)
		{
			foreach (var p in pointsList)
			{
				if (p.IsHit(point))
					return true;
			}
			return false;
		}
	}
}
