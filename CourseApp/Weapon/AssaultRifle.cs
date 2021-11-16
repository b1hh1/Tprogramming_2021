namespace CourseApp.Weapon
{
    public class AssaultRifle : RifleWeapon
    {
        public AssaultRifle(string variety, string name, double calibre, string typeofshooting)
        {
            this.Variety = variety;
            this.Name = name;
            if (this.Calibre > 0)
            {
                this.Calibre = calibre;
            }

            this.TypeOfShooting = typeofshooting;
        }
    }
}
