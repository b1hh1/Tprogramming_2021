namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("_CalculateTasks_");
            var calculateTasksOne = new CalculateTasks(3, 2);
            var calculateTasksTwo = new CalculateTasks();
            Console.WriteLine("_ClassTask_");
            var classTaskOne = new ClassTask("VS Code", ".exe", 1.5, "GB");
            var classTaskTwo = new ClassTask();
            Console.ReadLine();
        }
    }
}