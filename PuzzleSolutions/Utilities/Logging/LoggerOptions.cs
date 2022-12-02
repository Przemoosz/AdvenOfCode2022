namespace PuzzleSolutions.Utilities.Logging
{
    internal sealed class LoggerOptions : ILoggerOptions
    {
        public LoggerOptions(bool useDataStamp = true, bool useLogTypeStamp = true)
        {
            UseDataStamp = useDataStamp;
            UseLogTypeStamp = useLogTypeStamp;
        }

        public bool UseDataStamp { get; set; }
        public bool UseLogTypeStamp { get; set; }
    }
}
