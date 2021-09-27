namespace CourseApp.Class
{
    using System;

    public abstract class Document
    {
        private string _name;

        public Document(string name)
        {
            Name = name;
        }

        public Document()
        {
            InitName();
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid name. Name can not be null or empty.");
                }

                _name = value;
            }
        }

        public abstract string Display();

        private void InitName()
        {
            Console.Clear();
            Console.WriteLine("Generate name? (1 - yes / 2 - no)");
            switch (Console.ReadLine())
            {
                case "1":
                {
                    var generator = new RandomValueGenerator();
                    Name = generator.RandomName();
                    break;
                }

                case "2":
                {
                    Console.Clear();
                    Console.Write("Enter name: ");
                    Name = Console.ReadLine();
                    break;
                }

                default:
                {
                    InitName();
                    break;
                }
            }
        }
    }
}