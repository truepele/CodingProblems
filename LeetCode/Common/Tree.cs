namespace LeetCode.Common
{
    public static class Tree
    {
        public static TreeNode CreateTree(int?[] nodeValues, int start = 0)
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
