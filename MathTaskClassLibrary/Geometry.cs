using System;

namespace MathTaskClassLibrary
{
    public class Geometry
    {
        public int RectangleArea(int a, int b)
        {
            return a * b;
        }
        public int InCorrectRectangleArea(int a, int b)
        {
            return a * b + 10;
        }
        public double CylinderVolume(double r, double h)
        {
            return Math.Round(22.0 / 7 * r * r * h, 2);
        }
        public double[] QuadraticFunction(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            double[] m = new double[2];
            if (D >= 0)
            {
                m[0] = Math.Round((-b + Math.Sqrt(D)) / (2 * a), 2);
                m[1] = Math.Round((-b - Math.Sqrt(D)) / (2 * a), 2);
            }
            return m;
        }
    }
}
