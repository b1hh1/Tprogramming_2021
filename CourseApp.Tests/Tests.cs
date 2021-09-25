namespace CourseApp.Tests
{
    using Xunit;

    public class Tests
    {
        [Theory]
        [InlineData(1.2, 0.8256)]
        [InlineData(1.7, 0.9182)]
        [InlineData(2.2, 3.9286)]
        [InlineData(3.7, 385.8624)]
        public void RunTest(double x, double expected)
        {
            var a = 1.6;
            var execution = new Calculation();
            var actual = execution.Function(a, x);
            Assert.Equal(expected, actual, 3);
        }
    }
}