namespace MultivendorEcommerce.Shared
{
    public interface ILoggerManager
    {
        void Info(string message);
        void Warn(string message);
        void Error(string message);
    }
}
