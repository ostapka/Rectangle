using NUnit.Framework;

namespace Rectangle.Tests
{
    class RectangleTests
    {
        [Test]
        public void RectangleEquals()
        {
            //arrange
            Impl.Rectangle actual = new Impl.Rectangle()
            {
                X = 2,
                Y = 1,
                Height = 2,
                Width = 1
            };
            Impl.Rectangle expected = new Impl.Rectangle()
            {
                X = 2,
                Y = 1,
                Height = 2,
                Width = 1
            };
            //act
            bool result = actual.Equals(expected);
            //assert
            Assert.IsTrue(result);
        }
        [Test]
        public void RectangleNotEquals()
        {
            //arrange
            Impl.Rectangle actual = new Impl.Rectangle()
            {
                X = 2,
                Y = 2,
                Height = 2,
                Width = 1
            };
            Impl.Rectangle expected = new Impl.Rectangle()
            {
                X = 2,
                Y = 1,
                Height = 2,
                Width = 1
            };
            //act
            bool result = actual.Equals(expected);
            //assert
            Assert.IsFalse(result);
        }
    }
}
