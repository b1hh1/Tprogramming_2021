namespace CourseApp.Tests
{
    using CourseApp.Weapon;
    using Xunit;

    public class WeaponsTest
    {
        [Fact]
        public void GetModelPistol()
        {
            var glock = new Pistol("Pisrol", "Glock18", 9.0);
            var exp = "Glock18";

            Assert.Equal(exp, glock.Name);
        }

        [Fact]
        public void GetModelSubmachineGun()
        {
            var glock = new SubmachineGun("Submachine Gun", "Mac10", 9.0, 901);
            var exp = 0;

            Assert.Equal(exp, glock.RateOfFire);
        }

        [Fact]
        public void GetModelAssaultRifle()
        {
            var glock = new AssaultRifle("AssaultRifle", "АВС36", 7.62, "Single shots");
            var exp = "Single shots";

            Assert.Equal(exp, glock.TypeOfShooting);
        }
    }
}
