namespace PuzzleSolutions.Puzzles.Day1
{
	using Objects;
	using Utilities.Logging;

	internal class DayOneSecondChallenge: IDayOneSecondChallenge
	{
		private readonly ICaloriesDivider _caloriesDivider;
		private readonly ILogger _logger;

		public DayOneSecondChallenge(ICaloriesDivider caloriesDivider, ILogger logger)
		{
			_caloriesDivider = caloriesDivider;
			_logger = logger;
		}

		public async Task SolvePuzzle()
		{
			List<Elf> elves = await _caloriesDivider.DivideCalories();
			elves.Sort();
			elves.Reverse();
			_logger.LogSuccess($"Solution: total amount of calories carried by 3 strongest elves is: {elves[0].TotalCalories + elves[1].TotalCalories + elves[2].TotalCalories}");
		}
	}
}
