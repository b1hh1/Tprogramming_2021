namespace CourseApp.Tests
{
    using Xunit;

    public class CalculatorTest
    {
        [Fact]
        public void SumInt()
        {
            var calc = new Calculator();
            int a = 10;
            int b = 3;
            var exp = 13;

            var res = calc.Sum(a, b);

            Assert.Equal(exp, res);
        }

        [Fact]
        public void SumFloat()
        {
            var calc = new Calculator();
            float a = 43.123675f;
            float b = 32.812398f;
            var exp = 75.936073f;

            var res = calc.Sum(a, b);

            Assert.Equal(exp, res);
        }

        [Fact]
        public void SumDouble()
        {
            var calc = new Calculator();
            double a = 67.123;
            double b = 3.002;
            var exp = 70.125;

            var res = calc.Sum(a, b);

            Assert.Equal(exp, res);
        }

        [Fact]
        public void SumDecimal()
        {
            var calc = new Calculator();
            decimal a = 2.5231m;
            decimal b = 34.42342m;
            var exp = 36.94652m;

            var res = calc.Sum(a, b);

            Assert.Equal(exp, res);
        }

        [Fact]
        public void SubInt()
        {
            var calc = new Calculator();
            int a = 10;
            int b = 0;
            var exp = 10;

            var res = calc.Sub(a, b);

            Assert.Equal(exp, res);
        }

        [Fact]
        public void SubFloat()
        {
            var calc = new Calculator();
            float a = 0.0f;
            float b = 32.812398f;
            var exp = -32.812398f;

            var res = calc.Sub(a, b);

            Assert.Equal(exp, res);
        }

        [Fact]
        public void SubDouble()
        {
            var calc = new Calculator();
            double a = 67.123;
            double b = 3.002;
            var exp = 64.121;

            var res = calc.Sub(a, b);

            Assert.Equal(exp, res, 3);
        }

        [Fact]
        public void SubDecimal()
        {
            var calc = new Calculator();
            decimal a = 2.5231m;
            decimal b = 34.42342m;
            var exp = -31.90032m;

            var res = calc.Sub(a, b);

            Assert.Equal(exp, res);
        }
    }
}
