namespace PuzzleSolutions.Data;

internal interface IStreamReaderProvider: IDisposable
{
	StreamReader GetFileStreamReader(string fileName);
}