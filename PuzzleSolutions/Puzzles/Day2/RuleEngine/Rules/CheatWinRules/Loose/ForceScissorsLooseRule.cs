namespace PuzzleSolutions.Puzzles.Day2.RuleEngine.Rules.CheatWinRules.Loose
{
    using Enums;
    using Objects;

    internal class ForceScissorsLooseRule<T> : IRule<T> where T : IRound
    {
        public void Evaluate(T context)
        {
            if (context.OpponentMove == OpponentMove.C)
            {
                context.ElfMove = ElfMove.Y;
                context.ShouldCalculateResult = false;
            }
		}

        public bool CanEvaluateRule(T context)
        {
            return context.ElfMove == ElfMove.X;
        }
    }
}
