namespace PuzzleSolutions.Puzzles.Day2.RuleEngine.Rules.GameRules
{
    using Enums;
    using Objects;

    internal class RockWinsRule<T> : IRule<T> where T : IRound
    {
        public void Evaluate(T context)
        {
            if (context.OpponentMove == OpponentMove.C && context.ElfMove == ElfMove.X)
            {
                context.Points += 6;
                context.ShouldCalculateResult = false;
            }
        }

        public bool CanEvaluateRule(T context)
        {
            return context.ShouldCalculateResult;
        }
    }
}