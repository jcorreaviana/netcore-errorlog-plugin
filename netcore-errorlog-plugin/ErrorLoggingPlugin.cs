using Microsoft.Extensions.Logging;

namespace ErrorLoggingPlugin
{
    public static class ErrorLoggerExtensions
    {
        public static ILoggerFactory AddErrorLogger(this ILoggerFactory factory)
        {
            factory.AddProvider(new ErrorLoggerProvider());
            return factory;
        }
    }

    public class ErrorLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName) => new ErrorLogger();

        public void Dispose() { }
    }
}