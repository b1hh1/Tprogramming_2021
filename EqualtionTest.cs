namespace CourseApp.Tests
{
    using Xunit;

    public class EqualtionTest
    {
        [Fact]
        public void Calcul()
        {
            // arrange
            var equation = new Equation();
            var a = 0.11;
            var exp = -2.170;

            // act
            var res = equation.Function(a);

            // assert
            Assert.Equal(exp, res, 3);
        }

        [Fact]
        public void Calc()
        {
            // arrange
            var equation = new Equation();
            var a = -0.11;
            var exp = double.NaN;

            // act
            var res = equation.Function(a);

            // assert
            Assert.Equal(exp, res);
        }
    }
}
