namespace CourseApp.Weapon
{
    using System;

    public class Pistol : RifleWeapon
    {
        public Pistol(string variety, string name, double calibre)
        {
            this.Variety = variety;
            this.Name = name;
            if (this.Calibre > 0)
            {
                this.Calibre = calibre;
            }
        }

        public void Pew()
        {
            if (Variety == "Pistol" || Variety == "pistol")
            {
                Console.WriteLine("Pew, pew, pew");
            }
            else
            {
                Console.WriteLine("Only pistols can be fired here!!!");
            }
        }
    }
}
