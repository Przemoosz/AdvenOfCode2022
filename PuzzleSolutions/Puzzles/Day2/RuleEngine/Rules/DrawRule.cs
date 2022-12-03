namespace PuzzleSolutions.Puzzles.Day2.RuleEngine.Rules
{
	using Objects;

	internal class DrawRule<T> : IRule<T> where T : IRound
	{
		public void Evaluate(T context)
		{
			if ((int)context.OpponentMove == (int)context.ElfMove)
			{
				context.Points += 3;
				context.ShouldCalculateResult = true;
			}
		}

		public bool CanEvaluateRule(T context)
		{
			return context.ShouldCalculateResult;
		}
	}
}