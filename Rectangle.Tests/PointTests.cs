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
    }
}
