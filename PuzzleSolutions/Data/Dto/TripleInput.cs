namespace PuzzleSolutions.Data.Dto
{
	internal sealed class TripleInput<T>
	{
		public T FirstLine { get; init; }
		public T SecondLine { get; init; }
		public T ThirdLine { get; init; }

		public TripleInput(T firstLine, T secondLine, T thirdLine)
		{
			FirstLine = firstLine;
			SecondLine = secondLine;
			ThirdLine = thirdLine;
		}
	}
}
