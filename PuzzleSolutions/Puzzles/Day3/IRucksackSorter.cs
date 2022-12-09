namespace PuzzleSolutions.Puzzles.Day3;

internal interface IRucksackSorter
{
	Dictionary<char, int> Sort(string line);
}