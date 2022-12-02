namespace PuzzleSolutions.Puzzles.Day1
{
    using Data;
    using Objects;
    using Utilities;

    internal class CaloriesDivider : ICaloriesDivider
    {
        private readonly ISourceDataService _sourceDataService;
        private readonly IDataConverter _dataConverter;

        public CaloriesDivider(ISourceDataService sourceDataService, IDataConverter dataConverter)
        {
            _sourceDataService = sourceDataService;
            _dataConverter = dataConverter;
        }

        public async Task<List<Elf>> DivideCalories()
        {
            IEnumerable<string> caloriesData = await _sourceDataService.GetPuzzleInputAsSeparateLines(PuzzleInputDataPaths.InputFileName(1,1));
            List<Elf> elves = new List<Elf>();
            Elf elf = new Elf();
            foreach (var calories in caloriesData)
            {
                if (string.IsNullOrEmpty(calories))
                {
                    elves.Add(elf);
                    elf = new Elf();
                    continue;
                }
                var convertedCalories = _dataConverter.ConvertToInt32(calories);
                if (convertedCalories.IsConverted)
                {
                    elf.AddCalories(convertedCalories.Value);
                }
            }
            return elves;
        }
    }
}
