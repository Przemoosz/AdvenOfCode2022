namespace PuzzleSolutions.Data.Dto;

internal interface IConvertedDataDto<out T> where T : struct
{
    public T Value { get; }
    public bool IsConverted { get; }
}