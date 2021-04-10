using System;

namespace DemoLibrary.Utilities
{
    public class NewLogger : ILogger
    {
        public string _loggerdId { get; set; }

        public NewLogger(string loggerdId)
        {
            _loggerdId = loggerdId;
        }

        public void Log(string message)
        {
            Console.WriteLine($"Logging with logger {_loggerdId} : { message }");
        }
    }
}
