namespace CourseApp
{
    using System;
    using static System.Math;

    public class FileCreator : Document
    {
        public FileCreator(string name, string extension, double weight, string weightModificator)
        : base(name)
        {
            Extension = extension;
            Weight = weight;
            WeightModificator = weightModificator;
            CheckException();
        }

        public FileCreator()
        : base()
        {
            RandomExtension();
            RandomWeight();
            RandomWeightModificator();
        }

        public string Extension { get; set; }

        public double Weight { get; set; }

        public string WeightModificator { get; set; }

        public void RandomExtension()
        {
            var rnd = new Random();
            switch (rnd.Next(0, 5))
            {
                case 0:
                    Extension = ".txt";
                    break;
                case 1:
                    Extension = ".pdf";
                    break;
                case 2:
                    Extension = ".jpg";
                    break;
                case 3:
                    Extension = ".exe";
                    break;
                case 4:
                    Extension = ".html";
                    break;
                case 5:
                    Extension = ".HEIC";
                    break;
            }
        }

        public void RandomWeightModificator()
        {
            var rnd = new Random();
            switch (rnd.Next(0, 5))
            {
                case 0:
                    WeightModificator = "B";
                    break;
                case 1:
                    WeightModificator = "KB";
                    break;
                case 2:
                    WeightModificator = "MB";
                    break;
                case 3:
                    WeightModificator = "GB";
                    break;
                case 4:
                    WeightModificator = "TB";
                    break;
                case 5:
                    WeightModificator = "PB";
                    break;
            }
        }

        public void RandomWeight()
        {
            var rndValue = new Random();
            Weight = Round(rndValue.NextDouble(), 1);
        }

        public void CheckExtension()
        {
            if (Extension == " " || Extension == null)
            {
                Console.WriteLine("Invalid extension. Extension can not be null.");
                Environment.Exit(2);
            }
        }

        public void CheckWeight()
        {
            if (Weight <= 0)
            {
                Console.WriteLine("Invalid weight. Weight can not be below zero.");
                Environment.Exit(3);
            }
        }

        public void CheckWeightModificator()
        {
            if (WeightModificator == " " || WeightModificator == null)
            {
                Console.WriteLine("Invalid weightModificator. WeightModificator can not be null.");
                Environment.Exit(4);
            }
        }

        public void CheckException()
        {
            CheckExtension();
            CheckWeight();
            CheckWeightModificator();
        }

        public override string Display()
        {
            var message = $"{Name}{Extension} {Weight}{WeightModificator}";
            return message;
        }
    }
}