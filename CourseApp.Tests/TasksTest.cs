namespace CourseApp.Tests
{
    using Xunit;

    public class TasksTest
    {
        [Theory]
        [InlineData(new[] { -2.17041, -1.77066, -1.47417, -1.23865, -1.04481, -0.88217 }, 0.11, 0.36, 0.05)]
        [InlineData(new[] { -2.17041, -1.77066, -1.47417, -1.23865 }, 0.11, 0.26, 0.05)]
        public void TaskA(double[] exp, double xn, double xk, double dx)
        {
            // arrange
            var equation = new Tasks();

            // act
            double[] res = equation.TaskA(xn, xk, dx);

            // assert
            Assert.Equal(res.Length, exp.Length);
        }

        [Theory]
        [InlineData(new[] { -1.52772, -1.08082, -0.82431, -0.69497, -0.42377 }, new[] { 0.2, 0.3, 0.38, 0.43, 0.57 })]
        [InlineData(new[] { -1.52772, -1.08082, -0.82431, double.NaN }, new[] { 0.2, 0.3, 0.38, -0.11 })]
        public void TaskB(double[] exp, double[] x)
        {
            // arrange
            var equation = new Tasks();

            // act
            double[] res = equation.TaskB(x);

            // assert
            Assert.Equal(res.Length, exp.Length);
            Assert.Equal(res.Length, x.Length);
        }

        [Theory]
        [InlineData(-0.11, double.NaN)]
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
