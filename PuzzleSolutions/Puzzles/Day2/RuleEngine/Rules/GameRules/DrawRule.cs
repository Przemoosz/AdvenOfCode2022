namespace PuzzleSolutions.Puzzles.Day2.RuleEngine.Rules.GameRules
{
    using Objects;

    internal class DrawRule<T> : IRule<T> where T : IRound
    {
        public void Evaluate(T context)
        {
            if ((int)context.OpponentMove == (int)context.ElfMove)
            {
                context.Points += 3;
                context.ShouldCalculateResult = false;
            }
        }

        public bool CanEvaluateRule(T context)
        {
            return context.ShouldCalculateResult;
        }
    }
}