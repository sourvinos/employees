using Contracts;
using NLog;

namespace LoggerService {

    public class LoggerManager : ILoggerManager {

        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();

        public LoggerManager() { }

        public void LogDebug(string message) {
            logger.Debug(message);
        }

        public void LogInfo(string message) {
            logger.Info(message);
        }

        public void LogError(string message) {
            logger.Error(message);
        }

        public void LogWarning(string message) {
            logger.Error(message);
        }

    }

}