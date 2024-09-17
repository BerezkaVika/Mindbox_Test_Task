using LibraryFigures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SquareOfTriangle_NotCorrect()
        {
            Action throwingAction = () => { Triangle triangle = new Triangle("Треугольник", -7, 0, 5); };

            var exception = Assert.ThrowsException<ArgumentException>(throwingAction);

            Assert.AreEqual("Все 3 стороны треугольника должны быть больше 0!", exception.Message);
        }

        [TestMethod]
        public void SquareOfTriangle_Correct()
        {
            Triangle triangle = new Triangle("Треугольник", 3, 4, 5);
            double expected = 6;

            double result = triangle.AreaOfFigure();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void isRightTriangle_NotRightTriangle()
        {
            Triangle triangle = new Triangle("Треугольник", 2, 3, 4);

            bool result = triangle.IsRightTriangle();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void isRightTriangle_RightTriangle()
        {
            Triangle triangle = new Triangle("Треугольник", 3, 5, 4);

            bool result = triangle.IsRightTriangle();

            Assert.IsTrue(result);
        }

    }

    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Square_5_Return78_5()
        {
            //Arrange
            Circle circle = new Circle("Круг", 8);
            double expected = 201.06;

            var result = circle.AreaOfFigure();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}

