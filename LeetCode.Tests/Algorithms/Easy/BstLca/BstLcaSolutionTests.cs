using System.Collections.Generic;
using LeetCode.Algorithms.Easy.BstLca;
using LeetCode.Common;
using Xunit;

namespace LeetCode.Tests.Algorithms.Easy.BstLca
{
    public class BstLcaSolutionTests
    {
        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { new int? [] { 6,2,8,0,4,7,9,null,null,3,5 }, 2, 8, 6 },
                new object[] { new int? [] { 6,2,8,0,4,7,9,null,null,3,5 }, 2, 4, 2 }
            };

        [Theory]
        [MemberData(nameof(Data))]
        public void LowestCommonAncestor_ReturnsExpected(int? [] treeArray, int pVal, int qVal, int expectedVal)
        {
            // Arrange
            var root = Tree.CreateTree(treeArray);

            // Act
            var result1 = BstLcaSolution.LowestCommonAncestor(root, pVal, qVal);
            var result2 = BstLcaSolution.LowestCommonAncestor2(root, pVal, qVal);
            var result3 = BstLcaSolution.LowestCommonAncestor3(root, pVal, qVal);

            // Assert
            Assert.Equal(expectedVal, result1);
            Assert.Equal(expectedVal, result2);
            Assert.Equal(expectedVal, result3);
        }
    }
}
