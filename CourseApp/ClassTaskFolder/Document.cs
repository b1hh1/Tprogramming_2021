namespace CourseApp
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
            var generator = new RandomValueGenerator();
            Name = generator.RandomName();
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
    }
}