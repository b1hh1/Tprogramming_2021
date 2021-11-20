namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var mike = new CalculatingAPersonsAge();
            Console.WriteLine(mike.CalculatingAge(new DateTime(2002, 12, 20), new DateTime(2022, 1, 3)));
        }
    }
}
