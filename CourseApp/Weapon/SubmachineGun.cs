namespace CourseApp.Weapon
{
    public class SubmachineGun : RifleWeapon
    {
        public SubmachineGun(string variety, string name, double calibre, int rateoffire)
        {
            this.Variety = variety;
            this.Name = name;
            if (this.Calibre > 0)
            {
                this.Calibre = calibre;
            }

            if (this.RateOfFire > 600 && this.RateOfFire < 900)
            {
                this.RateOfFire = rateoffire;
            }
        }
    }
}
