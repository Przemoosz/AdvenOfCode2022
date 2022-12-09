namespace PuzzleSolutions.Puzzles.Day3
{
	using Data;
	using Priorities;
	using Utilities;
	using Utilities.Logging;

	internal sealed class DayThreeFirstChallenge: IDayThreeFirstChallenge
	{
		private readonly IPrioritiesCalculator _prioritiesCalculator;
		private readonly IRucksackSorter _rucksackSorter;
		private readonly ISourceDataService _sourceDataService;
		private readonly ILogger _logger;

		public DayThreeFirstChallenge(IPrioritiesCalculator prioritiesCalculator, IRucksackSorter rucksackSorter,
			ISourceDataService sourceDataService, ILogger logger)
		{
			_prioritiesCalculator = prioritiesCalculator;
			_rucksackSorter = rucksackSorter;
			_sourceDataService = sourceDataService;
			_logger = logger;
		}

		public async Task SolvePuzzle()
		{
			int points = 0;
			var data = await _sourceDataService.GetPuzzleInputAsSeparateLines(PuzzleInputDataPaths.InputFileName(3, 1));
			foreach (var line in data)
			{
				var sortedRucksack = _rucksackSorter.Sort(line);
				var character = sortedRucksack.AsParallel().FirstOrDefault(s => s.Value.Equals(2)).Key;
				points += _prioritiesCalculator.CalculateForChar(character);
			}
			_logger.LogSuccess($"Total points - {points}");
		}
	}
}
