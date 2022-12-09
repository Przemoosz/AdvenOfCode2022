namespace PuzzleSolutions
{
	using Microsoft.Extensions.DependencyInjection;
	using Data;
	using Puzzles.Day1;
	using Utilities.Logging;
	using Puzzles;
	using UserIO;
	using Puzzles.Day2;
	using Puzzles.Day2.RuleEngine;
	using Puzzles.Day3;
	using Puzzles.Day3.Priorities;
	internal static class DependencyInstaller
	{
		public static void Install(IServiceCollection serviceCollection)
		{
			InstallSharedServices(serviceCollection);
			InstallDayOne(serviceCollection);
			InstallDayTwo(serviceCollection);
			InstallDayThree(serviceCollection);
		}

		private static void InstallSharedServices(IServiceCollection serviceCollection)
		{
			serviceCollection.AddSingleton<ILogger, Logger>();
			serviceCollection.AddSingleton<IDataConverter, DataConverter>();
			serviceCollection.AddSingleton<ISourceDataService, SourceDataService>();
			serviceCollection.AddSingleton<IUserInputProvider, UserInputProvider>();
			serviceCollection.AddSingleton<IDisplaySolution, DisplaySolution>();
		}

		private static void InstallDayOne(IServiceCollection serviceCollection)
		{
			serviceCollection.AddSingleton<IDayOneFirstChallenge, DayOneFirstChallenge>(); 
			serviceCollection.AddSingleton<ICaloriesDivider, CaloriesDivider>();
			serviceCollection.AddSingleton<IDayOneSecondChallenge, DayOneSecondChallenge>();
		}

		private static void InstallDayTwo(IServiceCollection serviceCollection)
		{
			serviceCollection.AddScoped(typeof(IGameRuleEngine<>), typeof(GameRuleEngine<>));
			serviceCollection.AddScoped(typeof(IMoveConverter<>), typeof(MoveConverter<>));
			serviceCollection.AddSingleton<IDayTwoFirstChallenge, DayTwoFirstChallenge>();
			serviceCollection.AddSingleton<IDayTwoSecondChallenge, DayTwoSecondChallenge>();
		}

		private static void InstallDayThree(IServiceCollection serviceCollection)
		{
			serviceCollection.AddSingleton<IDayThreeFirstChallenge, DayThreeFirstChallenge>();
			serviceCollection.AddSingleton<IPrioritiesCalculator, PrioritiesCalculator>();
			serviceCollection.AddSingleton<IRucksackSorter, RucksackSorter>();
		}
	}
}
