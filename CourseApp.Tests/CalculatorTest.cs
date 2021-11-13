namespace CourseApp.Tests
{
    using Xunit;

    public class CalculatorTest
    {
        [Theory]
        [InlineData(10, 0, 10)]
        [InlineData(0.0f, 32.812398f, -32.812398f)]
        [InlineData(67.123, 3.002, 64.121)]
        public void SomethingSub(double val1, double val2, double exp)
        {
            var calc = new Calculator();

            var res = calc.Sub(val1, val2);

            Assert.Equal(exp, res, 3);
        }

        [Theory]
        [InlineData(2.5231, 34.42342, -31.90032)]
        public void SomethingSubDec(decimal val1, decimal val2, decimal exp)
        {
            var calc = new Calculator();

            var res = calc.Sub(val1, val2);

            Assert.Equal(exp, res, 3);
        }

        [Theory]
        [InlineData(10, 3, 13)]
        [InlineData(43.123675f, 32.812398f, 75.936073f)]
        [InlineData(67.123, 3.002, 70.125)]
        public void SomethingSum(double val1, double val2, double exp)
        {
            var calc = new Calculator();

            var res = calc.Sum(val1, val2);

            Assert.Equal(exp, res, 3);
        }

        [Theory]
        [InlineData(2.5231, 34.42342, 36.94652)]
        public void SomethingSumDec(decimal val1, decimal val2, decimal exp)
        {
            var calc = new Calculator();

            var res = calc.Sum(val1, val2);

            Assert.Equal(exp, res, 3);
        }
    }
}
