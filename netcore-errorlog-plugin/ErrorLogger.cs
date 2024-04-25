using Microsoft.Extensions.Logging;
using System;

namespace ErrorLoggingPlugin
{
    public class ErrorLogger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state) => default;

        public bool IsEnabled(LogLevel logLevel) => logLevel == LogLevel.Error;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                return;
            }

            // Log the error message to your desired sink (console, file, etc.)
            Console.WriteLine($"Error: {formatter(state, exception)}");
        }
    }
}