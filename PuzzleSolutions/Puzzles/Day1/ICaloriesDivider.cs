using PuzzleSolutions.Puzzles.Day1.Objects;

namespace PuzzleSolutions.Puzzles.Day1;

internal interface ICaloriesDivider
{
    Task<List<Elf>> DivideCalories();
}