namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using Kantaiko.ConsoleFormatting;

    public class TaskRunner
    {
        private readonly Function _function;

        public TaskRunner()
        {
            _function = new Function();
        }

        public void Calculation(double a, double xn, double xk, double dx)
        {
            var listA = new List<double>();
            for (var x = xn; x <= xk; x += dx)
            {
                listA.Add(_function.CalculateFunction(a, x));
            }

            ConsoleOutput(listA);
        }

        public void Calculation(double a, List<double> xs)
        {
            var listB = new List<double>();
            foreach (var x in xs)
            {
                listB.Add(_function.CalculateFunction(a, x));
            }

            ConsoleOutput(listB);
        }

        private static void ConsoleOutput(List<double> ys)
        {
            foreach (var y in ys)
            {
                Console.WriteLine(Colors.FgCyan($"y = {y}").BgBlack());
            }
        }
    }
}