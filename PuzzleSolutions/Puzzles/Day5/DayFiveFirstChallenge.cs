namespace PuzzleSolutions.Puzzles.Day5
{
	using Data;
	using System.Text;
	using Dto;
	using Utilities.Logging;

	internal class DayFiveFirstChallenge: IDayFiveFirstChallenge
	{
		private readonly IDayFiveInputDataResolver _dayFiveInputDataResolver;
		private readonly ILogger _logger;

		public DayFiveFirstChallenge(IDayFiveInputDataResolver dayFiveInputDataResolver, ILogger logger)
		{
			_dayFiveInputDataResolver = dayFiveInputDataResolver;
			_logger = logger;
		}

		public async Task SolvePuzzle()
		{
			
			var wrappedInput = await _dayFiveInputDataResolver.ResolveInput();
			foreach (Move move in wrappedInput.Moves)
			{
				for(int i=0; i<move.NumberOfItems; i++)
				{
					var container = wrappedInput.Stacks[move.From].Containers.Last.Value;
					wrappedInput.Stacks[move.From].Containers.RemoveLast();
					wrappedInput.Stacks[move.To].Containers.AddLast(container);
				}
			}

			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < wrappedInput.Stacks.Count+1; i++)
			{
				////var containers = wrappedInput.Stacks[i].Containers.ToArray();
				stringBuilder.Append(wrappedInput.Stacks[i].Containers.First.Value);
			}
			_logger.LogSuccess(stringBuilder.ToString());
		}
	}
}
