﻿using PuzzleSolutions.Puzzles.Day2.Enums;

namespace PuzzleSolutions.Puzzles.Day2.Objects;

internal sealed class SecondChallengeRoundMoves : IRound
{
	private int _points = 0;
	private ElfMove _elfMove;

	public SecondChallengeRoundMoves()
	{
	}

	public bool ShouldCalculateResult { get; set; } = true;
	public int Points
	{
		get => _points;
		set => _points += value;
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

	public ElfMove ElfGameMove { get; set; }
}