namespace PuzzleSolutions.Utilities
{
	internal static class PuzzleInputDataPaths
	{
		public static string MyDocumentsDirectory => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
		public static string InputDataDirectory => "AdventOfCode\\InputData";
		public static string InputFileName(int day, int challenge) => $"Day{day}Challenge{challenge}.txt";
	}
}
