namespace CourseApp.Program
{
    using System;
    using System.Collections.Generic;
    using CourseApp.Program.Input;

    public class UserInterface
    {
        public UserInterface()
        {
            Console.WriteLine("Hello!");
        }

        public void StartProgram()
        {
            var input = new InputValues();
            var listValues = new List<double>() { 0.08, 0.026, 0.35, 0.41, 0.51 };
            Console.WriteLine(@"
In this program you can:
1 - Operate with default values
2 - Operate with custom values
3 - Exit program
What you want? Enter integer values.");
            switch (input.InputInt(1, 3))
            {
                case 1:
                    DefaultPage(listValues);
                    break;

                case 2:
                    CustomPage(listValues);
                    break;

                case 3:
                    Environment.Exit(0);
                    break;
            }
        }

        private void DefaultPage(List<double> listValues)
        {
            var input = new InputValues();
            Console.Clear();
            CalculateDefaultValues(listValues);
            Console.WriteLine(@"
Available actions:
1 - Back to start page
2 - Exit program
What you want? Enter integer values.");
            switch (input.InputInt(1, 2))
            {
                case 1:
                    Console.Clear();
                    StartProgram();
                    break;

                case 2:
                    Environment.Exit(0);
                    break;
            }
        }

        private void CustomPage(List<double> listValues)
        {
            var input = new InputValues();
            Console.Clear();
            Console.WriteLine(@"
Available actions:
1 - Enter custom values
2 - Back to start page
3 - Exit program
What you want? Enter integer values.");
            switch (input.InputInt(1, 3))
            {
                case 1:
                    CustomCalculations(listValues);
                    break;

                case 2:
                    Console.Clear();
                    StartProgram();
                    break;

                case 3:
                    Environment.Exit(0);
                    break;
            }
        }

        private void CalculateDefaultValues(List<double> listValues)
        {
            Console.Clear();
            var input = new InputValues();
            var task = new CalculateTasks(2.0, 3.0, 0.11, 0.36, 0.05);
            Console.WriteLine($"Calculated with default values:");
            Output(task.StartCalculate(task.ListValue()));
            Output(task.StartCalculate(listValues));
        }

        private void CalculateCustomValues(List<double> listValues)
        {
            Console.Clear();
            var values = InputCustomValues();
            var task = new CalculateTasks(values);
            Console.WriteLine($"Calculated with custom values:");
            Output(task.StartCalculate(task.ListValue()));
            Output(task.StartCalculate(listValues));
        }

        private void CustomCalculations(List<double> listValues)
        {
            Console.Clear();
            var input = new InputValues();
            CalculateCustomValues(listValues);
            Console.WriteLine(@"
Available actions:
1 - Calculate with another custom values
2 - Back to previous page
3 - Exit program
What you want? Enter integer values.");
            switch (input.InputInt(1, 3))
            {
                case 1:
                    CustomCalculations(listValues);
                    break;

                case 2:
                    CustomPage(listValues);
                    break;

                case 3:
                    Environment.Exit(0);
                    break;
            }
        }

        private void Output(List<(double, double)> lst)
        {
            Console.WriteLine("Task:");
            foreach (var (x, y) in lst)
            {
                Console.WriteLine($"  x = {x:f2} y = {y:f2}");
            }
        }

        private (double, double, double, double, double) InputCustomValues()
        {
            var input = new InputValues();
            Console.WriteLine("Enter your values:");
            Console.Write("a = ");
            var a = input.InputDouble(double.MinValue, double.MaxValue);
            Console.Write("b = ");
            var b = input.InputDouble(double.MinValue, double.MaxValue);
            Console.Write("start = ");
            var start = input.InputDouble(double.MinValue, double.MaxValue);
            Console.Write("end = ");
            var end = input.InputDouble(double.MinValue, double.MaxValue);
            Console.Write("delta = ");
            var delta = input.InputDouble(double.MinValue, double.MaxValue);
            return (a, b, start, end, delta);
        }
    }
}
