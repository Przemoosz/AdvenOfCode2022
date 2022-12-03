namespace PuzzleSolutions.Puzzles.Day2.RuleEngine.Rules.CheatWinRules.Loose
{
    using Enums;
    using Objects;

    internal class ForceRockLooseRule<T> : IRule<T> where T : IRound
    {
        public void Evaluate(T context)
        {
            if (context.OpponentMove == OpponentMove.A)
            {
                context.ElfMove = ElfMove.Z;
                context.ShouldCalculateResult = false;
            }
		}

        public bool CanEvaluateRule(T context)
        {
            return context.ElfMove == ElfMove.X;
        }
    }
}
