namespace PuzzleSolutions.Data
{
	using GuardNet;
	using Exceptions;
	using Utilities;

	internal class StreamReaderProvider: IStreamReaderProvider
	{
		private FileStream? _fileStream;
		private StreamReader? _streamReader;

		public async Task<StreamReader> GetFileStreamReader(string fileName)
		{
			Guard.NotNullOrEmpty<FileNameException>(fileName, "Filename can not be null or empty string!");
			var filePath = Path.Combine(PuzzleInputDataPaths.MyDocumentsDirectory, PuzzleInputDataPaths.InputDataDirectory, fileName);
			_fileStream = new FileStream(filePath, FileMode.Open);
			_streamReader = new StreamReader(_fileStream);
			return _streamReader;
		}

		public void Dispose()
		{
			_fileStream?.Dispose();
			_streamReader?.Dispose();
		}
	}
}
