using System;

namespace LeetCode.Algorithms.Easy.SquaresOfSortedArray
{
    public class Solution1
    {
        public static int[] SortedSquares(int[] nums)
        {
            var r = 0;
            for(; r < nums.Length && nums[r] < 0; r++) { }

            var l = r - 1;
            var curr = 0;
            var result = new int[nums.Length];
            while(l >= 0 || r < nums.Length) {
                if(l >= 0 && r >= nums.Length) {
                    result[curr] = (int)Math.Pow(nums[l], 2);
                    l--;
                }
                else if (r < nums.Length && l < 0) {
                    result[curr] = (int)Math.Pow(nums[r], 2);
                    r++;
                }
                else {
                    var left = (int)Math.Pow(nums[l], 2);
                    var right = (int)Math.Pow(nums[r], 2);
                    if(left < right) {
                        result[curr] = left;
                        l--;
                    } else {
                        result[curr] = right;
                        r++;
                    }
                }

                curr++;
            }

            return result;
        }
    }
}
