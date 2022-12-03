using PuzzleSolutions.Puzzles.Day2.Objects;
using PuzzleSolutions.Puzzles.Day2.RuleEngine.Rules;

namespace PuzzleSolutions.Puzzles.Day2.RuleEngine
{
	internal sealed class GameRuleEngine<T>:IGameRuleEngine<T> where T : IRound
	{
		private readonly IEnumerable<IRule<T>> rules;
		public GameRuleEngine()
		{
			rules = new List<IRule<T>>(4)
			{
				new DrawRule<T>(),
				new PaperWinsRule<T>(),
				new RockWinsRule<T>(),
				new ScissorsWinsRule<T>()
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

	}
}
