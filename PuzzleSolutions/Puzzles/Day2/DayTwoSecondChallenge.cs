using PuzzleSolutions.Data;
using PuzzleSolutions.Puzzles.Day2.Objects;
using PuzzleSolutions.Puzzles.Day2.RuleEngine;
using PuzzleSolutions.Utilities;
using PuzzleSolutions.Utilities.Logging;

namespace PuzzleSolutions.Puzzles.Day2
{
	internal class DayTwoSecondChallenge: IDayTwoSecondChallenge
	{
		private readonly ISourceDataService _sourceDataService;
		private readonly IMoveConverter<SecondChallengeRoundMoves> _moveConverter;
		private readonly IGameRuleEngine<SecondChallengeRoundMoves> _gameRuleEngine;
		private readonly ILogger _logger;

		public DayTwoSecondChallenge(ISourceDataService sourceDataService, IMoveConverter<SecondChallengeRoundMoves> moveConverter, IGameRuleEngine<SecondChallengeRoundMoves> gameRuleEngine, ILogger logger)
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
				var c = (SecondChallengeRoundMoves) moves;
				//var result = _gameRuleEngine.CalculateResult(moves);
				//totalPoints += result;
			}
			_logger.LogSuccess($"Total points {totalPoints}");
		}
	}
}
