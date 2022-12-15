namespace PuzzleSolutions.Puzzles.Day5
{
	using Data;
	
	internal class DayFiveFirstChallenge: IDayFiveFirstChallenge
	{
		private readonly IDayFiveInputDataResolver _dayFiveInputDataResolver;

		public DayFiveFirstChallenge(IDayFiveInputDataResolver dayFiveInputDataResolver)
		{
			_dayFiveInputDataResolver = dayFiveInputDataResolver;
		}

		public async Task SolvePuzzle()
		{
			await _dayFiveInputDataResolver.ResolveInput();
		}
	}
}
