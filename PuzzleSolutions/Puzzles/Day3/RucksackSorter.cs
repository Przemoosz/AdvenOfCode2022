namespace PuzzleSolutions.Puzzles.Day3
{
	using Shared.Extensions;

	internal class RucksackSorter: IRucksackSorter
	{
		public Dictionary<char, int> Sort(string line)
		{
			Dictionary<char, int> letters = new Dictionary<char, int>();
			string firstHalf = line.GetFirstHalf();
			string secondHalf = line.GetSecondHalf();
			foreach (var c in firstHalf.ToCharArray())
			{
				letters.TryAdd(c, 1);
			}
			foreach (var c in secondHalf.Where(c => letters.TryGetValue(c, out _)))
			{
				letters[c] += 1;
				break;
			}
			return letters;
		}
	}
}
