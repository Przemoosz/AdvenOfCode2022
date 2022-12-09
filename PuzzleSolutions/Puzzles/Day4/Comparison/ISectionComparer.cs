using PuzzleSolutions.Puzzles.Day4.Objects;

namespace PuzzleSolutions.Puzzles.Day4.Comparison;

internal interface ISectionComparer
{
	bool CheckSectionForOverlap(Section firstSection, Section secondSection);
}