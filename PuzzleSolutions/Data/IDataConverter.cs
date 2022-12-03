namespace PuzzleSolutions.Data
{
	using Dto;
	internal interface IDataConverter
	{
		public IConvertedStructDto<int> ConvertToInt32(string value);
	}
}