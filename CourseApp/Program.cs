namespace CourseApp
{
    using System;
    using static System.Math;

    public class Program
    {
        public static void Main(string[] args)
        {
            const double a = 2.0;
            const double b = 3.0;
            double[] taskOneArray = { 0.11, 0.36, 0.05 };
            double[] taskTwoArray = { 0.08, 0.026, 0.35, 0.41, 0.51 };
            Console.WriteLine($"Task A (a = {a}; b = {b}; xStart = {taskOneArray[0]}; xEnd = {taskOneArray[1]}; xDelta = {taskOneArray[2]})");
            CalculateTaskA(a, b, taskOneArray);
            Console.WriteLine($"Task B (a = {a}; b = {b}; x1 = {taskTwoArray[0]}; x2 = {taskTwoArray[1]}; x3 = {taskTwoArray[2]}; x4 = {taskTwoArray[3]}; x5 = {taskTwoArray[4]})");
            CalculateTaskB(a, b, taskTwoArray);
            Console.ReadLine();
        }

        public static void CalculateTaskA(double a, double b, double[] taskOneArray)
        {
            for (double x = taskOneArray[0]; x < taskOneArray[1]; x += taskOneArray[2])
            {
                Console.WriteLine($"  y = {Round(Asin(Pow(x, a)) + Acos(Pow(x, b)), 4)}");
            }
        }

        public static void CalculateTaskB(double a, double b, double[] taskTwoArray)
        {
            for (int i = 0; i < taskTwoArray.Length; i++)
            {
                Console.WriteLine($"  y = {Round(Asin(Pow(taskTwoArray[i], a)) + Acos(Pow(taskTwoArray[i], b)), 4)}");
            }
        }
    }
}
