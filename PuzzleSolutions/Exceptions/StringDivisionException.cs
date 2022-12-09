namespace PuzzleSolutions.Exceptions
{
	internal class StringDivisionException: Exception
	{
		public StringDivisionException(): base()
		{
		}

		public StringDivisionException(string message): base(message)
		{
		}

		public StringDivisionException(string message, Exception innerException): base(message, innerException)
		{
		}
	}
}
