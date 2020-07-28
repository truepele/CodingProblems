using LeetCode.Algorithms.Medium.ThreeSum;
using Xunit;

namespace LeetCode.Tests.Algorithms.Medium.ThreeSum
{
    public class ThreeSumSolutionTests
    {
        [Theory]
        [InlineData(new int[] {  })]
        [InlineData(new[] { 1 })]
        [InlineData(new[] { 1, 2 })]
        [InlineData(new[] { -1, 0, 1, 2, -1, -4 }, new[] {-1, -1, 2}, new[] {-1, 0, 1})]
        [InlineData(new[] {-2,0,1,1,2}, new[]{-2,0,2}, new[] {-2,1,1})]
        [InlineData(new[] {-2,0,0,2,2}, new[]{-2,0,2})]
        public void ThreeSum_ReturnsExpected(int[] input, params int[][] expectedResult)
        {
            // Act
            var result = ThreeSumSolution.ThreeSum(input);
            
            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}