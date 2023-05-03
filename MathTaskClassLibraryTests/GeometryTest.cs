using MathTaskClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTest
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            //исходные данные
            int a = 3;
            int b = 5;
            int expected = 15;

            //получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            //сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InCorrectRectangleArea_3and5_15returned()
        {
            //исходные данные
            int a = 3;
            int b = 5;
            int expected = 15;

            //получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            int actual = g.InCorrectRectangleArea(a, b);

            //сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CylinderVolume_35and4_154returned()
        {
            //исходные данные
            double r = 3.5;
            double h = 4;
            double expected = 154;

            //получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.CylinderVolume(r, h);

            //сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuadraticFunction_1and3and2_returnedminus1andminus2()
        {
            double a = 1;
            double b = 3;
            double c = 2;
            double[] expected = { -1,-2};

            Geometry g = new Geometry();
            double[] actual = g.QuadraticFunction(a, b, c);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuadraticFunction_2and4and2_returnedminus1()
        {
            double a = 2;
            double b = 4;
            double c = 2;
            double[] expected = { -1, -1 };

            Geometry g = new Geometry();
            double[] actual = g.QuadraticFunction(a, b, c);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void QuadraticFunction_2and3and4_returnednull()
        {
            double a = 2;
            double b = 3;
            double c = 4;
            double[] expected = new double[2];

            Geometry g = new Geometry();
            double[] actual = g.QuadraticFunction(a, b, c);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
