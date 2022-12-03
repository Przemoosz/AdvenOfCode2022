namespace PuzzleSolutions.Data.Dto
{
    internal class ConvertedStructDto<T> : IConvertedStructDto<T> where T : struct
    {
        public ConvertedStructDto(T data, bool isConverted)
        {
            Value = data;
            IsConverted = isConverted;
        }
        public T Value { get; init; }
        public bool IsConverted { get; init; }
    }
}
