namespace PuzzleSolutions.Puzzles.Day5
{
	using Data;
	using Dto;
	using System.Text;
	using Utilities.Logging;

	internal sealed class DayFiveSecondChallenge: IDayFiveSecondChallenge
	{
		private readonly IDayFiveInputDataResolver _dayFiveInputDataResolver;
		private readonly ILogger _logger;

		public DayFiveSecondChallenge(IDayFiveInputDataResolver dayFiveInputDataResolver, ILogger logger)
		{
			_dayFiveInputDataResolver = dayFiveInputDataResolver;
			_logger = logger;
		}
		public async Task SolvePuzzle()
		{
			var wrappedInput = await _dayFiveInputDataResolver.ResolveInput();
			foreach (Move move in wrappedInput.Moves)
			{
				LinkedList<char> movedContainers = new LinkedList<char>();
				for (int i = 0; i < move.NumberOfItems; i++)
				{
					movedContainers.AddFirst(wrappedInput.Stacks[move.From].Containers.Last!.Value);
					wrappedInput.Stacks[move.From].Containers.RemoveLast();
				}
				foreach (char container in movedContainers)
				{
					wrappedInput.Stacks[move.To].Containers.AddLast(container);
				}
			}

			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < wrappedInput.Stacks.Count + 1; i++)
			{
				stringBuilder.Append(wrappedInput.Stacks[i].Containers.Last!.Value);
			}
			_logger.LogSuccess(stringBuilder.ToString());
		}
	}
}
