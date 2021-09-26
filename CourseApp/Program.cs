namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using Kantaiko.ConsoleFormatting;

    public static class Program
    {
        public static void Main(string[] args)
        {
            var execution = new TaskRunner();
            var a = 1.6;
            var xn = 1.2;
            var xk = 3.7;
            var dx = 0.5;
            Console.WriteLine(Colors.FgCyan("-----TASK A-----").BgBlack());
            execution.Calculation(a, xn, xk, dx);
            var xs = new List<double>() { 1.28, 1.36, 2.47, 3.68, 4.56 };
            Console.WriteLine(Colors.FgCyan("-----TASK B-----").BgBlack());
            execution.Calculation(a, xs);
        }
    }
}
