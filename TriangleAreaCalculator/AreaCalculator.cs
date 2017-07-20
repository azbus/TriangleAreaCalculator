using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleAreaCalculator
{
    public class AreaCalculator
    {
        private AreaCalculator() { }
        public static double calculateRightTriangleArea(double a, double b)
        {
            
            double area = 0.5 * a * b;
            return area;
        }

        public static double calculateAnyTriangleArea(double a, double b, double c)
        {
            if (a + b <= c || b + c <= a || c + a <= b)
                throw new Exception("Такого треугольника не существует!");

            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

    }
}
