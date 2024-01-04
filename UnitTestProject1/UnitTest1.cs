using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        shapeControl ctrl = new shapeControl();

        //Method for unit test to Draw Line
        [TestMethod]
        public void TestDrawLine()
        {
            ctrl.DrawLine(100, 300);
            Assert.IsTrue(shapeValue.isUnitTestValid);
        }
        //Method for unit test to Draw Square
        [TestMethod]
        public void TestSquare()
        {
            ctrl.DrawSquare(25);
            Assert.IsTrue(shapeValue.isUnitTestValid);
        }
        //Method for unit to Draw Circle
        [TestMethod]
        public void TestCircle()
        {
            ctrl.DrawCircle(25);
            Assert.IsTrue(shapeValue.isUnitTestValid);
        }

        //Method for unit test to Move pen
        [TestMethod]
        public void TestMove()
        {
            ctrl.MovePoint(20, 100);
            Assert.IsTrue(shapeValue.isUnitTestValid);
        }

        //Method for unit test to Draw Triangle
        [TestMethod]
        public void TestTriangle()
        {
            ctrl.DrawTriangle(120, 150, 170);
            Assert.IsTrue(shapeValue.isUnitTestValid);
        }
        //Method for unit test to Draw Rectangle
        [TestMethod]
        public void TestRectangle()
        {
            ctrl.DrawRect(100, 300);
            Assert.IsTrue(shapeValue.isUnitTestValid);
        }

    }
}
