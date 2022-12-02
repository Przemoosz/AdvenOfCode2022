namespace PuzzleSolutions.Exceptions
{
	internal class FileNameException: Exception
	{
		public FileNameException(): base()
		{
		}

		public FileNameException(string message): base(message)
		{
		}

		public FileNameException(string message, Exception innerException): base(message, innerException)
		{
		}
	}
}
