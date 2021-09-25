namespace CourseApp
{
    using System;
    using static System.Math;

    public class RandomValueGenerator
    {
        public string RandomName()
        {
            string[] name = { "isuct", "Funny", "Test", "Car", "Page", "IDE", "Game", "Video", "Music", "Work" };
            var rnd = new Random();
            return name[rnd.Next(0, name.Length - 1)];
        }

        public string RandomExtension()
        {
            string[] extension = { ".txt", ".pdf", ".jpg", ".cs", ".html", ".png", ".abb", ".mp3", ".mp4" };
            var rnd = new Random();
            return extension[rnd.Next(0, extension.Length - 1)];
        }

        public double RandomWeight()
        {
            var rnd = new Random();
            var value = (rnd.NextDouble() + rnd.NextDouble()) / rnd.NextDouble();
            if (value == 0)
            {
                RandomWeight();
            }

            return Round(value, 2);
        }

        public string RandomWeightModificator()
        {
            string[] weightModificator = { "B", "KB", "MB", "GB", "TB", "PB" };
            var rnd = new Random();
            return weightModificator[rnd.Next(0, weightModificator.Length - 1)];
        }
    }
}