using PuzzleSolutions.Puzzles.Day2.Objects;

namespace PuzzleSolutions.Puzzles.Day2;

internal interface IMoveConverter<out TResult> where TResult: IRound, new()
{
	TResult Convert(string line);
}