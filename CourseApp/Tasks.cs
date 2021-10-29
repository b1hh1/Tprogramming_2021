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
            if (dx > 0)
            {
                int g = (int)Math.Round(Math.Abs((xk - xn) / dx)) + 1;
                double[] results = new double[g];
                int i = 0;
                for (double j = xn; j <= xk; j = j + dx)
                {
                    results[i] = Function(j);
                    i++;
                }

                return results;
            }
            else if (dx < 0)
            {
                int g = (int)(int)Math.Round(Math.Abs((xk - xn) / dx)) + 1;
                double[] results = new double[g];
                int i = 0;
                for (double j = xn; j >= xk; j = j + dx)
                {
                    results[i] = Function(j);
                    i++;
                }

                return results;
            }
            else
            {
                double[] results = { };
                return results;
            }
        }

        public double[] TaskB(double[] numbers)
        {
            double[] results = new double[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                results[i] = Function(numbers[i]);
            }

            return results;
        }
    }
}
