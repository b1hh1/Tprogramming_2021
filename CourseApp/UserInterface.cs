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

        public bool IsCalculated { get; set; }

        public void StartProgram()
        {
            var input = new InputValues();
            IsCalculated = false;
            Console.WriteLine("In this program you can:\r\n1 - Calculate with default values\r\n2 - Calculate with custom values\r\n3 - Exit program\r\nWhat you want? Enter integer values.");
            switch (input.InputInt(1, 3))
            {
                case 1:
                    DefaultPage();
                    break;

                case 2:
                    CustomPage();
                    break;

                case 3:
                    Environment.Exit(0);
                    break;
            }
        }

        private void DefaultPage()
        {
            var input = new InputValues();
            Console.Clear();
            CalculateDefaultValues();
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

        private void CustomPage()
        {
            var input = new InputValues();
            Console.Clear();
            Console.WriteLine("Available actions:\r\n1 - Enter custom values\r\n2 - Back to start page\r\n3 - Exit program\r\nWhat you want? Enter integer values.");
            switch (input.InputInt(1, 4))
            {
                case 1:
                    CustomCalculations();
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

        private void CalculateDefaultValues()
        {
            Console.Clear();
            var input = new InputValues();
            var task = new CalculateTasks(2.0, 3.0, 0.11, 0.36, 0.05).Display;
            Console.WriteLine($"Calculated with default values:\r\n{task}");
        }

        private void CalculateCustomValues()
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
            var task = new CalculateTasks(a, b, start, end, delta).Display;
            Console.WriteLine($"Calculated with custom values:\r\n{task}");
            IsCalculated = true;
        }

        private void CustomCalculations()
        {
            var input = new InputValues();
            Console.Clear();
            CalculateCustomValues();
            Console.WriteLine("Available actions:\r\n1 - Calculate with another custom values\r\n2 - Back to previous page\r\n3 - Exit program\r\nWhat you want? Enter integer values.");
            switch (input.InputInt(1, 2))
            {
                case 1:
                    CalculateCustomValues();
                    break;

                case 2:
                    CustomPage();
                    break;

                case 3:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}