namespace CourseApp.Tests
{
    using Xunit;

    public class PistolTest
    {
        [Fact]
        public void GetYearPistol()
        {
            // arrange
            var glock = new Pistol("Glock", 1945, "Nikita");
            var exp = 1945;

            // act
            var res = glock.Year;

            // assert
            Assert.Equal(exp, res);
        }

        [Theory]
        [InlineData(1869, 1869)]
        [InlineData(1760, 1500)]
        public void SetYearPistol(ushort exp, ushort year)
        {
            // arrange
            var colt = new Pistol("Glock", 1760, "Max");
            colt.Year = year;

            // act
            var res = colt.Year;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void GetCaliberPistol()
        {
            // arrange
            var glock = new Pistol("Glock", 1945, "Nikita");
            var exp = 0;

            // act
            var res = glock.Caliber;

            // assert
            Assert.Equal(exp, res);
        }

        [Theory]
        [InlineData(14.5, 14.5)]
        [InlineData(6.9, -14.5)]
        [InlineData(6.9, 54.5)]
        public void SetCaliberPistol(float exp, float caliber)
        {
            // arrange
            var colt = new Pistol("Glock", 6.9F, 1760, "Max");
            colt.Caliber = caliber;

            // act
            var res = colt.Caliber;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void FullConstructorPistol()
        {
            // arrange
            var colt = new Pistol("Glock", 5.2F, 1760, "Max");
            var exp = 5.2F;

            // act
            var res = colt.Caliber;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void ShootsPistol()
        {
            // arrange
            var colt = new Pistol("Glock", 5.2F, 1760, "Max");
            colt.Shoot();
            colt.Shoot();
            colt.Shoot();
            var exp = "Shoots: 4";

            // act
            var res = colt.Shoot();

            // assert
            Assert.Equal(exp, res);
        }
    }
}
