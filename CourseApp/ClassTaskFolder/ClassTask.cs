namespace CourseApp.Class
{
    using System;
    using System.Collections.Generic;

    public class ClassTask
    {
        public ClassTask(string name, string extension, double weight, string weightModificator)
        {
            Document file = new FileCreator(name, extension, weight, weightModificator);
            Console.WriteLine($"Your file: {file.Display()}");
        }

        public ClassTask()
        {
            Document file = new FileCreator();
            Console.WriteLine($"Default file: {file.Display()}");
        }
    }
}
