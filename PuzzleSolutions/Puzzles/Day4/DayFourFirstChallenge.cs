using PuzzleSolutions.Data;
using PuzzleSolutions.Puzzles.Day4.Comparison;
using PuzzleSolutions.Puzzles.Day4.Factories;
using PuzzleSolutions.Puzzles.Day4.Objects;
using PuzzleSolutions.Utilities;
using PuzzleSolutions.Utilities.Logging;

namespace PuzzleSolutions.Puzzles.Day4
{
    internal class DayFourFirstChallenge: IDayFourFirstChallenge
	{
		private readonly ISourceDataService _sourceDataService;
		private readonly ISectionFactory _sectionFactory;
		private readonly ISectionComparer _sectionComparer;
		private readonly ILogger _logger;

		public DayFourFirstChallenge(ISourceDataService sourceDataService, ISectionFactory sectionFactory, ISectionComparer sectionComparer, ILogger logger)
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
			}
			_logger.LogSuccess($"Total overlaps - {totalOverlaps}");
		}
	}
}
