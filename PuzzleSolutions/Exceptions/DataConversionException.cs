namespace PuzzleSolutions.Exceptions
{
	internal class DataConversionException<TConversion>: Exception
	{
		public DataConversionException()
		{
		}

		public DataConversionException(string message): base($"Can not convert to {typeof(TConversion)} Additional Message: {message}")
		{
		}

		public DataConversionException(string message, Exception innerException) : base($"Can not convert to{typeof(TConversion)} Additional Message: {message}", innerException)
		{
		}
	}
}
