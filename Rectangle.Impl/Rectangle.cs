using System;

namespace Rectangle.Impl
{
	public sealed class Rectangle : IEquatable<Rectangle>
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }

		public bool Equals(Rectangle other)
		{
			return X == other.X && Y == other.Y && Height == other.Height && Width == other.Width;
		}
		public override bool Equals(object obj) => Equals(obj as Rectangle);
		public override int GetHashCode()
		{
			int hashcode = X.GetHashCode();
			hashcode = 31 * hashcode + Y.GetHashCode();
			hashcode = 31 * hashcode + Height.GetHashCode();
			hashcode = 31 * hashcode + Width.GetHashCode();
			return hashcode;
		}
	}
}
