using System;

namespace LeetCode.Algorithms.Easy.UnivaluedBinaryTree
{
    public class Solution1 : ISolution
    {
        public bool IsUnivalTree(TreeNode root)
        {
            if (root == null) { throw new ArgumentNullException(nameof(root)); }

            return CheckRecursively(root);
        }

        private bool CheckRecursively(TreeNode root)
        {
            if (root.left != null)
            {
                if (root.left.val != root.val)
                {
                    return false;
                }

                if (IsUnivalTree(root.left) != true)
                {
                    return false;
                }
            }

            if (root.right != null)
            {
                if (root.right.val != root.val)
                {
                    return false;
                }

                if (IsUnivalTree(root.right) != true)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
