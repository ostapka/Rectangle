using System;
using System.Collections.Generic;
using System.Linq;
using Rectangle.Impl;

namespace Rectangle.Console
{
	class Program
	{
		/// <summary>
		/// Use this method for local debugging only. The implementation should remain in Rectangle.Impl project.
		/// See TODO.txt file for task details.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			List<Point> list = new List<Point>();
			list.Add(new Point() { X = 1, Y = 1 });
			list.Add(new Point() { X = 1, Y = 2 });
			list.Add(new Point() { X = 3, Y = 1 });
			list.Add(new Point() { X = 3, Y = 3 });
			var rec = Service.FindRectangle(list);
			System.Console.WriteLine("X = {0}, Y = {1}, Height = {2}, Width = {3}", rec.X, rec.Y, rec.Height, rec.Width);
			System.Console.ReadKey();
		}
	}
}
