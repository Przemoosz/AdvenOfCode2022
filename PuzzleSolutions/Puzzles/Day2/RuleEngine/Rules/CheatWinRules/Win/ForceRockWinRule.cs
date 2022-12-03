namespace PuzzleSolutions.Puzzles.Day2.RuleEngine.Rules.CheatWinRules.Win
{
    using Enums;
    using Objects;

    internal class ForceRockWinRule<T> : IRule<T> where T : IRound
    {
        public void Evaluate(T context)
        {
	        if (context.OpponentMove == OpponentMove.A)
	        {
		        context.ElfMove = ElfMove.Y;
		        context.ShouldCalculateResult = false;
	        }
        }

	    public bool CanEvaluateRule(T context)
        {
            return context.ElfMove == ElfMove.Z;
        }
    }
}
