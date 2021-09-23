namespace CourseApp.Tests
{
    using Xunit;

    public class PistolTest
    {
        [Fact]
        public void GetModel()
        {
            // arrange
            Pistol glock = new Pistol("Glock", 1945, "Nikita");
            var exp = "Glock";

            // act
            var res = glock.Model;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void SetModel()
        {
            // arrange
            Pistol colt = new Pistol("Glock", 1760, "Max");
            colt.Model = "Colt";
            var exp = "Colt";

            // act
            var res = colt.Model;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void GetYear()
        {
            // arrange
            Pistol glock = new Pistol("Glock", 1945, "Nikita");
            var exp = 1945;

            // act
            var res = glock.Year;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void SetYearWithoutErr()
        {
            // arrange
            Pistol colt = new Pistol("Glock", 1760, "Max");
            colt.Year = 1869;
            var exp = 1869;

            // act
            var res = colt.Year;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void SetYearWithErr()
        {
            // arrange
            Pistol colt = new Pistol("Glock", 1760, "Max");
            colt.Year = -145;
            var exp = 1760;

            // act
            var res = colt.Year;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void GetOwner()
        {
            // arrange
            Pistol glock = new Pistol("Glock", 1945, "Nikita");
            var exp = "Nikita";

            // act
            var res = glock.Owner;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void SetOwner()
        {
            // arrange
            Pistol colt = new Pistol("Glock", 1760, "Max");
            colt.Owner = "Mike";
            var exp = "Mike";

            // act
            var res = colt.Owner;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void GetCaliber()
        {
            // arrange
            Pistol glock = new Pistol("Glock", 1945, "Nikita");
            var exp = 0;

            // act
            var res = glock.Caliber;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void SetCaliberWithoutErr()
        {
            // arrange
            Pistol colt = new Pistol("Glock", 1760, "Max");
            colt.Caliber = 14.5F;
            var exp = 14.5F;

            // act
            var res = colt.Caliber;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void SetCaliberWithErrLowBorder()
        {
            // arrange
            Pistol colt = new Pistol("Glock", 6.9F, 1760, "Max");
            colt.Caliber = -14.5F;
            var exp = 6.9F;

            // act
            var res = colt.Caliber;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void SetCaliberWithErrHighBorder()
        {
            // arrange
            Pistol colt = new Pistol("Glock", 6.9F, 1760, "Max");
            colt.Caliber = 54.5F;
            var exp = 6.9F;

            // act
            var res = colt.Caliber;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void FullConstructor()
        {
            // arrange
            Pistol colt = new Pistol("Glock", 5.2F, 1760, "Max");
            colt.Caliber = 5.2F;
            var exp = 5.2F;

            // act
            var res = colt.Caliber;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Shoots()
        {
            // arrange
            Pistol colt = new Pistol("Glock", 5.2F, 1760, "Max");
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
