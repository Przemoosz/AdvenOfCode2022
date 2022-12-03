using PuzzleSolutions.Puzzles.Day2.Objects;

namespace PuzzleSolutions.Puzzles.Day2.RuleEngine.Rules;

internal interface IRule<in T> where T: IRound
{
	void Evaluate(T context);
	bool CanEvaluateRule(T context);
}