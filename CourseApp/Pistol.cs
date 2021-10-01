namespace CourseApp
{
    public class Pistol : Weapon
    {
        public Pistol(string model, int year, string owner)
            : this(model, 0, year, owner)
        {
        }

        public Pistol(string model, float caliber, int year, string owner)
        {
            this.Model = model;
            this.Owner = owner;
            this.Caliber = caliber;
            this.Year = year;
        }
    }
}
