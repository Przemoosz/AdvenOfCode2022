namespace PuzzleSolutions.Puzzles.Day4.Comparison
{
	using Objects;
	internal sealed class SectionComparer: ISectionComparer
	{
		public bool CheckSectionForOverlap(Section firstSection, Section secondSection)
		{
			if (firstSection.StartingSectionNumber <= secondSection.StartingSectionNumber && firstSection.EndingSectionNumber >= secondSection.EndingSectionNumber)
			{
				return true;
			}
			if (secondSection.StartingSectionNumber <= firstSection.StartingSectionNumber && secondSection.EndingSectionNumber >= firstSection.EndingSectionNumber)
			{
				return true;
			}
			return false;
		}
	}
}
