namespace PuzzleSolutions.Utilities.Logging
{
    internal class Logger : ILogger
    {
        public ILoggerOptions LoggerOptions { get; set; } = new LoggerOptions();

        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (LoggerOptions.UseDataStamp)
                message = $"Error - {message}";
            WriteLogs(message);
        }

        public void LogWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (LoggerOptions.UseLogTypeStamp)
                message = $"Warning - {message}";
            WriteLogs(message);
        }

        public void LogInformation(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            if (LoggerOptions.UseLogTypeStamp)
                message = $"Information - {message}";
            WriteLogs(message);
        }

        public void LogSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (LoggerOptions.UseLogTypeStamp)
                message = $"Success - {message}";
            WriteLogs(message);
        }

        private void WriteLogs(string message)
        {
            if (LoggerOptions.UseDataStamp)
            {
                message = $"[{DateTime.Now:HH:mm:ss}] - {message}";
            }
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
