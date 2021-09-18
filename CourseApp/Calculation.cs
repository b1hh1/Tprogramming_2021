namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using static System.Math;

    public class Calculation
    {
        public void TaskA(double a, double xn, double xk, double dx)
        {
            var listA = new List<double>();
            for (var x = xn; x <= xk; x += dx)
            {
                listA.Add(Function(a, x));
            }

            foreach (var y in listA)
            {
                Console.WriteLine($"y = {y}");
            }
        }

        public void TaskB(double a, List<double> xs)
        {
            var listB = new List<double>();
            foreach (var x in xs)
            {
                listB.Add(Function(a, x));
            }

            foreach (var y in listB)
            {
                Console.WriteLine($"y = {y}");
            }
        }

        public double Function(double a, double x)
        {
            var y = Pow(a, Pow(x, 2.0) - 1.0) - Log10(Pow(x, 2.0) - 1.0) - Pow(Pow(x, 2.0) - 1.0, 1.0 / 3.0);
            return Round(y, 4);
        }
    }
}