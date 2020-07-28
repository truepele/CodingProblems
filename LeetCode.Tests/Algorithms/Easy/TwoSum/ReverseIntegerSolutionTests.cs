using LeetCode.Algorithms.Easy.ReverseInteger;
using Xunit;

namespace LeetCode.Tests.Algorithms.Easy.TwoSum
{
    public class ReverseIntegerSolutionTests
    {
        [Theory]
        [InlineData(123, 321)]
        [InlineData(321, 123)]
        [InlineData(2, 2)]
        [InlineData(99, 99)]
        [InlineData(int.MaxValue, 0)]
        [InlineData(-123, -321)]
        [InlineData(int.MaxValue * -1, 0)]
        [InlineData(1534236469, 0)]
        public void Reverse_ReturnsExpected(int input, int expectedResult)
        {
            // Act
            var result = ReverseIntegerSolution.Reverse(input);
            
            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}