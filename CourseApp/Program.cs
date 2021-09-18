namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var execution = new Calculation();
            var a = 1.6;
            var xn = 1.2;
            var xk = 3.7;
            var dx = 0.5;
            Console.WriteLine("-----TASK A-----");
            execution.TaskA(a, xn, xk, dx);
            var xs = new List<double>() { 1.28, 1.36, 2.47, 3.68, 4.56 };
            Console.WriteLine("-----TASK B-----");
            execution.TaskB(a, xs);
        }
    }
}
