namespace CourseApp.Tests
{
    using Xunit;

    public class AssaultRifleTest
    {
        [Fact]
        public void GetYearAssaultRifle()
        {
            // arrange
            var aK47 = new AssaultRifle("AK47", 1945, "Nikita");
            var exp = 1945;

            // act
            var res = aK47.Year;

            // assert
            Assert.Equal(exp, res);
        }

        [Theory]
        [InlineData(1869, 1869)]
        [InlineData(1760, 1500)]
        public void SetYearAssaultRifle(ushort exp, ushort year)
        {
            // arrange
            var aK47 = new AssaultRifle("AK47", 1760, "Max");
            aK47.Year = year;

            // act
            var res = aK47.Year;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void GetCaliberAssaultRifle()
        {
            // arrange
            var aK47 = new AssaultRifle("AK47", 1945, "Nikita");
            var exp = 0;

            // act
            var res = aK47.Caliber;

            // assert
            Assert.Equal(exp, res);
        }

        [Theory]
        [InlineData(14.5, 14.5)]
        [InlineData(6.9, -14.5)]
        [InlineData(6.9, 54.5)]
        public void SetCaliberAssaultRifle(float exp, float caliber)
        {
            // arrange
            var aK47 = new AssaultRifle("AK47", 6.9F, 1760, "Max", true);
            aK47.Caliber = caliber;

            // act
            var res = aK47.Caliber;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void FullConstructorAssaultRifle()
        {
            // arrange
            var aK47 = new AssaultRifle("AK47", -2, 1760, "Max", true);
            var exp = 0;

            // act
            var res = aK47.Caliber;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void AutomaticShootingAssaultRifle()
        {
            // arrange
            var aK47 = new AssaultRifle("AK47", 5.2F, 1760, "Max", true);
            var exp = true;

            // act
            var res = aK47.AutomaticShooting;

            // assert
            Assert.Equal(exp, res);
        }

        [Theory]
        [InlineData(3, false)]
        [InlineData(9, true)]
        public void ShootsAssaultRifle(ushort shoot, bool flag)
        {
            // arrange
            var aK47 = new AssaultRifle("AK47", 1760, "Max");
            aK47.AutomaticShooting = flag;
            aK47.Shoot();
            aK47.Shoot();
            aK47.Shoot();
            var exp = $"Shoots: {shoot}";

            // act
            var res = aK47.ToString();

            // assert
            Assert.Equal(exp, res);
        }
    }
}
