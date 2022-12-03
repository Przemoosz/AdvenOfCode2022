using PuzzleSolutions.Data;
using PuzzleSolutions.Puzzles.Day2.Objects;
using PuzzleSolutions.Puzzles.Day2.RuleEngine;
using PuzzleSolutions.Utilities;
using PuzzleSolutions.Utilities.Logging;

namespace PuzzleSolutions.Puzzles.Day2
{
	internal class DayTwoFirstChallenge : IDayTwoFirstChallenge
	{
		private readonly ISourceDataService _sourceDataService;
		private readonly IMoveConverter<FirstChallengeRoundMoves> _moveConverter;
		private readonly IGameRuleEngine<FirstChallengeRoundMoves> _gameRuleEngine;
		private readonly ILogger _logger;

		public DayTwoFirstChallenge(ISourceDataService sourceDataService, IMoveConverter<FirstChallengeRoundMoves> moveConverter, IGameRuleEngine<FirstChallengeRoundMoves> gameRuleEngine, ILogger logger)
		{
			_sourceDataService = sourceDataService;
			_moveConverter = moveConverter;
			_gameRuleEngine = gameRuleEngine;
			_logger = logger;
		}
		public async Task SolvePuzzle()
		{
			int totalPoints = 0;
			var gameRounds = await _sourceDataService.GetPuzzleInputAsSeparateLines(PuzzleInputDataPaths.InputFileName(2, 1));
			foreach (var round in gameRounds)
			{
				var moves = _moveConverter.Convert(round);
				var result = _gameRuleEngine.CalculateResult(moves);
				totalPoints += result;
			}
			_logger.LogSuccess($"Total points {totalPoints}");
		}
	}
}
