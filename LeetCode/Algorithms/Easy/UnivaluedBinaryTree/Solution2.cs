using System;
using LeetCode.Common;

namespace LeetCode.Algorithms.Easy.UnivaluedBinaryTree
{
    public class Solution2 : ISolution
    {
        public bool IsUnivalTree(TreeNode root)
        {
            if (root == null) { throw new ArgumentNullException(nameof(root)); }

            if (!Compare(root.left, root.val))
            {
                return false;
            }

            if (!Compare(root.right, root.val))
            {
                return false;
            }

            return true;
        }

        private bool Compare(TreeNode n1, int val)
        {
            if (n1 == null)
            {
                return true;
            }

            return n1.val == val && IsUnivalTree(n1);
        }
    }
}
