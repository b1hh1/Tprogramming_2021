namespace CourseApp.Tests
{
    using CourseApp.Program;
    using CourseApp.Program.Input;
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
            var actual = task.CalculateValue(x).Item2;
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

        [Theory]
        [InlineData(0, -1, 2, true)]
        [InlineData(0, 1, 2, false)]
        [InlineData(1, 0, 2, true)]
        [InlineData(1, 1, 2, true)]
        public void TestCheckValuesInputInt(int input, int min, int max, bool expected)
        {
            var check = new CheckValues();
            var actual = check.IsValidInt(input, min, max);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0.1, -1, 2, true)]
        [InlineData(0.5, 1, 2, false)]
        [InlineData(1, 0, 2, true)]
        [InlineData(1.2, 1, 2, true)]
        public void TestCheckValuesInputDouble(double input, double min, double max, bool expected)
        {
            var check = new CheckValues();
            var actual = check.IsValidDouble(input, min, max);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("2", 0, 3, true)]
        [InlineData("-1", 0, 3, false)]
        [InlineData("r", 0, 3, false)]
        [InlineData("-1.2", -2, -1, false)]
        [InlineData("4.1", 4, 5, false)]
        [InlineData(" ", 4, 4, false)]
        public void TestInputInt(string item, int minValue, int maxValue, bool expected)
        {
            var input = new InputValues();
            var actual = input.InputInt(minValue, maxValue, item);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("2,2", 0, 3, true)]
        [InlineData("-1,5", 0, 3, false)]
        [InlineData("r", 0, 3, false)]
        [InlineData("-1", -2, -1, true)]
        [InlineData("4,1", 4, 5, true)]
        [InlineData(" ", 4, 4, false)]
        public void TestInputDouble(string item, int minValue, int maxValue, bool expected)
        {
            var input = new InputValues();
            var actual = input.InputDouble(minValue, maxValue, item);
            Assert.Equal(expected, actual);
        }
    }
}
