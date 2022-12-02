namespace PuzzleSolutions.Data.Dto
{
    internal class ConvertedDataDto<T> : IConvertedDataDto<T> where T : struct
    {
        public ConvertedDataDto(T data, bool isConverted)
        {
            Value = data;
            IsConverted = isConverted;
        }
        public T Value { get; init; }
        public bool IsConverted { get; init; }
    }
}
