namespace CourseApp
{
    public interface IWeapon
    {
        string Model { get; set; }

        string Owner { get; set; }

        float Caliber { get; set; }

        ushort Year { get; set; }

        string Shoot();
    }
}
