namespace PuzzleSolutions.Puzzles.Day5.Data
{
	using PuzzleSolutions.Data;
	using Dto;
	using Utilities;
	internal sealed class DayFiveInputDataResolver: IDayFiveInputDataResolver
	{
		private readonly IStreamReaderProvider _streamReaderProvider;

		public DayFiveInputDataResolver(IStreamReaderProvider streamReaderProvider)
		{
			_streamReaderProvider = streamReaderProvider;
		}

		public async Task<List<ContainerStack>> ResolveInput()
		{
			using (var streamReader =
			       await _streamReaderProvider.GetFileStreamReader(PuzzleInputDataPaths.InputFileName(5, 1)))
			{
				while (!streamReader.EndOfStream)
				{
					var c = (char) streamReader.Read();
				}
			}
			return new List<ContainerStack>();
		}
	}
}
