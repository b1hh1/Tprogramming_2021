namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            const double a = 0.8;
            const double b = 0.4;
            Console.WriteLine($"--------- TASK A --------------");
            var taskA = TaskA(a, b, 1.23, 7.23, 1.2);
            foreach (var i in taskA)
            {
                var (x, y) = i;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine($"--------- TASK B --------------");
            double[] xArray = { 1.88, 2.26, 3.84, 4.55, -6.21 };
            var taskB = TaskB(a, b, xArray);
            foreach (var i in taskB)
            {
                var (x, y) = i;
                Console.WriteLine($"x={x}, y={y}");
            }
        }

        public static double CalcFunc(double a, double b, double x)
        {
            return (Math.Pow(Math.Pow(x - a, 2), 1 / 3.0) + Math.Pow(Math.Abs(x + b), 1 / 5.0)) / Math.Pow(Math.Pow(x, 2) - Math.Pow(a - b, 2), 1 / 9.0);
        }

        public static (double x, double y)[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            var res = new (double, double)[(int)Math.Ceiling((xk - xn) / dx) + 1];
            int i = 0;
            for (var x = xn; x <= xk; x += dx)
            {
                var y = CalcFunc(a, b, x);
                res[i] = (x, y);
                i++;
            }

            return res;
        }

        public static (double x, double y)[] TaskB(double a, double b, double[] xArray)
        {
            var res = new (double, double)[xArray.Length];
            int i = 0;
            foreach (var x in xArray)
            {
                var y = CalcFunc(a, b, x);
                res[i] = (x, y);
                i++;
            }

            return res;
        }
    }
}