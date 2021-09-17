namespace CourseApp
{
    using System;
    using System.Collections;
    using static System.Math;

    public class Program
    {
        public static void Main(string[] args)
        {
            var a = 2.0;
            var b = 3.0;
            ArrayList listTaskOne = new ArrayList() { 0.11, 0.36, 0.05 };
            ArrayList listTaskTwo = new ArrayList() { 0.08, 0.026, 0.35, 0.41, 0.51 };
            CalculateTasks(a, b, listTaskOne, listTaskTwo);
            Console.ReadLine();
        }

        public static void FillTaskOneArrayList(double a, double b, ArrayList listTaskOne)
        {
            var xStart = (double)listTaskOne[0];
            var xEnd = (double)listTaskOne[1];
            var xDelta = (double)listTaskOne[2];
            listTaskOne.Clear();
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

        public static void FillTaskTwoArrayList(double a, double b, ArrayList listTaskTwo)
        {
            var listSize = listTaskTwo.Count;
            for (int i = 0; i < listSize; i++)
            {
                listTaskTwo.Add(Calculate(a, b, (double)listTaskTwo[i]));
            }
        }

        public static double Calculate(double a, double b, double item)
        {
            var sin = Asin(Pow(item, a));
            var cos = Acos(Pow(item, b));
            return Round(sin + cos, 3);
        }

        public static void ConsoleOutput(ArrayList listTaskOne, ArrayList listTaskTwo)
        {
            Console.WriteLine("Task 1:");
            for (int i = 0; i < (listTaskOne.Count / 2); i++)
            {
                Console.WriteLine($"  {i + 1}) x = {listTaskOne[i]}  y = {listTaskOne[(listTaskOne.Count / 2) + i]}");
            }

            Console.WriteLine("Task 2:");
            for (int i = 0; i < (listTaskTwo.Count / 2); i++)
            {
                Console.WriteLine($"  {i + 1}) x = {listTaskTwo[i]}  y = {listTaskTwo[(listTaskTwo.Count / 2) + i]}");
            }
        }

        public static void CalculateTasks(double a, double b, ArrayList listTaskOne, ArrayList listTaskTwo)
        {
            FillTaskOneArrayList(a, b, listTaskOne);
            FillTaskTwoArrayList(a, b, listTaskTwo);
            ConsoleOutput(listTaskOne, listTaskTwo);
        }
    }
}