namespace CourseApp
{
    public class AssaultRifle : Weapon
    {
        private ushort shoot = 0;

        public AssaultRifle(string model, int year, string owner)
            : this(model, 0, year, owner, false)
        {
        }

        public AssaultRifle(string model, int year, string owner, bool automaticShooting)
            : this(model, 0, year, owner, automaticShooting)
        {
        }

        public AssaultRifle(string model, float caliber, int year, string owner, bool automaticShooting)
        {
            this.Model = model;
            this.Owner = owner;
            this.Caliber = caliber;
            this.Year = year;
            this.AutomaticShooting = automaticShooting;
        }

        public bool AutomaticShooting { get; set; }

        public new string Shoot()
        {
            if (AutomaticShooting)
            {
                shoot = (ushort)(shoot + 3);
            }
            else
            {
                shoot++;
            }

            return $"Shoots: {shoot}";
        }
    }
}
