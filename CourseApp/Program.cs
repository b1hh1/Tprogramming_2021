namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            const double a = 4.1;
            const double b = 2.7;
            var funcalc = new FunctionCalculator();
            Console.WriteLine("Calculating task A\n");
            funcalc.TaskA(1.5, 3.5, 0.4, a, b);
            double[] nums = new double[] { 1.9, 2.15, 2.34, 2.74, 3.16 };
            Console.WriteLine("Calculating task B\n");
            funcalc.TaskB(nums, a, b);
            Console.ReadKey();
        }
    }
}
