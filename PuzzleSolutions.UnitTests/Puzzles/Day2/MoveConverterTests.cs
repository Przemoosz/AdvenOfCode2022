using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using PuzzleSolutions.Puzzles.Day2;
using PuzzleSolutions.Puzzles.Day2.Enums;
using PuzzleSolutions.Puzzles.Day2.Objects;
using PuzzleSolutions.Puzzles.Day2.RuleEngine;
using PuzzleSolutions.Utilities.Logging;

namespace PuzzleSolutions.UnitTests.Puzzles.Day2
{
	[TestFixture]
	internal class MoveConverterTests
	{
		private GameRuleEngine<SecondChallengeRoundMoves> _gameRuleEngine;

		// 	private ILogger _logger = null!;
		// 	private IMoveConverter _uut = null!;
		//
		// 	[SetUp]
		// 	public void SetUp()
		// 	{
		// 		_logger = Substitute.For<ILogger>();
		// 		_uut = new MoveConverter(_logger);
		// 	}
		//
		// 	[TestCase("A Y", OpponentMove.A, ElfMove.Y)]
		// 	[TestCase("B X", OpponentMove.B, ElfMove.X)]
		// 	[TestCase("C Z", OpponentMove.C, ElfMove.Z)]
		// 	public void ShouldDecodeInput(string input, OpponentMove opponentMove, ElfMove elfMove)
		// 	{
		// 		// Act
		// 		var actual = _uut.Convert(input);
		//
		// 		// Assert
		// 		actual.OpponentMove.Should().Be(opponentMove);
		// 		actual.ElfMove.Should().Be(elfMove);
		[SetUp]
		public void SetUp()
		{
			_gameRuleEngine = new GameRuleEngine<SecondChallengeRoundMoves>();
		}

		[TestCaseSource(nameof(GetTestData))]
		public void ShouldConvert(SecondChallengeRoundMoves secondChallengeRoundMoves, ElfMove expected)
		{
			// Act
			_gameRuleEngine.SetCheatRules();
			_gameRuleEngine.CheatResult(secondChallengeRoundMoves);
			// Assert
			secondChallengeRoundMoves.ElfMove.Should().Be(expected);
		}

		private static IEnumerable<TestCaseData> GetTestData()
		{
			yield return new TestCaseData(
				new SecondChallengeRoundMoves() { ElfMove = ElfMove.Y, OpponentMove = OpponentMove.A }, ElfMove.X);
			yield return new TestCaseData(
				new SecondChallengeRoundMoves() { ElfMove = ElfMove.Y, OpponentMove = OpponentMove.B }, ElfMove.Y);
			yield return new TestCaseData(
				new SecondChallengeRoundMoves() { ElfMove = ElfMove.Y, OpponentMove = OpponentMove.C }, ElfMove.Z);

			yield return new TestCaseData(
				new SecondChallengeRoundMoves() { ElfMove = ElfMove.X, OpponentMove = OpponentMove.A }, ElfMove.Z);
			yield return new TestCaseData(
				new SecondChallengeRoundMoves() { ElfMove = ElfMove.X, OpponentMove = OpponentMove.B }, ElfMove.X);
			yield return new TestCaseData(
				new SecondChallengeRoundMoves() { ElfMove = ElfMove.X, OpponentMove = OpponentMove.C }, ElfMove.Y);

			yield return new TestCaseData(
				new SecondChallengeRoundMoves() { ElfMove = ElfMove.Z, OpponentMove = OpponentMove.A }, ElfMove.Y);
			yield return new TestCaseData(
				new SecondChallengeRoundMoves() { ElfMove = ElfMove.Z, OpponentMove = OpponentMove.B }, ElfMove.Z);
			yield return new TestCaseData(
				new SecondChallengeRoundMoves() { ElfMove = ElfMove.Z, OpponentMove = OpponentMove.C }, ElfMove.X);
		}

	}


}
