namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var calculateTasks = new CalculateTasks();
            calculateTasks.StartCalculate();
            Console.ReadLine();
        }
    }
}