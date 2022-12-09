namespace PuzzleSolutions.Puzzles.Day4.Objects
{
	internal sealed class Section
	{
		public int StartingSectionNumber { get; init; }
		public int EndingSectionNumber { get; init; }
		public int SectionLength => EndingSectionNumber - StartingSectionNumber;

		public Section(int startingSectionNumber, int endingSectionNumber)
		{
			StartingSectionNumber = startingSectionNumber;
			EndingSectionNumber = endingSectionNumber;
		}
	}
}
