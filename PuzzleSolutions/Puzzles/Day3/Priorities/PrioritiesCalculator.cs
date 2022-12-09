namespace PuzzleSolutions.Puzzles.Day3.Priorities
{
	internal sealed class PrioritiesCalculator: IPrioritiesCalculator
	{
		private const int AsciiVector = 96;
		private const int UpperLetterVector = 26;
		public int CalculateForChar(char item)
		{
			int priority = 0;
			if (char.IsUpper(item))
			{
				priority += UpperLetterVector;
			}
			item = char.ToLower(item);
			priority = priority + (int)item - AsciiVector;
			return priority;
		}
	}
}
