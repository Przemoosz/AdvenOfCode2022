namespace PuzzleSolutions.Utilities.Logging;

internal interface ILoggerOptions
{
    public bool UseDataStamp { get; }
    public bool UseLogTypeStamp { get; }
}