namespace CourseApp
{
    using System;
    using static System.Math;

    public class Calculate
    {
        public double CalculateTask(double a, double b, double item)
        {
            var sin = Asin(Pow(item, a));
            var cos = Acos(Pow(item, b));
            return Round(sin + cos, 3);
        }
    }
}