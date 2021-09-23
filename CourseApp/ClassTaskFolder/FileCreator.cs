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
            var generator = new RandomValueGenerator();
            Extension = generator.RandomExtension();
            Weight = generator.RandomWeight();
            WeightModificator = generator.RandomWeightModificator();
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

        public override string Display()
        {
            return $"{Name}{Extension} {Weight}{WeightModificator}";
        }
    }
}