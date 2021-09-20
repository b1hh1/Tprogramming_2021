namespace CourseApp.Tests
{
    using Xunit;

    public class TasksTest
    {
        [Fact]
        public void TaskA()
        {
            // arrange
            var equation = new Tasks();
            double xn = 0.11;
            double xk = 0.36;
            double dx = 0.05;
            int g = 0;
            double[] exp = { -2.17041, -1.77066, -1.47417, -1.23865, -1.04481, -0.88217 };

            // act
            double[] res = equation.TaskA(xn, xk, dx);

            // assert
            foreach (double i in res)
            {
                Assert.Equal(exp[g], i, 5);
                g++;
            }
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

        [Fact]
        public void EquationWithErr()
        {
            // arrange
            var equation = new Equation();
            var a = -0.11;
            var exp = double.NaN;

            // act
            var res = equation.Function(a);

            // assert
            Assert.Equal(exp, res, 5);
        }

        [Fact]
        public void EquationWithoutErr()
        {
            // arrange
            var equation = new Equation();
            var a = 0.11;
            var exp = -2.17041;

            // act
            var res = equation.Function(a);

            // assert
            Assert.Equal(exp, res, 5);
        }
    }
}
