using System;
namespace LeetCode.Algorithms.Easy.UnivaluedBinaryTree
{
    public class Solution3 : ISolution
    {
        public bool IsUnivalTree(TreeNode root)
        {
            if (root == null) { throw new ArgumentNullException(nameof(root)); }

            return CompareRecursively(root, root.val);
        }

        private bool CompareRecursively(TreeNode node, int val)
        {
            return node == null
                || node.val == val
                && CompareRecursively(node.left, val)
                && CompareRecursively(node.right, val);
        }
    }
}
