namespace PuzzleSolutions.Puzzles.Day4.Comparison
{
	using Objects;
	internal sealed class SectionComparer: ISectionComparer
	{
		public bool CheckSectionForFullyOverlap(Section firstSection, Section secondSection)
		{
			if (firstSection.StartingSectionNumber <= secondSection.StartingSectionNumber &&
			    firstSection.EndingSectionNumber >= secondSection.EndingSectionNumber)
			{
				return true;
			}
			return secondSection.StartingSectionNumber <= firstSection.StartingSectionNumber &&
			       secondSection.EndingSectionNumber >= firstSection.EndingSectionNumber;
		}

		public bool CheckSectionForOverlap(Section firstSection, Section secondSection)
		{
			if (firstSection.StartingSectionNumber >= secondSection.StartingSectionNumber &&
			    firstSection.StartingSectionNumber <= secondSection.EndingSectionNumber)
			{
				return true;
			}
			return firstSection.EndingSectionNumber >= secondSection.StartingSectionNumber &&
			       firstSection.EndingSectionNumber <= secondSection.EndingSectionNumber;
		}
	}
}
