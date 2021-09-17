namespace CourseApp.Tests
{
    using Xunit;

    public class CalculateTest
    {
        [Fact]
        public void TestTaskOne1()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.11;
            var expected = 1.582;
            Calculate calculateTask = new Calculate();
            var actual = calculateTask.CalculateTask(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskOne2()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.16;
            var expected = 1.592;
            Calculate calculateTask = new Calculate();
            var actual = calculateTask.CalculateTask(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskOne3()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.21;
            var expected = 1.606;
            Calculate calculateTask = new Calculate();
            var actual = calculateTask.CalculateTask(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskOne4()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.26;
            var expected = 1.621;
            Calculate calculateTask = new Calculate();
            var actual = calculateTask.CalculateTask(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskOne5()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.31;
            var expected = 1.637;
            Calculate calculateTask = new Calculate();
            var actual = calculateTask.CalculateTask(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskOne6()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.36;
            var expected = 1.654;
            Calculate calculateTask = new Calculate();
            var actual = calculateTask.CalculateTask(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskTwo1()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.08;
            var expected = 1.577;
            Calculate calculateTask = new Calculate();
            var actual = calculateTask.CalculateTask(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskTwo2()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.026;
            var expected = 1.571;
            Calculate calculateTask = new Calculate();
            var actual = calculateTask.CalculateTask(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskTwo3()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.35;
            var expected = 1.651;
            Calculate calculateTask = new Calculate();
            var actual = calculateTask.CalculateTask(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskTwo4()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.41;
            var expected = 1.671;
            Calculate calculateTask = new Calculate();
            var actual = calculateTask.CalculateTask(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTaskTwo5()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.51;
            var expected = 1.701;
            Calculate calculateTask = new Calculate();
            var actual = calculateTask.CalculateTask(a, b, x);
            Assert.Equal(expected, actual);
        }
    }
}
