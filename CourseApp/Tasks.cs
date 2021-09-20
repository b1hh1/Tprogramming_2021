namespace CourseApp
{
    using System;

    public class Tasks
    {
        public double Function(double x = 0)
        {
            double sinAngle = Math.Sin(x);
            double cosAngle = Math.Cos(x);
            return ((sinAngle * sinAngle * sinAngle) + (cosAngle * cosAngle * cosAngle)) * Math.Log(x);
        }

        public double[] TaskA(double xn, double xk, double dx)
        {
            int g = (int)(((xk - xn) / dx) + 1);
            double[] results = new double[g];
            int i = 0;
            while (xn <= xk)
            {
                results[i] = Function(xn);
                i++;
                xn = xn + dx;
            }

            return results;
        }

        public double[] TaskB(double[] numbers)
        {
            double[] results = new double[numbers.Length];
            int g = 0;
            foreach (double i in numbers)
            {
                results[g] = Function(i);
                g++;
            }

            return results;
        }
    }
}
