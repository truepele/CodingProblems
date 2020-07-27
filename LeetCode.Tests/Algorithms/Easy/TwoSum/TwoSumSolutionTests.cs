using LeetCode.Algorithms.Easy.TwoSum;
using Xunit;

namespace LeetCode.Tests.Algorithms.Easy.TwoSum
{
    public class TwoSumSolutionTests
    {
        [Theory]
        [InlineData(new int []{  }, 123, -1, -1)]
        [InlineData(new []{ 1 }, 222, -1, -1)]
        [InlineData(new []{ 1,2 }, 333, -1, -1)]
        [InlineData(new []{ 3,3 }, 6, 0, 1)]
        [InlineData(new []{ 1,2,3,4 }, 444, -1, -1)]
        [InlineData(new []{ 1,2,3,8,4,6 }, 7, 2, 4)]
        [InlineData(new []{ 0,1,5,3 }, 3, 0, 3)]
        [InlineData(new []{ 5,3,2,8 }, 11, 1, 3)]
        [InlineData(new []{ 1,3,5,7,8 }, 10, 1, 3)]
        [InlineData(new []{ 1,15,5,-5,8 }, 10, 1, 3)]
        public void TwoSum_ReturnsExpected(int[] input, int target, int firstExpectedIndex, int secondExpectedIndex)
        {
            // Act
            var (firstIndex, secondIndex) = TwoSumSolution.TwoSum(input, target);
            
            // Assert
            Assert.Equal(firstExpectedIndex, firstIndex);
            Assert.Equal(secondExpectedIndex, secondIndex);
        }
    }
}