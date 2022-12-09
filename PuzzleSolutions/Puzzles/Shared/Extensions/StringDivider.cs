namespace PuzzleSolutions.Puzzles.Shared.Extensions
{
	using Exceptions;
	internal static class StringDivider
	{
		private const int ZeroIndex = 0;
		private const int HalfDividerCoefficient = 2;
		public static string GetFirstHalf(this string inputString)
		{
			if (string.IsNullOrEmpty(inputString) || inputString.Length % HalfDividerCoefficient != 0)
			{
				throw new StringDivisionException("Can not divide string in two equal pieces");
			}
			return inputString.Substring(ZeroIndex, inputString.Length / HalfDividerCoefficient);
		}

		public static string GetSecondHalf(this string inputString)
		{
			if (string.IsNullOrEmpty(inputString) || inputString.Length % HalfDividerCoefficient != 0)
			{
				throw new StringDivisionException("Can not divide string in two equal pieces");
			}
			return inputString.Substring(inputString.Length / HalfDividerCoefficient, inputString.Length / HalfDividerCoefficient);
		}

	}
}
