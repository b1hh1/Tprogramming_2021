namespace CourseApp.Tests
{
    using Xunit;

    public class TestForCalculateTasks
    {
        [Fact]
        public void TestCalculateOne1()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.11;
            var expected = 1.582;
            var calculateTask = new CalculateTasks();
            var actual = calculateTask.Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCalculateOne2()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.16;
            var expected = 1.592;
            var calculateTask = new CalculateTasks();
            var actual = calculateTask.Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCalculateOne3()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.21;
            var expected = 1.606;
            var calculateTask = new CalculateTasks();
            var actual = calculateTask.Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCalculateOne4()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.26;
            var expected = 1.621;
            var calculateTask = new CalculateTasks();
            var actual = calculateTask.Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCalculateOne5()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.31;
            var expected = 1.637;
            var calculateTask = new CalculateTasks();
            var actual = calculateTask.Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCalculateOne6()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.36;
            var expected = 1.654;
            var calculateTask = new CalculateTasks();
            var actual = calculateTask.Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCalculateTwo1()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.08;
            var expected = 1.577;
            var calculateTask = new CalculateTasks();
            var actual = calculateTask.Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCalculateTwo2()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.026;
            var expected = 1.571;
            var calculateTask = new CalculateTasks();
            var actual = calculateTask.Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCalculateTwo3()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.35;
            var expected = 1.651;
            var calculateTask = new CalculateTasks();
            var actual = calculateTask.Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCalculateTwo4()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.41;
            var expected = 1.671;
            var calculateTask = new CalculateTasks();
            var actual = calculateTask.Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCalculateTwo5()
        {
            var a = 2.0;
            var b = 3.0;
            var x = 0.51;
            var expected = 1.701;
            var calculateTask = new CalculateTasks();
            var actual = calculateTask.Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }
    }
}
