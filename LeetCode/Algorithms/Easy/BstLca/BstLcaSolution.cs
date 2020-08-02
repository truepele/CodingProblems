
using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Algorithms.Easy.BstLca
{
    public static class BstLcaSolution
    {
        public static int LowestCommonAncestor(TreeNode root, int p, int q)
        {
            if(p > root.val && q < root.val
               || p < root.val && q > root.val)
            {
                return root.val;
            }

            var pAncs = new HashSet<TreeNode>();
            var curr = root;
            while(curr.val != p)
            {
                if(curr.val == q)
                {
                    return q;
                }

                pAncs.Add(curr);
                curr = curr.val > p ? curr.left : curr.right;
            }

            curr = root;
            var lastCommon = root;
            while(curr.val != q)
            {
                if(curr.val == p)
                {
                    return p;
                }

                if(pAncs.Contains(curr))
                {
                    lastCommon = curr;
                }

                curr = curr.val > q ? curr.left : curr.right;
            }

            return lastCommon.val;
        }

        public static int LowestCommonAncestor2(TreeNode root, int p, int q)
        {
            if(root.val > p && root.val > q) return LowestCommonAncestor2(root.left, p, q);
            if(root.val < p && root.val < q) return LowestCommonAncestor2(root.right, p, q);
            return root.val;
        }

        public static int LowestCommonAncestor3(TreeNode root, int p, int q)
        {
            while (true)
            {
                if (root.val > p && root.val > q)
                {
                    root = root.left;
                    continue;
                }

                if (root.val < p && root.val < q)
                {
                    root = root.right;
                    continue;
                }

                return root.val;
            }
        }
    }
}
