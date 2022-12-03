namespace PuzzleSolutions.Puzzles
{
	using Enums;
	using Day1;
	using UserIO;
	using Utilities.Logging;
	using Day2;
	internal class DisplaySolution: IDisplaySolution
	{
		private readonly IUserInputProvider _userInputProvider;
		private readonly IDayOneFirstChallenge _dayOneFirstChallenge;
		private readonly IDayOneSecondChallenge _dayOneSecondChallenge;
		private readonly IDayTwoFirstChallenge _dayTwoFirstChallenge;
		private readonly IDayTwoSecondChallenge _dayTwoSecondChallenge;
		private readonly ILogger _logger;

		public DisplaySolution(IUserInputProvider userInputProvider, IDayOneFirstChallenge dayOneFirstChallenge,
			IDayOneSecondChallenge dayOneSecondChallenge, IDayTwoFirstChallenge dayTwoFirstChallenge, IDayTwoSecondChallenge dayTwoSecondChallenge, ILogger logger)
		{
			_userInputProvider = userInputProvider;
			_dayOneFirstChallenge = dayOneFirstChallenge;
			_dayOneSecondChallenge = dayOneSecondChallenge;
			_dayTwoFirstChallenge = dayTwoFirstChallenge;
			_dayTwoSecondChallenge = dayTwoSecondChallenge;
			_logger = logger;
		}

		public async Task Display()
		{
			SelectedPuzzle selectedPuzzleSolution = _userInputProvider.Provide();
			switch (selectedPuzzleSolution.Day)
			{
				case Days.DayOne when selectedPuzzleSolution.Challenge == Challenge.First:
				{
					await _dayOneFirstChallenge.SolvePuzzle();
					break;
				}
				case Days.DayOne when
					selectedPuzzleSolution.Challenge == Challenge.Second:
				{
					await _dayOneSecondChallenge.SolvePuzzle();
					break;
				}
				case Days.DayTwo when
					selectedPuzzleSolution.Challenge == Challenge.First:
				{
					await _dayTwoFirstChallenge.SolvePuzzle();
					break;
				}
				case Days.DayTwo when
					selectedPuzzleSolution.Challenge == Challenge.Second:
				{
					await _dayTwoSecondChallenge.SolvePuzzle();
					break;
				}
				default:
				{
					_logger.LogWarning("No solution for this day and this challenge");
					break;
				}
			}
		}
	}
}
