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
            RandomName();
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
                    throw new Exception("Invalid name. Name can not be null.");
                }

                _name = value;
            }
        }

        public void RandomName()
        {
            var rnd = new Random();
            switch (rnd.Next(0, 14))
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
                case 6:
                    Name = "Document";
                    break;
                case 7:
                    Name = "Cat";
                    break;
                case 8:
                    Name = "Car";
                    break;
                case 9:
                    Name = "University";
                    break;
                case 10:
                    Name = "Video";
                    break;
                case 11:
                    Name = "Lesson";
                    break;
                case 12:
                    Name = "Work";
                    break;
                case 13:
                    Name = "Weather";
                    break;
                case 14:
                    Name = "Music";
                    break;
            }
        }

        public abstract string Display();
    }
}