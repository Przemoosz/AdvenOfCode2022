using FluentAssertions;
using NUnit.Framework;
using PuzzleSolutions.Puzzles.Day4.Comparison;
using PuzzleSolutions.Puzzles.Day4.Objects;

namespace PuzzleSolutions.UnitTests.Puzzles.Day4.Comparsion
{
	[TestFixture]
	public class SectionCompareTests
	{
		private SectionComparer _uut;

		[SetUp]
		public void SetUp()
		{
			_uut = new SectionComparer();
		}

		[TestCase(8, 12, 8, 10)]
		[TestCase(7, 22, 8, 10)]
		[TestCase(8, 12, 1, 50)]
		[TestCase(8, 12, 8, 12)]
		[TestCase(8, 8, 8, 8)]
		public void ShouldReturnTrueForSectionOverlap(int firstSectionStart, int firstSectionEnd,
			int secondSectionStart, int secondSectionEnd)
		{
			// Arrange
			var firstSection = new Section(firstSectionStart, firstSectionEnd);
			var secondSection = new Section(secondSectionStart, secondSectionEnd);

			// Act
			var actual = _uut.CheckSectionForOverlap(firstSection, secondSection);

			// Assert
			actual.Should().BeTrue();
		}

		[TestCase(8, 12, 45, 56)]
		[TestCase(120, 125, 45, 56)]
		[TestCase(10,10,40,40)]
		public void ShouldReturnFalseForSectionThatDoesNotOverlap(int firstSectionStart, int firstSectionEnd,
			int secondSectionStart, int secondSectionEnd)
		{
			// Arrange
			var firstSection = new Section(firstSectionStart, firstSectionEnd);
			var secondSection = new Section(secondSectionStart, secondSectionEnd);

			// Act
			var actual = _uut.CheckSectionForOverlap(firstSection, secondSection);

			// Assert
			actual.Should().BeFalse();
		}

	}
}
