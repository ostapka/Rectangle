using System;
using System.Collections.Generic;
using System.Linq;

namespace Rectangle.Impl
{
    public static class Service
	{
		/// <summary>
		/// See TODO.txt file for task details.
		/// Do not change contracts: input and output arguments, method name and access modifiers
		/// </summary>
		/// <param name="points"></param>
		/// <returns></returns>
		public static Rectangle FindRectangle(List<Point> points)
		{
			if (points != null && points.Count >= 2 && 
				points.Distinct().Count() == points.Count())
			{
				points.Sort();
				int minY = points.Select(x => x.Y).Min();
				int maxY = points.Select(x => x.Y).Max();
				Point pointMinY = points.Find(x => x.Y == minY);
				Point pointMaxY = points.Find(x => x.Y == maxY);
				if (points.Where(x => x.X == points.Last().X).Count() == 1)
					return new Rectangle() { X = points.Last().X - 1, Y = minY, 
						Height = pointMaxY.DistanceByY(pointMinY), 
						Width = points.First().X - (points.Last().X - 1) };
				else if (points.Where(x => x.X == points.First().X).Count() == 1)
					return new Rectangle() { X = points.First().X + 1, Y = minY, 
						Height = pointMaxY.DistanceByY(pointMinY), 
						Width = points.Last().X - (points.First().X + 1) };
				else throw new ArgumentException("The input list is invalid");
			}
			else throw new ArgumentException("The input list is invalid");
		}
	}
}
