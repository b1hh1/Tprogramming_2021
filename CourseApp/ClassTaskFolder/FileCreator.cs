namespace CourseApp
{
    using System;
    using static System.Math;

    public class FileCreator : Document
    {
        private string _extension;
        private double _weight;
        private string _weightModificator;

        public FileCreator(string name, string extension, double weight, string weightModificator)
        : base(name)
        {
            Extension = extension;
            Weight = weight;
            WeightModificator = weightModificator;
        }

        public FileCreator()
        : base()
        {
            RandomExtension();
            RandomWeight();
            RandomWeightModificator();
        }

        public string Extension
        {
            get
            {
                return _extension;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Invalid extension. Extension can not be null.");
                }

                _extension = value;
            }
        }

        public double Weight
        {
            get
            {
                return _weight;
            }

            set
            {
                if (value <= 0)
                {
                    throw new Exception("Invalid weight. Weight can not be below zero.");
                }

                _weight = value;
            }
        }

        public string WeightModificator
        {
            get
            {
                return _weightModificator;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid weightModificator. WeightModificator can not be null.");
                }

                _weightModificator = value;
            }
        }

        public void RandomExtension()
        {
            var rnd = new Random();
            switch (rnd.Next(0, 14))
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
                case 6:
                    Extension = ".png";
                    break;
                case 7:
                    Extension = ".cs";
                    break;
                case 8:
                    Extension = ".py";
                    break;
                case 9:
                    Extension = ".pages";
                    break;
                case 10:
                    Extension = ".abb";
                    break;
                case 11:
                    Extension = ".apk";
                    break;
                case 12:
                    Extension = ".moc";
                    break;
                case 13:
                    Extension = ".mp4";
                    break;
                case 14:
                    Extension = ".mp3";
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
            var value = (rndValue.NextDouble() + rndValue.NextDouble()) / rndValue.NextDouble();
            if (value == 0)
            {
                RandomWeight();
            }
            else
            {
                Weight = Round(value, 2);
            }
        }

        public override string Display()
        {
            return $"{Name}{Extension} {Weight}{WeightModificator}";
        }
    }
}