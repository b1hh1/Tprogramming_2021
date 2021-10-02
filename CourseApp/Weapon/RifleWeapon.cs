namespace CourseApp.Weapon
{
    public abstract class RifleWeapon : IRifleWeapon
    {
        private string variety;
        private string name;
        private double calibre;
        private int rateoffire;
        private string typeofshooting;

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

        public string Name1 { get => name; set => name = value; }

        public string Variety1 { get => variety; set => variety = value; }

        public int Rateoffire { get => rateoffire; set => rateoffire = value; }

        public string Typeofshooting { get => typeofshooting; set => typeofshooting = value; }
    }
}
