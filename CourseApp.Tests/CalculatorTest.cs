namespace CourseApp.Tests
{
    using Xunit;

    public class CalculatorTest
    {
        [Fact]
        public void Calcul()
        {
            // arrange
            var calc = new Calculator();
            var a = 5;
            var b = 10;
            var exp = 50;

            // act
            var res = calc.Multi(a, b);

            // assert
            Assert.Equal(exp, res);
        }
    }
}
