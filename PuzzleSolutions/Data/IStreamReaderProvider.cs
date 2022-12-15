namespace PuzzleSolutions.Data;

internal interface IStreamReaderProvider: IDisposable
{
	Task<StreamReader> GetFileStreamReader(string fileName);
}