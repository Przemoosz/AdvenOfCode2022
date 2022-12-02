namespace PuzzleSolutions
{
	using Microsoft.Extensions.DependencyInjection;
	using Data;
	using Puzzles.Day1;
	using Utilities.Logging;

	internal static class DependencyInstaller
	{
		public static void Install(IServiceCollection serviceCollection)
		{
			InstallSharedServices(serviceCollection);
			InstallDayOne(serviceCollection);
		}

		private static void InstallSharedServices(IServiceCollection serviceCollection)
		{
			serviceCollection.AddSingleton<ILogger, Logger>();
			serviceCollection.AddSingleton<IDataConverter, DataConverter>();
			serviceCollection.AddSingleton<ISourceDataService, SourceDataService>();
		}

		private static void InstallDayOne(IServiceCollection serviceCollection)
		{
			serviceCollection.AddSingleton<IDayOneFirstChallenge, DayOneFirstChallenge>(); 
			serviceCollection.AddSingleton<ICaloriesDivider, CaloriesDivider>();
			serviceCollection.AddSingleton<IDayOneSecondChallenge, DayOneSecondChallenge>();
		}
	}
}
