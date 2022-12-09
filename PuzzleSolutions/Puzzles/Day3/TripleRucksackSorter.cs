namespace PuzzleSolutions.Puzzles.Day3
{
	using Data.Dto;
	internal class TripleRucksackSorter: ITripleRucksackSorter
	{
		public Dictionary<char, int> Sort(TripleInput<string> tripleInput)
		{
			Dictionary<char, int> letters = new Dictionary<char, int>();
			Dictionary<char, int> lettersinLine = new Dictionary<char, int>();
			foreach (char c in tripleInput.FirstLine.ToCharArray())
			{
				if (!letters.TryAdd(c, 1));
			}
			foreach (char c in tripleInput.SecondLine.ToCharArray())
			{
				if (!letters.TryAdd(c, 1) && letters[c] == 1 && !lettersinLine.TryGetValue(c,out _))
				{
					letters[c] += 1;
				}

				lettersinLine.TryAdd(c, 1);
			}
			lettersinLine.Clear();
			foreach (char c in tripleInput.ThirdLine.ToCharArray())
			{
				if (!letters.TryAdd(c, 1) && letters[c] == 2 && !lettersinLine.TryGetValue(c, out _))
				{
					letters[c] += 1;
				}
			}
			return letters;
		}
	}

	internal interface ITripleRucksackSorter
	{
		Dictionary<char, int> Sort(TripleInput<string> tripleInput);
	}
}
