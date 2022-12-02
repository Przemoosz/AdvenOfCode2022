namespace PuzzleSolutions.Puzzles.Day1.Objects
{
	internal sealed class Elf: IComparable<Elf>
	{
		public int TotalCalories { get; private set; }

		public void AddCalories(int calories)
		{
			TotalCalories += calories;
		}

		public int CompareTo(Elf? other)
		{
			if (ReferenceEquals(this, other)) return 0;
			if (ReferenceEquals(null, other)) return 1;
			return TotalCalories.CompareTo(other.TotalCalories);
		}
	}
}
