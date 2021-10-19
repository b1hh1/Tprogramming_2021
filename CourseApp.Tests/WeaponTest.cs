namespace CourseApp.Tests
{
    using Xunit;

    public class WeaponTest
    {
        [Fact]
        public void GetModelPistol()
        {
            // arrange
            var glock = new Pistol("Glock", 1945, "Nikita");
            var exp = "Glock";

            // act
            var res = glock.Model;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void SetModelPistol()
        {
            // arrange
            var colt = new Pistol("Glock", 1760, "Max");
            colt.Model = "Colt";
            var exp = "Colt";

            // act
            var res = colt.Model;

            // assert
            Assert.Equal(exp, res);
        }

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
        [InlineData(1760, -145)]
        public void SetYearPistol(short exp, short year)
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
        public void GetOwnerPistol()
        {
            // arrange
            var glock = new Pistol("Glock", 1945, "Nikita");
            var exp = "Nikita";

            // act
            var res = glock.Owner;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void SetOwnerPistol()
        {
            // arrange
            var colt = new Pistol("Glock", 1760, "Max");
            colt.Owner = "Mike";
            var exp = "Mike";

            // act
            var res = colt.Owner;

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

        [Fact]
        public void GetModelAssaultRifle()
        {
            // arrange
            var aK47 = new AssaultRifle("AK47", 1945, "Nikita");
            var exp = "AK47";

            // act
            var res = aK47.Model;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void SetModelAssaultRifle()
        {
            // arrange
            var aK47 = new AssaultRifle("AK47", 1760, "Max");
            aK47.Model = "Colt";
            var exp = "Colt";

            // act
            var res = aK47.Model;

            // assert
            Assert.Equal(exp, res);
        }

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
        [InlineData(1760, -145)]
        public void SetYearAssaultRifle(short exp, short year)
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
        public void GetOwnerAssaultRifle()
        {
            // arrange
            var aK47 = new AssaultRifle("AK47", 1945, "Nikita");
            var exp = "Nikita";

            // act
            var res = aK47.Owner;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void SetOwnerAssaultRifle()
        {
            // arrange
            var aK47 = new AssaultRifle("AK47", 1760, "Max");
            aK47.Owner = "Mike";
            var exp = "Mike";

            // act
            var res = aK47.Owner;

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

        [Theory]
        [InlineData(4, false)]
        [InlineData(12, true)]
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
            var res = aK47.Shoot();

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
    }
}
