using Xunit;

namespace Misc.Tests
{
    public class FindTwoEqualElementsSolutionTests
    {
        [Theory]
        [InlineData(new int []{  }, -1, -1)]
        [InlineData(new []{ 1 }, -1, -1)]
        [InlineData(new []{ 1,2 }, -1, -1)]
        [InlineData(new []{ 3,3 }, 0, 1)]
        [InlineData(new []{ 1,2,3,4 }, -1, -1)]
        [InlineData(new []{ 1,2,3,4,3,5 }, 2, 4)]
        [InlineData(new []{ 0,1,2,0 }, 0, 3)]
        [InlineData(new []{ 5,3,2,3 }, 1, 3)]
        [InlineData(new []{ 5,3,2,3,4,5,6 }, 1, 3)]
        public void FindTwoEqualElements_ReturnsExpected(int[] input, int firstExpectedIndex, int secondExpectedIndex)
        {
            // Act
            var (firstIndex, secondIndex) = FindTwoEqualElementsSolution.FindTwoEqualElements(input);
            
            // Assert
            Assert.Equal(firstExpectedIndex, firstIndex);
            Assert.Equal(secondExpectedIndex, secondIndex);
        }
    }
}