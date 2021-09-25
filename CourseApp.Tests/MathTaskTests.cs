namespace CourseApp.Tests
{
    using CourseApp.Tasks.MathTask;
    using Xunit;

    public class MathTaskTests
    {
        private readonly MathTaskService _mathTaskService;

        public MathTaskTests()
        {
            _mathTaskService = new MathTaskService();
        }

        [Theory]
        [InlineData(0, 1.571)]
        [InlineData(0.5, 1.047)]
        [InlineData(-0.5, 2.094)]
        public void ShouldCalculateACosIfValueLessThanOne(double x, double expected)
        {
            // Act
            var result = _mathTaskService.Calculate(x);

            // Assert
            Assert.Equal(expected, result, 3);
        }

        [Theory]
        [InlineData(1, 0.2)]
        [InlineData(2, -0.857)]
        [InlineData(-2, double.NaN)]
        public void ShouldCalculatePowIfValueGreaterOrEqualsThanOne(double x, double expected)
        {
            // Act
            var result = _mathTaskService.Calculate(x);

            // Assert
            Assert.Equal(expected, result, 3);
        }
    }
}
