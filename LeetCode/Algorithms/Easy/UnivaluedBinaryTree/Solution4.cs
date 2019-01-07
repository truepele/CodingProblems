using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms.Easy.UnivaluedBinaryTree
{
    public class Solution4 : ISolution
    {
        public bool IsUnivalTree(TreeNode root)
        {
            if (root == null) { throw new ArgumentNullException(nameof(root)); }

            var set = new HashSet<int>();
            return CheckRecursively(root, set);
        }

        private bool CheckRecursively(TreeNode root, ISet<int> set)
        {
            if (set.Add(root.val) && set.Count > 1)
            {
                return false;
            }

            return (root.left == null || CheckRecursively(root.left, set))
                && (root.right == null || CheckRecursively(root.right, set));
        }
    }
}
