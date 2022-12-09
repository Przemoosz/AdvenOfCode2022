namespace PuzzleSolutions.Puzzles.Day3
{
	using Data;
	using Utilities;
	using Data.Dto;
	using Priorities;
	using Utilities.Logging;

	internal class DayThreeSecondChallenge: IDayThreeSecondChallenge
	{
		private readonly ISourceDataService _sourceDataService;
		private readonly ITripleRucksackSorter _tripleRucksackSorter;
		private readonly IPrioritiesCalculator _prioritiesCalculator;
		private readonly ILogger _logger;

		public DayThreeSecondChallenge(ISourceDataService sourceDataService, ITripleRucksackSorter tripleRucksackSorter,
			IPrioritiesCalculator prioritiesCalculator, ILogger logger)
		{
			_sourceDataService = sourceDataService;
			_tripleRucksackSorter = tripleRucksackSorter;
			_prioritiesCalculator = prioritiesCalculator;
			_logger = logger;
		}
		public async Task SolvePuzzle()
		{
			int points = 0;
			var data = await _sourceDataService.GetPuzzleInputGroupedByThreeLines(PuzzleInputDataPaths.InputFileName(3, 1));
			foreach (TripleInput<string> tripleInput in data)
			{
				var sortedRucksack = _tripleRucksackSorter.Sort(tripleInput);
				var character = sortedRucksack.AsParallel().FirstOrDefault(s => s.Value.Equals(3)).Key;
				points += _prioritiesCalculator.CalculateForChar(character);
			}
			_logger.LogSuccess($"total points - {points}");
		}
	}
}
