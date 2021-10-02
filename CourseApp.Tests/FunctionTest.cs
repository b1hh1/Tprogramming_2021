namespace CourseApp.Tests
{
    using Xunit;

    public class FunctionTest
    {
        [Fact]
        public void FirstTest()
        {
            var calc = new FunctionCalculator();
            double a = 4.1;
            double b = 2.7;
            double x = 2.34;
            var exp = 1956.21338;

            var res = calc.Function(a, b, x);

            Assert.Equal(exp, res, 5);
        }

        [Fact]
        public void XEqualOneTest()
        {
            var calc = new FunctionCalculator();
            double a = 4.1;
            double b = 2.7;
            double x = 1;
            var exp = 0;

            var res = calc.Function(a, b, x);

            Assert.Equal(exp, res);
        }

        [Fact]
        public void AEqual0Test()
        {
            var calc = new FunctionCalculator();
            double a = 0;
            double b = 2.7;
            double x = 1.9;
            var exp = 11239.29616;

            var res = calc.Function(a, b, x);

            Assert.Equal(exp, res, 5);
        }

        [Fact]
        public void BEqual0Test()
        {
            var calc = new FunctionCalculator();
            double a = 4.1;
            double b = 0;
            double x = 1.9;
            var exp = -53004.79111;

            var res = calc.Function(a, b, x);

            Assert.Equal(exp, res, 4);
        }
    }
}
