namespace CourseApp.Tests
{
    using Xunit;

    public class TasksTest
    {
        [Theory]
        [InlineData(6, 0.11, 0.36, 0.05)]
        [InlineData(4, 0.11, 0.26, 0.05)]
        [InlineData(1, 10, 10, 1)]
        [InlineData(1, 0, 0, 1)]
        [InlineData(0, 0, 0, 0)]
        public void TaskA(int exp, double xn, double xk, double dx)
        {
            // arrange
            var equation = new Tasks();

            // act
            double[] res = equation.TaskA(xn, xk, dx);

            // assert
            Assert.Equal(res.Length, exp);
        }

        [Theory]
        [InlineData(5, new[] { 0.2, 0.3, 0.38, 0.43, 0.57 })]
        [InlineData(4, new[] { 0.2, 0.3, 0.38, -0.11 })]
        [InlineData(0, new double[] { })]
        public void TaskB(int exp, double[] x)
        {
            // arrange
            var equation = new Tasks();

            // act
            double[] res = equation.TaskB(x);

            // assert
            Assert.Equal(res.Length, exp);
            Assert.Equal(res.Length, x.Length);
        }

        [Theory]
        [InlineData(-0.11, double.NaN)]
        [InlineData(0, double.NegativeInfinity)]
        [InlineData(0.11, -2.17041)]
        public void Equation(double a, double exp)
        {
            // arrange
            var equation = new Tasks();

            // act
            var res = equation.Function(a);

            // assert
            Assert.Equal(exp, res, 5);
        }
    }
}
