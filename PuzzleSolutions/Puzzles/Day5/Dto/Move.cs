namespace PuzzleSolutions.Puzzles.Day5.Dto
{
	internal sealed class Move
	{
		public int NumberOfItems { get; init; }
		public int From { get; init; }
		public int To { get; init; }

		public Move(int numberOfItems, int from, int to)
		{
			NumberOfItems = numberOfItems;
			From = from;
			To = to;
		}
	}
}
