namespace CourseApp
{
    public class AssaultRifle : Weapon
    {
        private ushort shoot = 0;

        public AssaultRifle(string model, ushort year, string owner)
            : this(model, 0, year, owner, false)
        {
        }

        public AssaultRifle(string model, ushort year, string owner, bool automaticShooting)
            : this(model, 0, year, owner, automaticShooting)
        {
        }

        public AssaultRifle(string model, float caliber, ushort year, string owner, bool automaticShooting)
        {
            this.Model = model;
            this.Owner = owner;
            this.Caliber = caliber;
            this.Year = year;
            this.AutomaticShooting = automaticShooting;
        }

        public bool AutomaticShooting { get; set; }

        public new void Shoot()
        {
            if (AutomaticShooting)
            {
                shoot = (ushort)(shoot + 3);
            }
            else
            {
                shoot++;
            }
        }
    }
}
