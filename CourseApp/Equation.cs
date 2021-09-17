namespace CourseApp
{
    using System;

    public class Equation
    {
        public double Function(double x = 0)
        {
            double sinAngle = Math.Sin(x);
            double cosAngle = Math.Cos(x);
            return ((sinAngle * sinAngle * sinAngle) + (cosAngle * cosAngle * cosAngle)) * Math.Log(x);
        }
    }
}
