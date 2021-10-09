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
            var listTaskTwo = new List<double>() { 0.08, 0.026, 0.35, 0.41, 0.51 };
            Display = $"{StartCalculate(ListValue())}\r\n{StartCalculate(listTaskTwo)}";
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

        public string Display { get; set; }

        public double CalculateValue(double x)
        {
            var sin = Asin(Pow(x, AValue));
            var cos = Acos(Pow(x, BValue));
            return sin + cos;
        }

        private List<double> ListValue()
        {
            var listValue = new List<double>();
            for (double x = StartValue; x <= EndValue; x += DeltaValue)
            {
                listValue.Add(x);
            }

            return listValue;
        }

        private string StartCalculate(List<double> listValues)
        {
            var str = string.Empty;
            str += "Task: ";
            foreach (double x in listValues)
            {
                var value = CalculateValue(x);
                str += $"x = {x:f2} y = {value:f2} | ";
            }

            return str;
        }
    }
}