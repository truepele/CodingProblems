using System.Collections.Generic;
using FluentAssertions;
using LeetCode.Algorithms.Easy.SquaresOfSortedArray;
using Xunit;

namespace LeetCode.Tests.Algorithms.Easy.SquaresOfSortedArray
{
    public class Tests
    {
        public static IEnumerable<object[]> TestData => new[]
        {
            new[] { new[] { -4, -1, 0, 3, 10 }, new[] { 0, 1, 9, 16, 100 } },
            new[] { new[] { -7, -3, 2, 3, 11 }, new[] { 4, 9, 9, 49, 121 } },
            new[] { new[] { -10000, -9999, -7, -5, 0, 0, 10000 }, new[] { 0, 0, 25, 49, 99980001, 100000000, 100000000 } }
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void Solution1Test(int[] nums, int[] expected)
        {
            // Act
            var result = Solution1.SortedSquares(nums);

            // Assert
            result.Should().Equal(expected);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void Solution2Test(int[] nums, int[] expected)
        {
            // Act
            var result = Solution2.SortedSquares(nums);

            // Assert
            result.Should().Equal(expected);
        }
    }
}
