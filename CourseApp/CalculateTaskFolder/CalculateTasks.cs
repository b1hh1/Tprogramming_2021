namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using static System.Math;

    public class CalculateTasks
    {
        public CalculateTasks(double a, double b)
        {
            var xStart = 0.11;
            var xEnd = 0.36;
            var xDelta = 0.05;
            var listTaskOne = new List<double>() { };
            var listTaskTwo = new List<double>() { 0.08, 0.026, 0.35, 0.41, 0.51 };
            TaskCalculate(a, b, xStart, xEnd, xDelta, listTaskOne, listTaskTwo);
        }

        public CalculateTasks()
        {
            var a = 3.0;
            var b = 2.0;
            var xStart = 0.11;
            var xEnd = 0.36;
            var xDelta = 0.05;
            var listTaskOne = new List<double>() { };
            var listTaskTwo = new List<double>() { 0.08, 0.026, 0.35, 0.41, 0.51 };
            TaskCalculate(a, b, xStart, xEnd, xDelta, listTaskOne, listTaskTwo);
        }

        public double Calculate(double a, double b, double item)
        {
            var sin = Asin(Pow(item, a));
            var cos = Acos(Pow(item, b));
            return sin + cos;
        }

        private void FillTaskOneList(double a, double b, double xStart, double xEnd, double xDelta, List<double> listTaskOne)
        {
            for (double x = xStart; x <= xEnd; x += xDelta)
            {
                listTaskOne.Add(x);
            }

            var listSize = listTaskOne.Count;
            for (int i = 0; i < listSize; i++)
            {
                listTaskOne.Add(Calculate(a, b, (double)listTaskOne[i]));
            }
        }

        private void FillTaskTwoList(double a, double b, List<double> listTaskTwo)
        {
            var listSize = listTaskTwo.Count;
            for (int i = 0; i < listSize; i++)
            {
                listTaskTwo.Add(Calculate(a, b, (double)listTaskTwo[i]));
            }
        }

        private void ConsoleOutput(double a, double b, List<double> listTaskOne, List<double> listTaskTwo)
        {
            string stringOutput = string.Empty;
            Console.WriteLine($"Variables: a = {a}; b = {b}");
            for (int i = 0; i < (listTaskOne.Count / 2); i++)
            {
                stringOutput += $"{i + 1}) x = {listTaskOne[i]}  y = {listTaskOne[(listTaskOne.Count / 2) + i]:f2}  ";
            }

            Console.WriteLine($"Task 1: {stringOutput}");
            stringOutput = string.Empty;
            for (int i = 0; i < (listTaskTwo.Count / 2); i++)
            {
                stringOutput += $"{i + 1}) x = {listTaskTwo[i]}  y = {listTaskTwo[(listTaskTwo.Count / 2) + i]:f2}  ";
            }

            Console.WriteLine($"Task 2: {stringOutput} \n");
        }

        private void TaskCalculate(double a, double b, double xStart, double xEnd, double xDelta, List<double> listTaskOne, List<double> listTaskTwo)
        {
            FillTaskOneList(a, b, xStart, xEnd, xDelta, listTaskOne);
            FillTaskTwoList(a, b, listTaskTwo);
            ConsoleOutput(a, b, listTaskOne, listTaskTwo);
        }
    }
}