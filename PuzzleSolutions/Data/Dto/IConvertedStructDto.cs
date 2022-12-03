namespace PuzzleSolutions.Data.Dto;

internal interface IConvertedStructDto<out T> where T : struct
{
    public T Value { get; }
    public bool IsConverted { get; }
}