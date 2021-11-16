namespace CourseApp.Tests
{
    using System.Collections.Generic;
    using Xunit;

    public class FunctionTest
    {
        [Theory]
        [InlineData(4.1, 2.7, 2.34, 1956.21338)]
        [InlineData(4.1, 2.7, 1, 0)]
        [InlineData(0, 2.7, 1.9, 11239.29616)]
        [InlineData(4.1, 0, 1.9, -53004.79111)]

        public void Test(double a, double b, double x, double exp)
        {
            var calc = new FunctionCalculator();

            var res = calc.Function(a, b, x);

            Assert.Equal(exp, res, 5);
        }

        [Theory]
        [InlineData(1.5, 1.5, 0.4, 4.1, 2.7)]
        public void TestA(double xStart, double xEnd, double dX, double a, double b)
        {
            var calc = new FunctionCalculator();

            var res = calc.TaskA(xStart, xEnd, dX, a, b);

            List<double> exp = new List<double>();

            Assert.Equal(res, exp);
        }

        [Fact]
        public void TestB()
        {
            double[] nums = new double[] { };
            double a = 4.1;
            double b = 2.7;

            var calc = new FunctionCalculator();

            var res = calc.TaskB(nums, a, b);

            List<double> exp = new List<double>();

            Assert.Equal(res, exp);
        }
    }
}
