using PuzzleSolutions.Data.Dto;

namespace PuzzleSolutions.Puzzles.Day3;

internal interface ITripleRucksackSorter
{
	Dictionary<char, int> Sort(TripleInput<string> tripleInput);
}