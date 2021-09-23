namespace CourseApp.Tests
{
    using Xunit;

    public class TestForCalculateTasks
    {
        [Theory]
        [InlineData(0.11, 1.582)]
        [InlineData(0.16, 1.592)]
        [InlineData(0.21, 1.606)]
        [InlineData(0.26, 1.621)]
        [InlineData(0.31, 1.637)]
        [InlineData(0.36, 1.654)]
        [InlineData(0.08, 1.577)]
        [InlineData(0.026, 1.571)]
        [InlineData(0.35, 1.651)]
        [InlineData(0.41, 1.671)]
        [InlineData(0.51, 1.701)]
        public void TestCalculateOne(double x, double expected)
        {
            var a = 2.0;
            var b = 3.0;
            var calculateTask = new CalculateTasks();
            var actual = calculateTask.Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0.11, 1.56)]
        [InlineData(0.16, 1.549)]
        [InlineData(0.21, 1.536)]
        [InlineData(0.26, 1.521)]
        [InlineData(0.31, 1.504)]
        [InlineData(0.36, 1.488)]
        [InlineData(0.08, 1.565)]
        [InlineData(0.026, 1.57)]
        [InlineData(0.35, 1.491)]
        [InlineData(0.41, 1.471)]
        [InlineData(0.51, 1.441)]
        public void TestCalculateTwo(double x, double expected)
        {
            var a = 3.0;
            var b = 2.0;
            var calculateTask = new CalculateTasks();
            var actual = calculateTask.Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }
    }
}
