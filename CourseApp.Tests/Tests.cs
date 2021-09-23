namespace CourseApp.Tests
{
    using Xunit;

    public class Tests
    {
        [Fact]
        public void TestTaskA1()
        {
            var a = 0.8;
            var b = 0.4;
            var x = 1.23;
            var expected = 2.342;
            var execution = new Calc();
            var actual = execution.CalcFunc(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskA2()
        {
            var a = 0.8;
            var b = 0.4;
            var x = 6.03;
            var expected = 2.749;
            var execution = new Calc();
            var actual = execution.CalcFunc(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskA3()
        {
            var a = 0.8;
            var b = 0.4;
            var x = 3.63;
            var expected = 2.155;
            var execution = new Calc();
            var actual = execution.CalcFunc(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskA4()
        {
            var a = 0.8;
            var b = 0.4;
            var x = 4.83;
            var expected = 2.486;
            var execution = new Calc();
            var actual = execution.CalcFunc(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskB1()
        {
            var a = 0.8;
            var b = 0.4;
            var x = 3.84;
            var expected = 2.22;
            var execution = new Calc();
            var actual = execution.CalcFunc(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskB2()
        {
            var a = 0.8;
            var b = 0.4;
            var x = 4.55;
            var expected = 2.416;
            var execution = new Calc();
            var actual = execution.CalcFunc(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskB3()
        {
            var a = 0.8;
            var b = 0.4;
            var x = -6.21;
            var expected = 3.564;
            var execution = new Calc();
            var actual = execution.CalcFunc(a, b, x);
            Assert.Equal(expected, actual);
        }
    }
} 