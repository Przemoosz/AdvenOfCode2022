namespace PuzzleSolutions.Data
{
	internal interface ISourceDataService
	{
		Task<IEnumerable<string>> GetPuzzleInputAsSeparateLines(string fileName);
		Task<string> GetPuzzleInput(string fileName);
	}
}