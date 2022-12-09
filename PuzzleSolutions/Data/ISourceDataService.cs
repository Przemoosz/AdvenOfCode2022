namespace PuzzleSolutions.Data
{
	using Dto;

	internal interface ISourceDataService
	{
		Task<IEnumerable<string>> GetPuzzleInputAsSeparateLines(string fileName);
		Task<string> GetPuzzleInput(string fileName);
		Task<IEnumerable<TripleInput<string>>> GetPuzzleInputGroupedByThreeLines(string fileName);
		Task<IEnumerable<DoubleInput<string>>> GetPuzzleInputGroupedByTwoLines(string fileName);
	}
}