using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Rectangle.Impl;

namespace Rectangle.Tests
{
    class PointTests
    {
        [Test]
        public void PointCompareTo()
        {
            //arrange
            Point point1 = new Point() { X = 3, Y = 2};
            Point point2 = new Point() { X = 2, Y = 2 };
            int expected = 1;
            //act
            int actual = point1.CompareTo(point2);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PointEquals()
        {
            //arrange
            Point actual = new Point() { X = 3, Y = 2 };
            Point expected = new Point() { X = 3, Y = 2 };
            //act
            bool result = actual.Equals(expected);
            //assert
            Assert.IsTrue(result);
        }
        [Test]
        public void PointNotEquals()
        {
            //arrange
            Point actual = new Point() { X = 3, Y = 2 };
            Point expected = new Point() { X = 1, Y = 2 };
            //act
            bool result = actual.Equals(expected);
            //assert
            Assert.IsFalse(result);
        }
        [Test]
        public void PointDistanceByX()
        {
            //arrange
            Point point1 = new Point() { X = 3, Y = 2 };
            Point point2 = new Point() { X = 2, Y = 2 };
            int expected = 1;
            //act
            int actual = point1.DistanceByX(point2);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PointDistanceByY()
        {
            //arrange
            Point point1 = new Point() { X = 2, Y = 3 };
            Point point2 = new Point() { X = 2, Y = 2 };
            int expected = 1;
            //act
            int actual = point1.DistanceByY(point2);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
