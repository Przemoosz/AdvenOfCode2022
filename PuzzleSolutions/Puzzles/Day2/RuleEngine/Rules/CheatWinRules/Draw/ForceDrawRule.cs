namespace PuzzleSolutions.Puzzles.Day2.RuleEngine.Rules.CheatWinRules.Draw
{
    using Enums;
    using Objects;

    internal class ForceDrawRule<T> : IRule<T> where T : IRound
    {
        public void Evaluate(T context)
        {
            context.ElfMove = (ElfMove)(int)context.OpponentMove;
            context.ShouldCalculateResult = false;
        }

		public bool CanEvaluateRule(T context)
        {
            return context.ElfMove == ElfMove.Y;
        }
    }
}
