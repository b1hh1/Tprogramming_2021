namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine(calc.Multi(5, 10));
            Console.ReadLine();
        }
    }
}
