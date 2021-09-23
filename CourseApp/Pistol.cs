namespace CourseApp
{
    public class Pistol
    {
        private float caliber;
        private int year;
        private string model;
        private string owner;
        private ushort shoot = 0;

        public Pistol(string model, float caliber, int year, string owner)
        {
            Model = model;
            Owner = owner;
            Caliber = caliber;
            Year = year;
        }

        public Pistol(string model, int year, string owner)
        {
            Model = model;
            Owner = owner;
            Caliber = 0;
            Year = year;
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public float Caliber
        {
            get
            {
                return caliber;
            }

            set
            {
                if (value > 0 && value < 20)
                {
                    caliber = value;
                }
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                if (value > 1600)
                {
                    year = value;
                }
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }

            set
            {
                owner = value;
            }
        }

        public string Shoot()
        {
            shoot++;
            return $"Shoots: {shoot}";
        }
    }
}
