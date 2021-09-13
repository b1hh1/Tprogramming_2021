namespace CourseApp.Tasks.MathTask
{
    using System;
    using System.Collections.Generic;

    public class MathTaskService
    {
        public double Calculate(double x)
        {
            if (Math.Abs(x) < 1)
            {
                return Math.Acos(x);
            }

            return Math.Pow(1.2, x) - Math.Pow(x, 1.2);
        }

        public IEnumerable<(double, double)> CalculateRange(double xStart, double xEnd, double xDelta)
        {
            for (var x = xStart; x <= xEnd; x += xDelta)
            {
                var y = Calculate(x);
                yield return (x, y);
            }
        }

        public IEnumerable<(double, double)> CalculateRange(IEnumerable<double> xs)
        {
            foreach (var x in xs)
            {
                var y = Calculate(x);
                yield return (x, y);
            }
        }
    }
}
