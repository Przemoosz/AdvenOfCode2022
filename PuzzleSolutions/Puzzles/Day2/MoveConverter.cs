namespace PuzzleSolutions.Puzzles.Day2
{
	using Exceptions;
	using Enums;
	using Objects;
	using Utilities.Logging;

	internal sealed class MoveConverter<TResult>: IMoveConverter<TResult> where TResult: IRound, new()
	{
		private readonly ILogger _logger;

		public MoveConverter(ILogger logger)
		{
			_logger = logger;
		}
		public TResult Convert(string line)
		{
			var moves = line.Trim().Split(" ");
			if (!Enum.TryParse<OpponentMove>(moves[0], out var opponentMove))
			{
				_logger.LogError("Failed to convert to OpponentMove enum");
				throw new DataConversionException<OpponentMove>("None");
			}
			if (!Enum.TryParse<ElfMove>(moves[1], out var elfMove))
			{
				_logger.LogError("Failed to convert to ElfMove enum");
				throw new DataConversionException<ElfMove>("None");
			}
			return new TResult(){ ElfMove = elfMove, OpponentMove = opponentMove};
		}
	}
}
