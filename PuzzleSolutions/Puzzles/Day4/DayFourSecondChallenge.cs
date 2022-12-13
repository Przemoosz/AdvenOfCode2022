namespace PuzzleSolutions.Puzzles.Day4
{
	using Data;
	using Comparison;
	using Factories;
	using Objects;
	using Utilities;
	using Utilities.Logging;
	
	internal class DayFourSecondChallenge: IDayFourSecondChallenge
	{
		private readonly ISourceDataService _sourceDataService;
		private readonly ISectionFactory _sectionFactory;
		private readonly ISectionComparer _sectionComparer;
		private readonly ILogger _logger;

		public DayFourSecondChallenge(ISourceDataService sourceDataService, ISectionFactory sectionFactory, ISectionComparer sectionComparer, ILogger logger)
		{
			_sourceDataService = sourceDataService;
			_sectionFactory = sectionFactory;
			_sectionComparer = sectionComparer;
			_logger = logger;
		}
		public async Task SolvePuzzle()
		{
			int totalOverlaps = 0;
			var lines = await _sourceDataService.GetPuzzleInputAsSeparateLines(PuzzleInputDataPaths.InputFileName(4, 1));
			foreach (string line in lines)
			{
				var spitedLine = line.Split(',');
				Section firstSection = _sectionFactory.Create(spitedLine[0]);
				Section secondSection = _sectionFactory.Create(spitedLine[1]);
				if (_sectionComparer.CheckSectionForOverlap(firstSection, secondSection))
				{
					totalOverlaps++;
				}
				else
				{
					if (_sectionComparer.CheckSectionForOverlap(secondSection, firstSection))
					{
						totalOverlaps++;
					}
				}
			}
			_logger.LogSuccess($"Total overlaps - {totalOverlaps}");
		}
	}
}
