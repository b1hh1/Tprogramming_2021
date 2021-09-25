namespace CourseApp.Tests
{
    using Xunit;
    using static System.Math;

    public class TestForCalculateTasks
    {
        [Theory]
        [InlineData(0.11, 1.56)]
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
            Assert.Equal(expected, Round(actual, 3));
        }
    }
}
