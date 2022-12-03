namespace PuzzleSolutions.Puzzles.Day2
{
	using Data;
	using Objects;
	using RuleEngine;
	using Utilities;
	using Utilities.Logging;
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
			List<SecondChallengeRoundMoves> movesList = new List<SecondChallengeRoundMoves>();
			var gameRounds = await _sourceDataService.GetPuzzleInputAsSeparateLines(PuzzleInputDataPaths.InputFileName(2, 1));
			_gameRuleEngine.SetCheatRules();
			foreach (var round in gameRounds)
			{
				var moves = _moveConverter.Convert(round);
				//var c = moves;
				_gameRuleEngine.CheatResult(moves);
				moves.ShouldCalculateResult = true;
				movesList.Add(moves);
			}

			_gameRuleEngine.SetWiningRules();
			foreach (var move in movesList)
			{
				var result = _gameRuleEngine.CalculateResult(move);
				totalPoints += result;
			}
			_logger.LogSuccess($"Total points {totalPoints}");
		}
	}
}
