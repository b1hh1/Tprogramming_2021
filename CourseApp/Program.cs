namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            double a = 2.0f;
            double b = 3.0f;
            double y = 0;
            CalcFunc(a, b, y);
            Console.ReadLine();
        }

        public static void CalcFunc(double a, double b, double y)
        {
            for (float x_start = 0.11f; x_start < 0.36f; x_start += 0.05f)
            {
                y = Math.Asin(Math.Pow(x_start, a)) + Math.Acos(Math.Pow(x_start, b));
                Console.WriteLine("y = " + y);
            }
        }
    }
}
