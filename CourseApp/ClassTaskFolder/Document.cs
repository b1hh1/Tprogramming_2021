namespace CourseApp
{
    using System;

    public abstract class Document
    {
        public Document(string name)
        {
            Name = name;
            CheckName();
        }

        public Document()
        {
            RandomName();
        }

        public string Name { get; set; }

        public void RandomName()
        {
            var rnd = new Random();
            switch (rnd.Next(0, 5))
            {
                case 0:
                    Name = "isuct";
                    break;
                case 1:
                    Name = "Funny";
                    break;
                case 2:
                    Name = "Game";
                    break;
                case 3:
                    Name = "IDE";
                    break;
                case 4:
                    Name = "Test";
                    break;
                case 5:
                    Name = "Page";
                    break;
            }
        }

        public void CheckName()
        {
            if (Name == " " || Name == null)
            {
                Console.WriteLine("Invalid name. Name can not be null.");
                Environment.Exit(1);
            }
        }

        public abstract string Display();
    }
}