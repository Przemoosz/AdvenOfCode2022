namespace PuzzleSolutions.Puzzles.Day5.Dto
{
	internal sealed class DayFiveWrappedInput
	{ 
		public Dictionary<int, ContainerStack> Stacks { get; init; }
		public IEnumerable<Move> Moves { get; init; }

		public DayFiveWrappedInput(Dictionary<int, ContainerStack> stacks, IEnumerable<Move> moves)
		{
			Stacks = stacks;
			Moves = moves;
		}
	}
}
