namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class FunctionCalculator
    {
        public double Function(double a, double b, double x)
        {
            double num = (a * Math.Pow(x, 1.0 / 3.0)) - (b * Math.Log10(x) / Math.Log10(5.0));
            double denum = Math.Pow(Math.Log10(x - 1), 3.0);
            double y = num / denum;
            Console.WriteLine(y);
            return y;
        }

        public List<double> TaskA(double xStart, double xEnd, double dX, double a, double b)
        {
            List<double> res = new List<double>();
            for (double x = xStart; x < xEnd; x += dX)
            {
                res.Add(Function(a, b, x));
            }

            return res;
        }

        public List<double> TaskB(double[] nums, double a, double b)
        {
            List<double> res = new List<double>();
            foreach (double num in nums)
            {
                res.Add(Function(a, b, num));
            }

            return res;
        }
    }
}
