namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Calculation : MainFunction
    {
        public List<double> CalcTaskA(double a, double b, double xs, double xe, double dx, List<double> listA)
        {
            for (double x = xs; x <= xe; x += dx)
            {
                listA.Add(CalculationFuncion(a, b, x));
            }

            return listA;
        }

        public List<double> CalcTaskB(double a, double b, List<double> listB, List<double> listTaskB)
        {
            foreach (var x in listTaskB)
            {
                listB.Add(CalculationFuncion(a, b, x));
            }

            return listB;
        }
    }
}