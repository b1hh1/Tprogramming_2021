namespace CourseApp.Tests
{
    using CourseApp.Program;
    using Xunit;

    public class UnitTests
    {
        [Theory]
        [InlineData(3, 2, 0.11, 1.56)]
        [InlineData(3, 2, 0.36, 1.488)]
        [InlineData(3, 2, 0.08, 1.565)]
        [InlineData(3, 2, 0.026, 1.57)]
        [InlineData(3, 2, 0.35, 1.491)]
        [InlineData(3, 2, 0.41, 1.471)]
        [InlineData(3, 2, 0.51, 1.441)]
        public void TestCalculate(double a, double b, double x, double expected)
        {
            var task = new CalculateTasks(a, b);
            var (_, actual) = task.CalculateValue(x);
            Assert.Equal(expected, actual, 3);
        }

        [Theory]
        [InlineData(0.1, 0.5, 0.1, 5)]
        [InlineData(0, 5, 1, 6)]
        [InlineData(0.25, 0.5, 0.05, 6)]
        [InlineData(1.2, 2.4, 1.2, 2)]
        public void TestListCount(double start, double end, double delta, int expected)
        {
            var task = new CalculateTasks(start, end, delta);
            var actual = task.ListValue().Count;
            Assert.Equal(expected, actual);
        }
    }
}
