namespace PuzzleSolutions.Data
{
	using Dto;
	internal sealed class DataConverter: IDataConverter
	{
		public IConvertedDataDto<int> ConvertToInt32(string data)
		{
			if (Int32.TryParse(data, out var convertedValue))
			{
				return new ConvertedDataDto<int>(convertedValue,true);
			}
			return new ConvertedDataDto<int>(convertedValue, false);
		}
	}
}
