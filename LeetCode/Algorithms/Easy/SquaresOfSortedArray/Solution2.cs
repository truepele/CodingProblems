using System;

namespace LeetCode.Algorithms.Easy.SquaresOfSortedArray
{
    public class Solution2
    {
        public static int[] SortedSquares(int[] nums)
        {
            var r = nums.Length - 1;
            var l = 0;
            var result = new int[nums.Length];

            for(var i = nums.Length - 1; i >= 0; i--) {
                var left = (int)Math.Pow(nums[l], 2);
                var right = (int)Math.Pow(nums[r], 2);
                if(left > right) {
                    result[i] = left;
                    l++;
                } else {
                    result[i] = right;
                    r--;
                }
            }

            return result;
        }
    }
}
