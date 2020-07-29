using LeetCode.Algorithms.Easy.PalindromeNumber;
using Xunit;

namespace LeetCode.Tests.Algorithms.Easy.PalindromeNumber
{
    public class PalindromeNumberSolutionTests
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(12321, true)]
        [InlineData(1221, true)]
        [InlineData(0, true)]
        [InlineData(123, false)]
        [InlineData(-121, false)]
        [InlineData(-123, false)]
        [InlineData(10, false)]
        public void IsPalindrome_ReturnsExpected(int input, bool expectedResult)
        {
            // Act
            var result = PalindromeNumberSolution.IsPalindrome(input);
            
            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}