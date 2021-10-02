namespace CourseApp
{
    using System;

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

        public void TaskA(double xStart, double xEnd, double dX, double a, double b)
        {
            for (double x = xStart; x < xEnd; x += dX)
            {
                Function(a, b, x);
            }
        }

        public void TaskB(double[] nums, double a, double b)
        {
            foreach (double num in nums)
            {
                Function(a, b, num);
            }
        }
    }
}
