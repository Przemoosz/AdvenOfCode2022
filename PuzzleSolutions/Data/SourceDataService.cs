namespace PuzzleSolutions.Data
{
	using Dto;

	internal sealed class SourceDataService : ISourceDataService
	{
		private readonly IStreamReaderProvider _streamReaderProvider;

		public SourceDataService(IStreamReaderProvider streamReaderProvider)
		{
			_streamReaderProvider = streamReaderProvider;
		}

		public async Task<string> GetPuzzleInput(string fileName)
		{
			return await ( _streamReaderProvider.GetFileStreamReader(fileName)).ReadToEndAsync();
		}

		public async Task<IEnumerable<string>> GetPuzzleInputAsSeparateLines(string fileName)
		{
			List<string> inputLines = new List<string>();

			using (var streamReader = _streamReaderProvider.GetFileStreamReader(fileName))
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
			return inputLines;
		}

		public async Task<IEnumerable<TripleInput<string>>> GetPuzzleInputGroupedByThreeLines(string fileName)
		{
			List<TripleInput<string>> groupedByThreeLines = new List<TripleInput<string>>();
			using (var streamReader = _streamReaderProvider.GetFileStreamReader(fileName)) 
			{
				while (!streamReader.EndOfStream)
				{
					var firstLine = await streamReader.ReadLineAsync();
					var secondLine = await streamReader.ReadLineAsync();
					var thirdLine = await streamReader.ReadLineAsync();
					if (firstLine is null || secondLine is null || thirdLine is null)
					{
						continue;
					}
					TripleInput<string> tripleInput = new TripleInput<string>(firstLine, secondLine, thirdLine);
					groupedByThreeLines.Add(tripleInput);
				}
			}
			return groupedByThreeLines;
		}

		public async Task<IEnumerable<DoubleInput<string>>> GetPuzzleInputGroupedByTwoLines(string fileName)
		{
			List<DoubleInput<string>> groupedByTwoLines = new List<DoubleInput<string>>();
			using (var streamReader = _streamReaderProvider.GetFileStreamReader(fileName))
			{
				while (!streamReader.EndOfStream)
				{
					var firstLine = await streamReader.ReadLineAsync();
					var secondLine = await streamReader.ReadLineAsync();
					if (firstLine is null || secondLine is null)
					{
						continue;
					}
					DoubleInput<string> tripleInput = new DoubleInput<string>(firstLine, secondLine);
					groupedByTwoLines.Add(tripleInput);
				}
			}
			return groupedByTwoLines;
		}
	}
}
