using PuzzleSolutions.Puzzles.Day4.Objects;

namespace PuzzleSolutions.Puzzles.Day4.Comparison;

internal interface ISectionComparer
{
	bool CheckSectionForFullyOverlap(Section firstSection, Section secondSection);
	bool CheckSectionForOverlap(Section firstSection, Section secondSection);
}