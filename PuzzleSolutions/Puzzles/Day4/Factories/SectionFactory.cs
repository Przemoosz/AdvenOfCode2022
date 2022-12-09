namespace PuzzleSolutions.Puzzles.Day4.Factories
{
    using Objects;

    internal sealed class SectionFactory : ISectionFactory
    {
        public Section Create(string line)
        {
            var sectionNumbers = line.Split('-');
            return new Section(int.Parse(sectionNumbers[0]), int.Parse(sectionNumbers[1]));
        }
    }
}
