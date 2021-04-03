using System;

namespace DemoLibrary.Utilities
{
    public class NewLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging with new logger { message }");
        }
    }
}
