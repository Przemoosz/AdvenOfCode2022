namespace PuzzleSolutions
{
	using Microsoft.Extensions.Hosting;
	using Microsoft.Extensions.DependencyInjection;
	using Puzzles;

	internal sealed class Program
	{
		public static async Task Main(string[] args)
		{
			using (IHost host = Host.CreateDefaultBuilder(args)
				       .ConfigureServices((_, services) => DependencyInstaller.Install(services)).Build())
			{
				using (var serviceScope = host.Services.CreateScope())
				{
					IServiceProvider serviceProvider = serviceScope.ServiceProvider;
					IDisplaySolution displaySolution = serviceProvider.GetService<IDisplaySolution>()!;
					await displaySolution.Display();
				}
			};
		}
	}
}