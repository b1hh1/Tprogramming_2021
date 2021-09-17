namespace CourseApp
{
    using System;
    using static System.Math;

    public class Program
    {
        public static void Main(string[] args)
        {
            var a = 2.0;
            var b = 3.0;
            double[][] array = new double[2][];
            array[0] = new double[] { 0.11, 0.36, 0.05 };
            array[1] = new double[] { 0.08, 0.026, 0.35, 0.41, 0.51 };
            ConsoleOutput(a, b, array);
            Console.ReadLine();
        }

        public static void RefillArray(double[][] array)
        {
            double[] arr = array[0];
            var newArrLength = ((arr[1] - arr[0]) / arr[2]) + 1;
            Array.Resize(ref array[0], (int)newArrLength);
            for (var i = 0; i < newArrLength; i++)
            {
                array[0][i] = arr[0] + (arr[2] * i);
            }
        }

        public static double Calculate(double a, double b, double item)
        {
            var sin = Asin(Pow(item, a));
            var cos = Acos(Pow(item, b));
            return Round(sin + cos, 3);
        }

        public static void ConsoleOutput(double a, double b, double[][] array)
        {
            RefillArray(array);
            var i = 0;
            do
            {
                var j = 1;
                Console.WriteLine($"Task {i + 1}:");
                foreach (double item in array[i])
                {
                    Console.WriteLine($" {j}) x = {item}  y = {Calculate(a, b, item)}");
                    j++;
                }

                i++;
            }
            while (i < 2);
        }
    }
}