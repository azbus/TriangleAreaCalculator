using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleAreaCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleAreaCalculator.Tests
{
    [TestClass()]
    public class AreaCalculatorTests
    {
        [TestMethod()]
        public void calculateTriangleAreaWithSides_4_4_4()
        {
            double expectedValue = 6.928203230275509;

            double a = 4.0;
            double b = 4.0;
            double c = 4.0;
            double area = AreaCalculator.calculateAnyTriangleArea(a, b, c);

            Assert.AreEqual(expectedValue, area);
        }

        [TestMethod()]
        public void calculateRightTriangleAreaWithSides_2_2()
        {
            double expectedValue = 2.0;

            double a = 2.0;
            double b = 2.0;
            double area = AreaCalculator.calculateRightTriangleArea(a, b);

            Assert.AreEqual(expectedValue, area);
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception),
            "Такого треугольника не существует!")]
        public void calculateTriangleArea_WithWrongSides()
        {
            double a = 40.0;
            double b = 4.0;
            double c = 4.0;
            double area = AreaCalculator.calculateAnyTriangleArea(a, b, c);
        }
    }
}