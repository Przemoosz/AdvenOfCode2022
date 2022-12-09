namespace PuzzleSolutions.Data.Dto
{
	internal class DoubleInput<T>
	{
		public T FirstLine { get; init; }
		public T SecondLine { get; init; }

		public DoubleInput(T firstLine, T secondLine)
		{
			FirstLine = firstLine;
			SecondLine = secondLine;
		}
	}
}
