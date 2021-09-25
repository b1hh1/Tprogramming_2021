namespace CourseApp.Tasks.MathTask
{
    using System;
    using CourseApp.Core;
    using Kantaiko.ConsoleFormatting;

    public class MathTask : ITask
    {
        private readonly MathTaskService _mathTaskService;

        public MathTask()
        {
            _mathTaskService = new MathTaskService();
        }

        public void Execute()
        {
            RunCalculateDeltaRange(0.2, 2.2, 0.4);

            RunCalculateValuesRange(new[]
            {
                0.1,
                0.9,
                1.2,
                1.5,
                2.3,
            });
        }

        private void RunCalculateDeltaRange(double xStart, double xEnd, double xDelta)
        {
            Console.WriteLine(Colors.FgCyan($">>>>> Calculating in range from {xStart} to {xEnd} with delta {xDelta}"));

            var results = _mathTaskService.CalculateRange(xStart, xEnd, xDelta);

            foreach (var (x, y) in results)
            {
                Console.WriteLine(Colors.FgHex(
                    $"{nameof(x)}={x}\t" +
                    $"{nameof(y)}={y}", "#FFCC00"));
            }
        }

        private void RunCalculateValuesRange(double[] xs)
        {
            Console.WriteLine(Colors.FgCyan($">>>>> Calculating with values {string.Join(", ", xs)}"));

            var results = _mathTaskService.CalculateRange(xs);

            foreach (var (x, y) in results)
            {
                Console.WriteLine(Colors.FgHex(
                    $"{nameof(x)}={x}\t" +
                    $"{nameof(y)}={y}", "#FFCC00"));
            }
        }
    }
}
