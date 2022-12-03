﻿using PuzzleSolutions.Puzzles.Day2.Objects;

namespace PuzzleSolutions.Puzzles.Day2.RuleEngine;

internal interface IGameRuleEngine<in T> where T: IRound
{
	int CalculateResult(T firstChallengeRoundMoves);
}