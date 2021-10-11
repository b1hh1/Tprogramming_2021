namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using static System.Math;

    public class CalculateTasks
    {
        public CalculateTasks(double aValue, double bValue, double startValue, double endValue, double deltaValue)
        {
            AValue = aValue;
            BValue = bValue;
            StartValue = startValue;
            EndValue = endValue;
            DeltaValue = deltaValue;
        }

        public CalculateTasks(double aValue, double bValue)
        {
            AValue = aValue;
            BValue = bValue;
        }

        public double StartValue { get; set; }

        public double EndValue { get; set; }

        public double DeltaValue { get; set; }

        public double AValue { get; set; }

        public double BValue { get; set; }

        public List<(double, double)> StartCalculate(List<double> listValue)
        {
            var list = new List<(double, double)>();
            foreach (double x in listValue)
            {
                var value = CalculateValue(x);
                list.Add((value.Item1, value.Item2));
            }

            return list;
        }

        public List<double> ListValue()
        {
            var listValue = new List<double>();
            for (double x = StartValue; x <= EndValue; x += DeltaValue)
            {
                listValue.Add(x);
            }

            return listValue;
        }

        public (double, double) CalculateValue(double x)
        {
            var sin = Asin(Pow(x, AValue));
            var cos = Acos(Pow(x, BValue));
            return (x, sin + cos);
        }
    }
}