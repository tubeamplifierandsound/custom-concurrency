namespace LogginingServices
{
    public class ConsoleLogger : ILogger
    {
        public void LogInfo(string infoMess) =>
            Console.WriteLine($"Log (Info): {infoMess}");
        public void LogWarning(string warningMess) =>
            Console.WriteLine($"Log (Warning): {warningMess}");
        public void LogError(string errorMess, Exception? ex) =>
            Console.WriteLine($"Log (Error): {errorMess}; {ex?.Message}");
    }
}
