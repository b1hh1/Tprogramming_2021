namespace CourseApp
{
    using System;
    using static System.Math;

    public class RandomValueGenerator
    {
        public string RandomName()
        {
            var value = string.Empty;
            var rnd = new Random();
            switch (rnd.Next(0, 14))
            {
                case 0:
                    value = "isuct";
                    break;
                case 1:
                    value = "Funny";
                    break;
                case 2:
                    value = "Game";
                    break;
                case 3:
                    value = "IDE";
                    break;
                case 4:
                    value = "Test";
                    break;
                case 5:
                    value = "Page";
                    break;
                case 6:
                    value = "Document";
                    break;
                case 7:
                    value = "Cat";
                    break;
                case 8:
                    value = "Car";
                    break;
                case 9:
                    value = "University";
                    break;
                case 10:
                    value = "Video";
                    break;
                case 11:
                    value = "Lesson";
                    break;
                case 12:
                    value = "Work";
                    break;
                case 13:
                    value = "Weather";
                    break;
                case 14:
                    value = "Music";
                    break;
            }

            return value;
        }

        public string RandomExtension()
        {
            var value = string.Empty;
            var rnd = new Random();
            switch (rnd.Next(0, 14))
            {
                case 0:
                    value = ".txt";
                    break;
                case 1:
                    value = ".pdf";
                    break;
                case 2:
                    value = ".jpg";
                    break;
                case 3:
                    value = ".exe";
                    break;
                case 4:
                    value = ".html";
                    break;
                case 5:
                    value = ".HEIC";
                    break;
                case 6:
                    value = ".png";
                    break;
                case 7:
                    value = ".cs";
                    break;
                case 8:
                    value = ".py";
                    break;
                case 9:
                    value = ".pages";
                    break;
                case 10:
                    value = ".abb";
                    break;
                case 11:
                    value = ".apk";
                    break;
                case 12:
                    value = ".moc";
                    break;
                case 13:
                    value = ".mp4";
                    break;
                case 14:
                    value = ".mp3";
                    break;
            }

            return value;
        }

        public double RandomWeight()
        {
            var rndValue = new Random();
            var value = (rndValue.NextDouble() + rndValue.NextDouble()) / rndValue.NextDouble();
            if (value == 0)
            {
                RandomWeight();
            }

            return Round(value, 2);
        }

        public string RandomWeightModificator()
        {
            var value = string.Empty;
            var rnd = new Random();
            switch (rnd.Next(0, 5))
            {
                case 0:
                    value = "B";
                    break;
                case 1:
                    value = "KB";
                    break;
                case 2:
                    value = "MB";
                    break;
                case 3:
                    value = "GB";
                    break;
                case 4:
                    value = "TB";
                    break;
                case 5:
                    value = "PB";
                    break;
            }

            return value;
        }
    }
}