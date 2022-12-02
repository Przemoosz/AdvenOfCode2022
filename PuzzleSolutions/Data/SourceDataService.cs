namespace PuzzleSolutions.Data
{
	using Utilities;
	using GuardNet;
	using Exceptions;
	internal sealed class SourceDataService : ISourceDataService
	{
		public async Task<string> GetPuzzleInput(string fileName)
		{
			Guard.NotNullOrEmpty<FileNameException>(fileName, "Filename can not be null or empty string!");
			var filePath = Path.Combine(PuzzleInputDataPaths.MyDocumentsDirectory,PuzzleInputDataPaths.InputDataDirectory, fileName);
			await using (var fileStream = new FileStream(filePath, FileMode.Open))
			{
				using (var streamReader = new StreamReader(fileStream))
				{
					return await streamReader.ReadToEndAsync();
				}
			}
		}

		public async Task<IEnumerable<string>> GetPuzzleInputAsSeparateLines(string fileName)
		{
			Guard.NotNullOrEmpty<FileNameException>(fileName, "Filename can not be null or empty string!");
			var filePath = Path.Combine(PuzzleInputDataPaths.MyDocumentsDirectory, PuzzleInputDataPaths.InputDataDirectory, fileName);
			List<string> inputLines = new List<string>();
			await using (var fileStream = new FileStream(filePath, FileMode.Open))
			{
				using (var streamReader = new StreamReader(fileStream))
				{
					while (!streamReader.EndOfStream)
					{
						var line = await streamReader.ReadLineAsync();
						if (line is null)
						{
							continue;
						}
						inputLines.Add(line);
					}
				}
			}
			return inputLines;
		}
	}
}
