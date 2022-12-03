namespace PuzzleSolutions.Puzzles.Day2.Objects
{
	using Enums;

	internal sealed class FirstChallengeRoundMoves: IRound
	{
		public FirstChallengeRoundMoves()
		{
		}

		private int _points = 0;
		private ElfMove _elfMove;
		public bool ShouldCalculateResult { get; set; } = true;
		public int Points { 
			get => _points;
			set => _points = value;
		}
		public OpponentMove OpponentMove { get; init; }
		public ElfMove ElfMove
		{
			get => _elfMove;
			set
			{
				_points = (int)value;
				_elfMove = value;
			}
		}
	}
}
