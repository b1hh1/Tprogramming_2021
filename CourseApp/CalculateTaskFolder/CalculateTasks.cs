namespace CourseApp.Calculate
{
    using System;
    using System.Collections.Generic;
    using static System.Math;

    public class CalculateTasks
    {
        private double _startValue;
        private double _endValue;
        private double _deltaValue;
        private double _aValue;
        private double _bValue;

        public CalculateTasks()
        {
            AValue = 2.0;
            BValue = 3.0;
            StartValue = 0.11;
            EndValue = 0.36;
            DeltaValue = 0.05;
            var listTaskOne = new List<double>() { };
            var listTaskTwo = new List<double>() { 0.08, 0.026, 0.35, 0.41, 0.51 };
            StartCalculate(listTaskOne, listTaskTwo);
        }

        public CalculateTasks(double aValue, double bValue, double startValue, double endValue, double deltaValue)
        {
            AValue = aValue;
            BValue = bValue;
            StartValue = startValue;
            EndValue = endValue;
            DeltaValue = deltaValue;
            var listTaskOne = new List<double>() { };
            var listTaskTwo = new List<double>() { 0.08, 0.026, 0.35, 0.41, 0.51 };
            StartCalculate(listTaskOne, listTaskTwo);
        }

        public double StartValue
        {
            get
            {
                return _startValue;
            }

            set
            {
                CheckValue(value);
                _startValue = value;
            }
        }

        public double EndValue
        {
            get
            {
                return _endValue;
            }

            set
            {
                CheckValue(value);
                _endValue = value;
            }
        }

        public double DeltaValue
        {
            get
            {
                return _deltaValue;
            }

            set
            {
                CheckValue(value);
                _deltaValue = value;
            }
        }

        public double AValue
        {
            get
            {
                return _aValue;
            }

            set
            {
                CheckValue(value);
                _aValue = value;
            }
        }

        public double BValue
        {
            get
            {
                return _bValue;
            }

            set
            {
                CheckValue(value);
                _bValue = value;
            }
        }

        public string Output { get; set; }

        public (double, double) CalculateValue(double x)
        {
            var sin = Asin(Pow(x, AValue));
            var cos = Acos(Pow(x, BValue));
            return (x, sin + cos);
        }

        public double CalculateValue(double a, double b, double x)
        {
            var sin = Asin(Pow(x, a));
            var cos = Acos(Pow(x, b));
            return sin + cos;
        }

        private void WriteValueInString(double x)
        {
            var value = CalculateValue(x);
            Output += $"x = {value.Item1:f2} y = {value.Item2:f2} | ";
        }

        private void TaskOneList(List<double> listTaskOne)
        {
            for (double x = StartValue; x <= EndValue; x += DeltaValue)
            {
                listTaskOne.Add(x);
            }
        }

        private void StartCalculate(List<double> listTaskOne, List<double> listTaskTwo)
        {
            TaskOneList(listTaskOne);
            Output = "Task One: ";
            foreach (double x in listTaskOne)
            {
                WriteValueInString(x);
            }

            Console.WriteLine(Output);
            Output = "Task Two: ";
            foreach (double x in listTaskTwo)
            {
                WriteValueInString(x);
            }

            Console.WriteLine(Output);
        }

        private void CheckValue(double value)
        {
            if (value == double.NaN)
            {
                throw new Exception("Invalid value. Value is out of range.");
            }
        }
    }
}