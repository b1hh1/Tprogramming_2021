namespace CourseApp.Class
{
    using System;
    using static System.Math;

    public class DocumentValue
    {
        public static int InputIntValue()
        {
            var isNumber = false;
            var input = string.Empty;
            int inputValue = 0;
            while (!isNumber)
            {
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out inputValue);
                if (!isNumber)
                {
                    Console.WriteLine($"Value is incorrect. Please enter correct value!");
                }
            }

            return inputValue;
        }

        public static double InputDoubleValue()
        {
            var isNumber = false;
            var input = string.Empty;
            double inputValue = 0;
            while (!isNumber)
            {
                input = Console.ReadLine();
                isNumber = double.TryParse(input, out inputValue);
                if (!isNumber)
                {
                    Console.WriteLine($"Value is incorrect. Please enter correct value!");
                }
            }

            return inputValue;
        }

        public string Name()
        {
            string[] name = { "isuct", "Funny", "Test", "Car", "Page", "IDE", "Game", "Video", "Music", "Work" };
            Console.WriteLine("Chose name:");
            ConsoleOutput(name);
            return name[CheckIntInput(name)];
        }

        public string Extension()
        {
            string[] extension = { ".txt", ".pdf", ".jpg", ".cs", ".html", ".png", ".abb", ".mp3", ".mp4" };
            Console.WriteLine(" ");
            Console.WriteLine("Chose extension:");
            ConsoleOutput(extension);
            return extension[CheckIntInput(extension)];
        }

        public double Weight()
        {
            Console.WriteLine(" ");
            Console.Write("Enter weight ( weight > 0 ): ");
            return InputDoubleValue();
        }

        public string WeightModificator()
        {
            string[] weightModificator = { "B", "KB", "MB", "GB", "TB", "PB" };
            Console.WriteLine(" ");
            Console.WriteLine("Chose weightModificator:");
            ConsoleOutput(weightModificator);
            return weightModificator[CheckIntInput(weightModificator)];
        }

        private void ConsoleOutput(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine($"{str[i]} - {i + 1}");
            }
        }

        private int CheckIntInput(string[] str)
        {
            var input = 0;
            var isCorrectNumber = false;
            while (!isCorrectNumber)
            {
                input = InputIntValue();
                if (input > str.Length || input <= 0)
                {
                    Console.WriteLine("Value is out of range");
                }
                else
                {
                    isCorrectNumber = true;
                }
            }

            return input;
        }
    }
}