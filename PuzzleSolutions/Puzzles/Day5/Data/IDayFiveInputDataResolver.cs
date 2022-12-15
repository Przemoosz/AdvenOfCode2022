using PuzzleSolutions.Puzzles.Day5.Dto;

namespace PuzzleSolutions.Puzzles.Day5.Data;

internal interface IDayFiveInputDataResolver
{
	Task<List<ContainerStack>> ResolveInput();
}