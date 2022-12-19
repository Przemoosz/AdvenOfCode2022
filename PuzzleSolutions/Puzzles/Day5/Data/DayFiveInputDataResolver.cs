namespace PuzzleSolutions.Puzzles.Day5.Data
{
	using PuzzleSolutions.Data;
	using Dto;
	using Utilities;

	internal sealed class DayFiveInputDataResolver: IDayFiveInputDataResolver
	{
		private readonly IStreamReaderProvider _streamReaderProvider;
		private readonly IDataConverter _dataConverter;

		public DayFiveInputDataResolver(IStreamReaderProvider streamReaderProvider, IDataConverter dataConverter)
		{
			_streamReaderProvider = streamReaderProvider;
			_dataConverter = dataConverter;
		}

		public async Task<DayFiveWrappedInput> ResolveInput()
		{
			Dictionary<int,ContainerStack> containers = new Dictionary<int, ContainerStack>(9);
			List<Move> moves = new List<Move>();
			using (var streamReader =
			       _streamReaderProvider.GetFileStreamReader(PuzzleInputDataPaths.InputFileName(5, 1)))
			{
				int actualStackNumber = 1;
				// Load containers
				while (!streamReader.EndOfStream)
				{
					streamReader.Read(); // Skip '['
					var create = (char)streamReader.Read();
					if (create == '1')
					{
						break;
					}
					if (containers.TryGetValue(actualStackNumber, out var stack))
					{
						if (ValidateContainerContent(create))
						{
							stack.Containers.AddFirst(create);
						}
					}
					else
					{
						if (ValidateContainerContent(create))
						{
							var newStack = new LinkedList<char>();
							newStack.AddLast(create);
							containers.Add(actualStackNumber, new ContainerStack(){Containers = newStack});
						}
					}
					streamReader.Read(); // Skip ']'
					create = (char) streamReader.Read();
					if (create == ' ')
					{
						actualStackNumber++;
					}
					if (create == '\r')
					{
						streamReader.Read(); // Skip '/n'
						actualStackNumber =1;
					}
				}
				await streamReader.ReadLineAsync(); // Skip lines with numbers
				await streamReader.ReadLineAsync(); // Skip blank line
				// Load moves
				while (!streamReader.EndOfStream)
				{
					var line = await streamReader.ReadLineAsync();
					if (line is not null)
					{
						var parts = line.Trim().Split(' ');
						moves.Add(new Move(_dataConverter.ConvertToInt32(parts[1]).Value,
							_dataConverter.ConvertToInt32(parts[3]).Value,
							_dataConverter.ConvertToInt32(parts[5]).Value));
					}
				}
			}
			return new DayFiveWrappedInput(containers, moves);
		}

		private bool ValidateContainerContent(char content) => content != '[' && content != ']' && content != '\n' && content != ' ';
	}
}
