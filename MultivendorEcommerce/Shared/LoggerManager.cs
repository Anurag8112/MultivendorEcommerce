using NLog;

namespace MultivendorEcommerce.Shared
{
    public class LoggerManager : ILoggerManager
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        public void Error(string message) => logger.Error(message);
        public void Info(string message) => logger.Info(message);
        public void Warn(string message) => logger.Warn(message);
    }
}
