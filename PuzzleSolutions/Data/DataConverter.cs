namespace PuzzleSolutions.Data
{
	using Dto;
	internal sealed class DataConverter: IDataConverter
	{
		public IConvertedStructDto<int> ConvertToInt32(string value)
		{
			if (Int32.TryParse(value, out var convertedValue))
			{
				return new ConvertedStructDto<int>(convertedValue,true);
			}
			return new ConvertedStructDto<int>(convertedValue, false);
		}
	}
}
