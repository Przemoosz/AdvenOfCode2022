namespace PuzzleSolutions.Utilities.Logging;

internal interface ILogger
{
    public void LogError(string message);
    public void LogWarning(string message);
    public void LogInformation(string message);
    public void LogSuccess(string message);
}