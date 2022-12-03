using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using PuzzleSolutions.Puzzles.Day2;
using PuzzleSolutions.Puzzles.Day2.Enums;
using PuzzleSolutions.Utilities.Logging;

namespace PuzzleSolutions.UnitTests.Puzzles.Day2
{
	[TestFixture]
	internal class MoveConverterTests
	{
		private ILogger _logger = null!;
		private IMoveConverter _uut = null!;

		[SetUp]
		public void SetUp()
		{
			_logger = Substitute.For<ILogger>();
			_uut = new MoveConverter(_logger);
		}

		[TestCase("A Y", OpponentMove.A, ElfMove.Y)]
		[TestCase("B X", OpponentMove.B, ElfMove.X)]
		[TestCase("C Z", OpponentMove.C, ElfMove.Z)]
		public void ShouldDecodeInput(string input, OpponentMove opponentMove, ElfMove elfMove)
		{
			// Act
			var actual = _uut.Convert(input);

			// Assert
			actual.OpponentMove.Should().Be(opponentMove);
			actual.ElfMove.Should().Be(elfMove);
		}

	}
}
