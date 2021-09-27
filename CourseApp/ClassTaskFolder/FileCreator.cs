namespace CourseApp.Class
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
            InitExtension(generator);
            InitWeight(generator);
            InitWeightModificator(generator);
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
                    throw new Exception("Invalid extension. Extension can not be null or empty.");
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
                    throw new Exception("Invalid weightModificator. WeightModificator can not be null or empty.");
                }

                _weightModificator = value;
            }
        }

        public override string Display()
        {
            return $"{Name}{Extension} {Weight}{WeightModificator}";
        }

        private void InitExtension(RandomValueGenerator generator)
        {
            Console.Clear();
            Console.WriteLine("Generate extension? (1 - yes / 2 - no)");
            switch (Console.ReadLine())
            {
                case "1":
                {
                    Extension = generator.RandomExtension();
                    break;
                }

                case "2":
                {
                    Console.Clear();
                    Console.Write("Enter extension: ");
                    Extension = Console.ReadLine();
                    break;
                }

                default:
                {
                    InitExtension(generator);
                    break;
                }
            }
        }

        private void InitWeight(RandomValueGenerator generator)
        {
            Console.Clear();
            Console.WriteLine("Generate weight? (1 - yes / 2 - no)");
            switch (Console.ReadLine())
            {
                case "1":
                {
                    Weight = generator.RandomWeight();
                    break;
                }

                case "2":
                {
                    Console.Clear();
                    Console.Write("Enter weight: ");
                    Weight = Convert.ToDouble(Console.ReadLine());
                    break;
                }

                default:
                {
                    InitWeight(generator);
                    break;
                }
            }
        }

        private void InitWeightModificator(RandomValueGenerator generator)
        {
            Console.Clear();
            Console.WriteLine("Generate weightModificator? (1 - yes / 2 - no)");
            switch (Console.ReadLine())
            {
                case "1":
                {
                    WeightModificator = generator.RandomWeightModificator();
                    break;
                }

                case "2":
                {
                    Console.Clear();
                    Console.Write("Enter weightModificator: ");
                    WeightModificator = Console.ReadLine();
                    break;
                }

                default:
                {
                    InitWeightModificator(generator);
                    break;
                }
            }
        }
    }
}