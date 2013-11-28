using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class TriangelUnitTest
    {

        [TestMethod]
        // Likbent
        public void isIsoscelesTest()
        {
            // Borde bli True då trianglen är likbent
            Triangle isIsosceles = new Triangle(1.0, 1.0, 2.0);
            Assert.IsTrue(isIsosceles.isIsosceles());

            // Borde bli False då trianglen är liksidig
            Triangle isIsosceles2 = new Triangle(1.0, 1.0, 1.0);
            Assert.IsFalse(isIsosceles2.isIsosceles());

            // Borde bli False då trianglen inte har några lika sidor
            Triangle isIsosceles3 = new Triangle(1.0, 2.0, 3.0);
            Assert.IsFalse(isIsosceles3.isIsosceles());
        }

        [TestMethod]
        // Oliksidig
        public void isScaleneTest()
        {
            // Borde bli True då trianglen inte har några lika sidor
            Triangle isScalene = new Triangle(1.0, 2.0, 3.0);
            Assert.IsTrue(isScalene.isScalene());

            // Borde bli False då trianglen är liksidig
            Triangle isScalene2 = new Triangle(1.0, 1.0, 1.0);
            Assert.IsFalse(isScalene2.isScalene());

            // Borde bli False då trianglen är likbent
            Triangle isScalene3 = new Triangle(1.0, 1.0, 2.0);
            Assert.IsFalse(isScalene3.isScalene());
        }

        [TestMethod]
        // Liksidig
        public void isEquilateralTest()
        {
            // Borde bli True då trianglen är liksidig
            Triangle isEquilateral = new Triangle(1.0, 1.0, 1.0);
            Assert.IsTrue(isEquilateral.isEquilateral());

            // Borde bli False då trianglen är likbent
            Triangle isEquilateral2 = new Triangle(1.0, 1.0, 2.0);
            Assert.IsFalse(isEquilateral2.isEquilateral());

            // Borde bli True då trianglen inte har några lika sidor
            Triangle isEquilateral3 = new Triangle(1.0, 2.0, 3.0);
            Assert.IsFalse(isEquilateral3.isEquilateral());
        }

        [TestMethod]
        // Testar Konstruktorn i triangel som tar tre emot tre double värden som argument
        public void TriangelConstructorThreeDoublesTest()
        {
            Triangle test = new Triangle(1.0, 1.0, 1.0);
            Assert.IsInstanceOfType(test, typeof(Triangle));
        }

        [TestMethod]
        // Testar Konstruktorn i triangel som tar emot en double array som argument
        public void TriangelConstructorDoubleArrayTest()
        {
            double[] arr = { 1.0, 1.0, 1.0 };
            Triangle test = new Triangle(arr);
            Assert.IsInstanceOfType(test, typeof(Triangle));
        }

        [TestMethod]
        // Testar Konstruktorn i triangel som tar emot tre point objekt som argument
        public void TriangelConstructorThreePointsTest()
        {
            Point a = new Point(0, 0);
            Point b = new Point(1, 0);
            Point c = new Point(1, 2);
            Triangle test = new Triangle(a, b, c);
            Assert.IsInstanceOfType(test, typeof(Triangle));
        }

        [TestMethod]
        // Testar Konstruktorn i triangel som tar emot en point array som argument
        public void TriangelConstructorPointArrayTest()
        {
            Point[] arr = { new Point(0, 0), new Point(1, 0), new Point(1, 2) };
            Triangle test = new Triangle(arr);
            Assert.IsInstanceOfType(test, typeof(Triangle));
        }

        [TestMethod]
        // Testar Konstruktorn i point som tar tre emot tre int värden som argument
        public void PointConstructorTest()
        {
            Point test = new Point(1, 1);
            Assert.IsInstanceOfType(test, typeof(Point));
        }

    }
}
