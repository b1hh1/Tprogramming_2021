namespace CourseApp
{
    using System;
    using static System.Math;

    public class Program
    {
        public static void Main(string[] args)
        {
            double a = 2.0;
            double b = 3.0;
            double y = 0;
            double xStart = 0.11;
            double xEnd = 0.36;
            double xDelta = 0.05;
            double[] xArr = { 0.08, 0.026, 0.35, 0.41, 0.51 };
            Console.WriteLine($"Task A (a = {a}; b = {b}; xStart = {xStart}; xEnd = {xEnd}; xDelta = {xDelta})");
            CalculateTaskA(a, b, y, xStart, xEnd, xDelta);
            Console.WriteLine(" ");
            Console.WriteLine($"Task B (a = {a}; b = {b}; x1 = {xArr[0]}; x2 = {xArr[1]}; x3 = {xArr[2]}; x4 = {xArr[3]}; x5 = {xArr[4]})");
            CalculateTaskB(a, b, y, xArr);
            Console.ReadLine();
        }

        public static void CalculateTaskA(double a, double b, double y, double xStart, double xEnd, double xDelta)
        {
            for (double x = xStart; x < xEnd; x += xDelta)
            {
                Console.WriteLine($"  y = {Round(Asin(Pow(x, a)) + Acos(Pow(x, b)), 4)}");
            }
        }

        public static void CalculateTaskB(double a, double b, double y, double[] xArr)
        {
            for (int i = 0; i < xArr.Length; i++)
            {
                Console.WriteLine($"  y = {Round(Asin(Pow(xArr[i], a)) + Acos(Pow(xArr[i], b)), 4)}");
            }
        }
    }
}
