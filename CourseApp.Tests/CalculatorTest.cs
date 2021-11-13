namespace CourseApp.Tests
{
    using Xunit;

    public class CalculatorTest
    {
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(5, 10, 50)]
        [InlineData(4, 5, 20)]
        [InlineData(3, 5, 15)]
        [InlineData(0, 2, 0)]
        [InlineData(-2, 2, -4)]
        public void Multiply(int a, int b, int exp)
        {
            // arrange
            var calc = new Calculator();

            // act
            var res = calc.Multi(a, b);

            // assert
            Assert.Equal(exp, res);
        }
    }
}
