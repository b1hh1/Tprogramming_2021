namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using static System.Math;

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
            Console.WriteLine("In this program you can:\r\n1 - Calculate with default values\r\n2 - Calculate with custom values\r\n3 - Exit program\r\nWhat you want? Enter integer values.");
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
            Console.WriteLine("\r\nAvailable actions:\r\n1 - Back to start page\r\n2 - Exit program\r\nWhat you want? Enter integer values.");
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
            Console.WriteLine("Available actions:\r\n1 - Enter custom values\r\n2 - Back to start page\r\n3 - Exit program\r\nWhat you want? Enter integer values.");
            switch (input.InputInt(1, 4))
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
            var tpl = (task.StartCalculate(task.ListValue()), task.StartCalculate(listValues));
            Console.WriteLine($"Calculated with default values:");
            Output(tpl);
        }

        private void CalculateCustomValues(List<double> listValues)
        {
            Console.Clear();
            var input = new InputValues();
            Console.WriteLine("Enter your values:");
            Console.Write("a = ");
            var a = input.InputDouble(-Pow(10, 200), Pow(10, 200));
            Console.Write("b = ");
            var b = input.InputDouble(-Pow(10, 200), Pow(10, 200));
            Console.Write("start = ");
            var start = input.InputDouble(-Pow(10, 200), Pow(10, 200));
            Console.Write("end = ");
            var end = input.InputDouble(-Pow(10, 200), Pow(10, 200));
            Console.Write("delta = ");
            var delta = input.InputDouble(-Pow(10, 200), Pow(10, 200));
            Console.Clear();
            var task = new CalculateTasks(a, b, start, end, delta);
            var tpl = (task.StartCalculate(task.ListValue()), task.StartCalculate(listValues));
            Console.WriteLine($"Calculated with custom values:");
            Output(tpl);
        }

        private void CustomCalculations(List<double> listValues)
        {
            var input = new InputValues();
            Console.Clear();
            CalculateCustomValues(listValues);
            Console.WriteLine("Available actions:\r\n1 - Calculate with another custom values\r\n2 - Back to previous page\r\n3 - Exit program\r\nWhat you want? Enter integer values.");
            switch (input.InputInt(1, 2))
            {
                case 1:
                    CalculateCustomValues(listValues);
                    break;

                case 2:
                    CustomPage(listValues);
                    break;

                case 3:
                    Environment.Exit(0);
                    break;
            }
        }

        private void Output((List<(double, double)>, List<(double, double)>) tpl)
        {
            Console.WriteLine("Task A:");
            for (int i = 0; i < tpl.Item1.Count; i++)
            {
                Console.WriteLine($"  x = {tpl.Item1[i].Item1:f2} y = {tpl.Item1[i].Item2:f2}");
            }

            Console.WriteLine("Task B:");
            for (int i = 0; i < tpl.Item2.Count; i++)
            {
                Console.WriteLine($"  x = {tpl.Item1[i].Item1:f2} y = {tpl.Item1[i].Item2:f2}");
            }
        }
    }
}