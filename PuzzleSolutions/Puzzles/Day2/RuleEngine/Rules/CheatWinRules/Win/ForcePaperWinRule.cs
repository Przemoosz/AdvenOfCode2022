namespace PuzzleSolutions.Puzzles.Day2.RuleEngine.Rules.CheatWinRules.Win
{
    using Enums;
    using Objects;

    internal class ForcePaperWinRule<T> : IRule<T> where T : IRound
    {
        public void Evaluate(T context)
        {
            if (context.OpponentMove == OpponentMove.B)
            {
                context.ElfMove = ElfMove.Z;
                context.ShouldCalculateResult = false;
            }
		}

        public bool CanEvaluateRule(T context)
        {
            return context.ElfMove == ElfMove.Z;
        }
    }
}
