using PuzzleSolutions.Puzzles.Day4.Objects;

namespace PuzzleSolutions.Puzzles.Day4.Factories;

internal interface ISectionFactory
{
    Section Create(string line);
}