namespace PuzzleSolutions.UnitTests.Puzzles.Day3.Priorities
{
	using FluentAssertions;
	using NUnit.Framework;
	using PuzzleSolutions.Puzzles.Day3.Priorities;

	[TestFixture, Parallelizable]
	public class PrioritiesCalculatorTests
	{
		private PrioritiesCalculator _uut;

		[SetUp]
		public void SetUp()
		{
			_uut = new PrioritiesCalculator();
		}

		[TestCase('a', 1)]
		[TestCase('z', 26)]
		[TestCase('A', 27)]
		[TestCase('Z', 52)]
		public void ShouldCalculatePriority(char item, int expected)
		{
			// Act
			var actual = _uut.CalculateForChar(item);

			// Assert
			actual.Should().Be(expected);
		}
	}
}
