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
				int minY = points.Select(x => x.Y).Min();
				int maxY = points.Select(x => x.Y).Max();
				int minX = points.Select(x => x.X).Min();
				int maxX = points.Select(x => x.X).Max();
				if (points.Where(x => x.X == maxX).Count() == 1)
					return new Rectangle() 
					{ 
						X = maxX - 1, 
						Y = minY, 
						Height = maxY - minY + 1, 
						Width = minX - maxX 
					};
				else if (points.Where(x => x.X == minX).Count() == 1)
					return new Rectangle() 
					{ 
						X = minX + 1, 
						Y = minY, 
						Height = maxY - minY + 1, 
						Width = maxX - minX 
					};
				else if (points.Where(x => x.Y == minY).Count() == 1)
					return new Rectangle()
					{
						X = minX,
						Y = minY + 1,
						Height = maxY - minY,
						Width = maxX - minX + 1
					};
				else if (points.Where(x => x.Y == maxY).Count() == 1)
					return new Rectangle()
					{
						X = minX,
						Y = maxY - 1,
						Height = minY - maxY,
						Width = maxX - minX + 1
					};
				else throw new ArgumentException("The input list is invalid");
			}
			else throw new ArgumentException("The input list is invalid");
		}
	}
}
