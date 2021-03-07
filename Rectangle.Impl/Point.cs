using System;

namespace Rectangle.Impl
{
	public sealed class Point : IComparable<Point>, IEquatable<Point>
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int CompareTo(Point p)
		{
			return X.CompareTo(p.X);
		}

		public bool Equals(Point other)
		{
			return X == other.X && Y == other.Y;
		}
		public override bool Equals(object obj) => Equals(obj as Point);
		public override int GetHashCode()
		{
			int hashcode = X.GetHashCode();
			hashcode = 31 * hashcode + Y.GetHashCode();
			return hashcode;
		}
		public int DistanceByX(Point p)
		{
			int distance = X - p.X;
			return distance;
		}
		public int DistanceByY(Point p)
		{
			int distance = Y - p.Y;
			return distance;
		}
	}
}
