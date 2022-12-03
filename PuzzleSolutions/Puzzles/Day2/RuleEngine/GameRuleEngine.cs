namespace PuzzleSolutions.Puzzles.Day2.RuleEngine
{
	using Objects;
	using Rules;
	using Rules.CheatWinRules.Draw;
	using Rules.CheatWinRules.Loose;
	using Rules.CheatWinRules.Win;
	using Rules.GameRules;

	internal sealed class GameRuleEngine<T>:IGameRuleEngine<T> where T : IRound
	{
		private IEnumerable<IRule<T>> rules;

		public void SetWiningRules()
		{
			rules = new List<IRule<T>>(4)
			{
				new DrawRule<T>(),
				new PaperWinsRule<T>(),
				new RockWinsRule<T>(),
				new ScissorsWinsRule<T>()
			};
		}

		public void SetCheatRules()
		{
			rules = new List<IRule<T>>(4)
			{
				new ForceDrawRule<T>(),
				new ForcePaperLooseRule<T>(),
				new ForceRockLooseRule<T>(),
				new ForceScissorsLooseRule<T>(),
				new ForcePaperWinRule<T>(),
				new ForceRockWinRule<T>(),
				new ForceScissorsWinRule<T>()
			};

		}

		public int CalculateResult(T firstChallengeRoundMove)
		{
			foreach (var rule in rules)
			{
				if (rule.CanEvaluateRule(firstChallengeRoundMove))
				{
					rule.Evaluate(firstChallengeRoundMove);
				}
			}
			return firstChallengeRoundMove.Points;
		}

		public void CheatResult(T firstChallengeRoundMove)
		{
			foreach (var rule in rules)
			{
				if (rule.CanEvaluateRule(firstChallengeRoundMove) && firstChallengeRoundMove.ShouldCalculateResult)
				{
					rule.Evaluate(firstChallengeRoundMove);
				}
			}
		}

	}
}
