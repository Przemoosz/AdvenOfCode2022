namespace PuzzleSolutions
{
	using Microsoft.Extensions.Hosting;
	using Microsoft.Extensions.DependencyInjection;
	using Puzzles.Day1;
	internal sealed class Program
	{
		public static async Task Main(string[] args)
		{
			using (IHost host = Host.CreateDefaultBuilder(args)
				       .ConfigureServices((_, services) => DependencyInstaller.Install(services)).Build())
			{
				using (var serviceScope = host.Services.CreateScope())
				{
					var serviceProvider = serviceScope.ServiceProvider;
					IDayOneFirstChallenge sourceDataService = serviceProvider.GetService<IDayOneFirstChallenge>()!;
					await sourceDataService.SolvePuzzle();
				}
			};
		}
	}
}