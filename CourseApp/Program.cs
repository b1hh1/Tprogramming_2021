namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine(calc.Multi(5, 10));
            Console.ReadLine();
            var task = new Tasks();
            double[] taskA = task.TaskA(0.11, 0.36, 0.05);
            foreach (double i in taskA)
                {
                    Console.WriteLine(i);
                }

            Console.ReadLine();
            double[] num = { 0.2, 0.3, 0.38, 0.43, 0.57 };
            double[] taskB = task.TaskB(num);
            foreach (double i in taskB)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
