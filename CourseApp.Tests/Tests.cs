namespace CourseApp.Tests
{
    using Xunit;

    public class Tests
    {
        [Theory]
        [InlineData(1.23, 1.617)]
        [InlineData(6.03, 2.996)]
        [InlineData(3.84, 2.549)]
        [InlineData(-6.21, 3.39)]
        public void RunTest(double x, double expected)
        {
            var a = 0.8;
            var b = 0.4;
            var execution = new Calc();
            var actual = execution.CalcFunc(a, b, x);
            Assert.Equal(expected, actual, 3);
        }
    }
}