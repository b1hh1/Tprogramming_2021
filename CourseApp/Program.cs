namespace CourseApp
{
    using CourseApp.Core;
    using CourseApp.Tasks.MathTask;

    public class Program
    {
        public static void Main(string[] args)
        {
            TaskRunner.Run<MathTask>();
        }
    }
}
