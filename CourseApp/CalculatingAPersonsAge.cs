namespace CourseApp
{
    using System;

    public class CalculatingAPersonsAge
    {
        public void Dgf(int day, int month, int year)
        {
            long date1 = DateTime.Today.Ticks; // 20.07.2015 18:30:25
            long date2 = new DateTime(year, month, day).Ticks; // 20.07.2015 15:30:25
            long diff = date1 - date2;
            DateTime dDate = DateTime.MinValue.AddTicks(diff);
            Console.WriteLine($"You are {dDate.Year - 1} years, {dDate.Month - 1} months and {dDate.Day - 2} days");
        }
    }
}
