namespace CourseApp.Tests
{
    using Xunit;

    public class TasksTest
    {
        [Theory]
        [InlineData(-2.17041, -1.77066, -1.47417, -1.23865, -1.04481, -0.88217)]
        public void TaskA(double a, double b, double c, double d, double e, double f)
        {
            // arrange
            var equation = new Tasks();
            double xn = 0.11;
            double xk = 0.36;
            double dx = 0.05;

            // act
            double[] res = equation.TaskA(xn, xk, dx);

            // assert
            Assert.Equal(a, res[0], 5);
            Assert.Equal(b, res[1], 5);
            Assert.Equal(c, res[2], 5);
            Assert.Equal(d, res[3], 5);
            Assert.Equal(e, res[4], 5);
            Assert.Equal(f, res[5], 5);
        }

        [Fact]
        public void TaskBWithoutErr()
        {
            // arrange
            var equation = new Tasks();
            double[] x = { 0.2, 0.3, 0.38, 0.43, 0.57 };
            int g = 0;
            double[] exp = { -1.52772, -1.08082, -0.82431, -0.69497, -0.42377 };

            // act
            double[] res = equation.TaskB(x);

            // assert
            foreach (double i in res)
            {
                Assert.Equal(exp[g], i, 5);
                g++;
            }
        }

        [Fact]
        public void TaskBWithErr()
        {
            // arrange
            var equation = new Tasks();
            double[] x = { 0.2, 0.3, 0.38, 0.43, 0.57, -0.11 };
            int g = 0;
            double[] exp = { -1.52772, -1.08082, -0.82431, -0.69497, -0.42377, double.NaN };

            // act
            double[] res = equation.TaskB(x);

            // assert
            foreach (double i in res)
            {
                Assert.Equal(exp[g], i, 5);
                g++;
            }
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
