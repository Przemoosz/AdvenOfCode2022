namespace PuzzleSolutions.Data
{
	using Dto;
	internal interface IDataConverter
	{
		public IConvertedDataDto<int> ConvertToInt32(string data);
	}
}