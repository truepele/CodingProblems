using System.Collections.Generic;
using LeetCode.Algorithms.Easy;
using LeetCode.Algorithms.Easy.UnivaluedBinaryTree;
using Xunit;

namespace LeetCode.Tests.Algorithms.Easy.UnivaluedBinaryTree
{
    public abstract class UnivaluedBinaryTreeTestsBase
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void IsUnivalTree_Returns_Expected(int?[] tree, bool expectedResult)
        {
            // Act
            var result = GetImplementation().IsUnivalTree(CreateTree(tree, 0));

            // Assert
            Assert.Equal(expectedResult, result);

        }

        protected abstract ISolution GetImplementation();


        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new int? [] { 3, 3, 3, 3, 3 }, true },
            new object[] { new int? [] { 1, 1, 1, null, 1 }, true },
            new object[] { new int? [] { 1, null, null }, true },
            new object[] { new int? [] { 1, 1, null, null, 1, null, 1 }, true },
            new object[] { new int? [] { 0 }, true },
            new object[] { new int? [] { 1, 2, 1, null, 1 }, false },
            new object[] { new int? [] { 2, 1, 1, null, 1, 1, 1 }, false },
            new object[] { new int? [] { 2, 2, 2, 2, 2, 2, 1 }, false },
            new object[] { new int? [] { 2, 2, 2, 2, 2, 1, 2 }, false },
            /*new [] { -4, -6, -10 },
            new [] { -2, 2, 0 },
            new [] { int.MinValue, -1, int.MaxValue },*/
        };


        private TreeNode CreateTree(int?[] nodeValues, int start)
        {
            var i = start;

            if (i >= nodeValues.Length || nodeValues[i] == null)
            {
                return null;
            }

            var result = new TreeNode(nodeValues[start].Value);

            if (i++ >= nodeValues.Length)
            {
                return result;
            }

            result.left = CreateTree(nodeValues, i);

            if (i++ >= nodeValues.Length)
            {
                return result;
            }

            result.right = CreateTree(nodeValues, i);

            return result;
        }

    }
}
