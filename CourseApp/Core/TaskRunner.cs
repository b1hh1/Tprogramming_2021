namespace CourseApp.Core
{
    using System;
    using Kantaiko.ConsoleFormatting;

    public static class TaskRunner
    {
        public static void Run<T>()
            where T : ITask, new()
        {
            Console.WriteLine(Colors.FgCyan(new string('=', 32)));
            Console.WriteLine(Colors.FgCyan($"Running task: {typeof(T).Name}"));
            Console.WriteLine(Colors.FgCyan(new string('=', 32)));

            var task = Activator.CreateInstance<T>();
            task.Execute();

            Console.WriteLine(Colors.FgCyan(new string('=', 32)));
        }
    }
}
