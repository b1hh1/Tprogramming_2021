namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class ClassTask
    {
        public ClassTask(string name, string extension, double weight, string weightModificator)
        {
            Document textFile = new FileCreator(name, extension, weight, weightModificator);
            Console.WriteLine(textFile.Display());
        }

        public ClassTask()
        {
            Document textFile = new FileCreator();
            Console.WriteLine(textFile.Display());
        }
    }
}
