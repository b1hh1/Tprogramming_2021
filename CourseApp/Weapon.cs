namespace CourseApp
{
    public abstract class Weapon : IWeapon
    {
        private ushort shoot = 0;
        private float caliber;
        private int year;

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

        public string Model { get; set; }

        public string Owner { get; set; }

        public string Shoot()
        {
            shoot++;
            return $"Shoots: {shoot}";
        }
    }
}
