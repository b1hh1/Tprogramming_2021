namespace CourseApp
{
    using System;

    public class Tasks
    {
        public double[] TaskA(double xn, double xk, double dx)
        {
            if (dx != 0)
            {
                int g = (int)Math.Round(Math.Abs((xk - xn) / dx)) + 1;
                double[] result = new double[g];
                int i = 0;
                for (double j = xn; j <= xk; j += dx)
                {
                    result[i] = Function(j);
                    i++;
                }

                return result;
            }

            double[] results = { };
            return results;
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

        public double Function(double x = 0)
        {
            return (Math.Pow(Math.Sin(x), 3) + Math.Pow(Math.Cos(x), 3)) * Math.Log(x);
        }
    }
}
