namespace CourseApp
{
    public class Tasks
    {
        public double[] TaskA(double xn, double xk, double dx)
        {
            double[] results_task_A;
            int i = 0;
            while (xn <= xk)
	        {
		        results_task_A[i] = Equation.Function(xn);
                i++;
		        xn = xn + dx;
	        }
        }
}
}
