namespace PuzzleSolutions.Puzzles.Day1
{
	using Utilities.Logging;
	using Objects;
	internal sealed class DayOneFirstChallenge: IDayOneFirstChallenge
	{
		private readonly ICaloriesDivider _caloriesDivider;
		private readonly ILogger _logger;

		public DayOneFirstChallenge(ICaloriesDivider caloriesDivider, ILogger logger)
		{
			_caloriesDivider = caloriesDivider;
			_logger = logger;
		}
		public async Task SolvePuzzle()
		{
			List<Elf> elves = await _caloriesDivider.DivideCalories();
			elves.Sort();
			elves.Reverse();
			_logger.LogSuccess($"Highest amount of calories carried by elf is: {elves[0].TotalCalories}");
		}
	}
}
