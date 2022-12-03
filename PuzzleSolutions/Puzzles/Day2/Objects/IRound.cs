using PuzzleSolutions.Puzzles.Day2.Enums;

namespace PuzzleSolutions.Puzzles.Day2.Objects;

internal interface IRound
{
	public OpponentMove OpponentMove { get; init; }
	public ElfMove ElfMove { get; set; }
	public int Points { get; set; }
	public bool ShouldCalculateResult { get; set; }
}