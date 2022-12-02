using PuzzleSolutions.Enums;
using PuzzleSolutions.Utilities.Logging;

namespace PuzzleSolutions.UserIO
{
    internal sealed class UserInputProvider : IUserInputProvider

    {
	    private readonly ILogger _logger;

	    public UserInputProvider(ILogger logger)
	    {
		    _logger = logger;
	    }
	    public SelectedPuzzle Provide()
	    {
		    Console.WriteLine("Provide day number (1-25): ");
            string selectedDay  = Console.ReadLine().Trim();
            if (!Int32.TryParse(selectedDay, out var dayNumber))
            {
                _logger.LogError("Provided day number that can not be parsed to Int32");
                throw new Exception();
            }
            Console.WriteLine("Provide challenge number (1-2): ");

            string selectedChallenge = Console.ReadLine().Trim();
            if (!Int32.TryParse(selectedChallenge, out var challengeNumber))
            {
	            _logger.LogError("Provided challenge number that can not be parsed to Int32");
	            throw new Exception();
            }

            return new SelectedPuzzle() { Challenge = (Challenge)challengeNumber, Day = (Days)dayNumber };
	    }

    }
}
