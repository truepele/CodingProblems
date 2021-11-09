using System.Collections.Generic;
using FluentAssertions;
using LeetCode.Algorithms.Medium.Sort;
using Xunit;

namespace LeetCode.Tests.Algorithms.Medium.Sort
{
    public class QuickSortSolution1Tests
    {
        public static IEnumerable<object[]> TestData => new[]
        {
            new[]
            {
                new[] { -19979, -19958, -19979, -19956, -19956, -19979 },
                new[] { -19979, -19979, -19979, -19958, -19956, -19956 },
                },
            new[] {
                new [] { 8926, 10397, 18477, 7011, 19967, 15074, 18321 },
                new [] { 7011, 8926, 10397, 15074, 18321, 18477, 19967 },
            },
            new []
            {
                new [] { 10397,18321,15074 },
                new [] { 10397,15074,18321 },
            },
            new []
            {
                new [] { 18321,10397,15074 },
                new [] { 10397,15074,18321 },
            }
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void Solution1Test(int[] nums, int[] expected)
        {
            // Act
            var result = QuickSortSolution1.SortArray(nums);

            // Assert
            result.Should().Equal(expected);
        }
    }
}
