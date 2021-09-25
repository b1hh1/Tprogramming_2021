namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using Kantaiko.ConsoleFormatting;

    public class Calc
    {
        public Calc()
        {
            var a = 0.8;
            var b = 0.4;
            var xs = 1.23;
            var xe = 7.23;
            var dx = 1.2;
            var listA = new List<double>();
            var listB = new List<double>();
            var listTaskB = new List<double>() { 1.88, 2.26, 3.84, 4.55, -6.21 };
            TaskFunction(a, b, xs, xe, dx, listTaskB, listA, listB);
        }

        public void CalcTaskA(double a, double b, double xs, double xe, double dx, List<double> listA)
        {
            for (double x = xs; x <= xe; x += dx)
            {
                listA.Add(x);
            }

            var size = Math.Ceiling((xe - xs) / dx) + 1; // calculation of quantity y in the resulting list
            for (double x = xs; x <= xe; x += dx)
            {
                listA.Add(CalcFunc(a, b, x));
            }
        }

        public void CalcTaskB(double a, double b, List<double> listTaskB, List<double> listB)
        {
            var size = listTaskB.Count;
            for (int i = 0; i < size; i++)
            {
                listB.Add(listTaskB[i]);
            }

            for (int i = 0; i < size; i++)
            {
                listB.Add(CalcFunc(a, b, (double)listTaskB[i]));
            }
        }

        public double CalcFunc(double a, double b, double x)
        {
            return Math.Round((Math.Pow(Math.Pow(x - a, 2), 1.0 / 3.0) + Math.Pow(Math.Abs(x + b), 1.0 / 5.0)) / Math.Pow(Math.Pow(x, 2) - Math.Pow(a - b, 2), 1.0 / 9.0), 3);
        }

        public void OutputA(List<double> listA)
        {
            Console.WriteLine(Colors.FgCyan("-----------Task A-----------").BgMagenta());
            for (int i = 0; i < (listA.Count / 2); i++)
            {
                Console.WriteLine(Colors.FgCyan($"x = {listA[i]}  y = {listA[(listA.Count / 2) + i]}").BgMagenta()); // x - the first element, y - the first element from the middle
            }
        }

        public void OutputB(List<double> listB)
        {
            Console.WriteLine(Colors.FgCyan("-----------Task B-----------").BgMagenta());
            for (int i = 0; i < (listB.Count / 2); i++)
            {
                Console.WriteLine(Colors.FgCyan($"x = {listB[i]}  y = {listB[(listB.Count / 2) + i]}").BgMagenta());
            }
        }

        public void TaskFunction(double a, double b, double xs, double xe, double dx, List<double> listTaskB, List<double> listA, List<double> listB)
        {
            CalcTaskA(a, b, xs, xe, dx, listA);
            CalcTaskB(a, b, listTaskB, listB);
            OutputA(listA);
            OutputB(listB);
        }
    }
}