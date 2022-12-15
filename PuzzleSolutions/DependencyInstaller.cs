namespace PuzzleSolutions
{
	using Microsoft.Extensions.DependencyInjection;
	using Data;
	using Puzzles.Day1;
	using Utilities.Logging;
	using Puzzles;
	using UserIO;
	using Puzzles.Day4;
	using Puzzles.Day4.Comparison;
	using Puzzles.Day4.Factories;
	using Puzzles.Day2;
	using Puzzles.Day2.RuleEngine;
	using Puzzles.Day3;
	using Puzzles.Day3.Priorities;
	using Puzzles.Day5;
	using PuzzleSolutions.Puzzles.Day5.Data;
	internal static class DependencyInstaller
	{
		public static void Install(IServiceCollection serviceCollection)
		{
			InstallSharedServices(serviceCollection);
			InstallDayOne(serviceCollection);
			InstallDayTwo(serviceCollection);
			InstallDayThree(serviceCollection);
			InstallDayFour(serviceCollection);
			InstallDayFive(serviceCollection);
		}

		private static void InstallSharedServices(IServiceCollection serviceCollection)
		{
			serviceCollection.AddSingleton<ILogger, Logger>();
			serviceCollection.AddSingleton<IDataConverter, DataConverter>();
			serviceCollection.AddSingleton<ISourceDataService, SourceDataService>();
			serviceCollection.AddSingleton<IUserInputProvider, UserInputProvider>();
			serviceCollection.AddSingleton<IDisplaySolution, DisplaySolution>();
			serviceCollection.AddSingleton<IStreamReaderProvider, StreamReaderProvider>();
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
			serviceCollection.AddSingleton<IDayThreeSecondChallenge, DayThreeSecondChallenge>();
			serviceCollection.AddSingleton<IPrioritiesCalculator, PrioritiesCalculator>();
			serviceCollection.AddSingleton<IRucksackSorter, RucksackSorter>();
			serviceCollection.AddSingleton<ITripleRucksackSorter, TripleRucksackSorter>();
		}

		private static void InstallDayFour(IServiceCollection serviceCollection)
		{
			serviceCollection.AddSingleton<IDayFourFirstChallenge, DayFourFirstChallenge>();
			serviceCollection.AddSingleton<IDayFourSecondChallenge, DayFourSecondChallenge>();
			serviceCollection.AddSingleton<ISectionComparer, SectionComparer>();
			serviceCollection.AddSingleton<ISectionFactory, SectionFactory>();
		}

		private static void InstallDayFive(IServiceCollection serviceCollection)
		{
			serviceCollection.AddSingleton<IDayFiveFirstChallenge, DayFiveFirstChallenge>();
			serviceCollection.AddSingleton<IDayFiveInputDataResolver, DayFiveInputDataResolver>();
		}
	}
}
