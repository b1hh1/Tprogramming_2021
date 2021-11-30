namespace CourseApp.Tests
{
    using System;
    using Xunit;

    public class CalculatingAPersonsAgeTests
    {
        [Theory]
        [InlineData(new[] { 2002, 12, 20 }, new[] { 2021, 12, 20 }, "Congratulations on your 19th birthday !!!")]
        [InlineData(new[] { 2002, 12, 20 }, new[] { 2021, 11, 10 }, "You are 18 years, 10 months and 21 days")]
        [InlineData(new[] { 2002, 12, 20 }, new[] { 2022, 1, 3 }, "You are 19 years, 0 months and 14 days")]
        public void CalculatingAPersonsAge(int[] born, int[] end, string exp)
        {
            // arrange
            var mike = new CalculatingAPersonsAge();

            // act
            var res = mike.CalculatingAge(new DateTime(born[0], born[1], born[2]), new DateTime(end[0], end[1], end[2]));

            // assert
            Assert.Equal(exp, res);
        }
    }
}
