namespace CourseApp.Tests
{
    using Xunit;

    public class Tests
    {
        [Fact]
        public void TestTaskA1()
        {
            var a = 1.6;
            var x = 1.2;
            var expected = 0.8257;
            var execution = new Calculation();
            var actual = execution.Function(a, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskA2()
        {
            var a = 1.6;
            var x = 1.7;
            var expected = 0.9182;
            var execution = new Calculation();
            var actual = execution.Function(a, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskA3()
        {
            var a = 1.6;
            var x = 2.2;
            var expected = 3.9286;
            var execution = new Calculation();
            var actual = execution.Function(a, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskA4()
        {
            var a = 1.6;
            var x = 3.7;
            var expected = 385.8624;
            var execution = new Calculation();
            var actual = execution.Function(a, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskB1()
        {
            var a = 1.6;
            var x = 1.28;
            var expected = 0.6838;
            var execution = new Calculation();
            var actual = execution.Function(a, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskB2()
        {
            var a = 1.6;
            var x = 1.36;
            var expected = 0.6145;
            var execution = new Calculation();
            var actual = execution.Function(a, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskB3()
        {
            var a = 1.6;
            var x = 2.47;
            var expected = 8.566;
            var execution = new Calculation();
            var actual = execution.Function(a, x);
            Assert.Equal(expected, actual);
        }
    }
}