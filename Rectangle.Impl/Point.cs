using System;

namespace Rectangle.Impl
{
	public sealed class Point : IEquatable<Point>
	{
		public int X { get; set; }
		public int Y { get; set; }
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
	}
}
