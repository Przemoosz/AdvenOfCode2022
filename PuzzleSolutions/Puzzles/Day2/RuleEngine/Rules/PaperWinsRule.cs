namespace PuzzleSolutions.Puzzles.Day2.RuleEngine.Rules
{
	using Enums;
	using Objects;

	internal class PaperWinsRule<T>: IRule<T> where T: IRound
	{
		public void Evaluate(T context)
		{
			if (context.OpponentMove == OpponentMove.A && context.ElfMove == ElfMove.Y)
			{
				context.Points += 6;
				context.ShouldCalculateResult = true;
			}
		}

		public bool CanEvaluateRule(T context)
		{
			return context.ShouldCalculateResult;
		}
	}
}
