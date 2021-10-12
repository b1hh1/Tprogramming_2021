namespace CourseApp.Weapon
{
    public abstract class RifleWeapon : IRifleWeapon
    {
        private double calibre;

        public string Variety { get; set; }

        public string Name { get; set; }

        public int RateOfFire { get; set; }

        public string TypeOfShooting { get; set; }

        public double Calibre
        {
            get
            {
                return calibre;
            }

            set
            {
                if (value > 0 && value < 23)
                {
                    calibre = value;
                }
            }
        }
    }
}
