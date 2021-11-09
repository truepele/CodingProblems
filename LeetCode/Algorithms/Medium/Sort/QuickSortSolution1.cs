using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms.Medium.Sort
{
    public static class QuickSortSolution1
    {
        public static IEnumerable<int> SortArray(int[] nums) {
            Shuffle(nums);
            Sort(nums, 0, nums.Length - 1);
            return nums;
        }

        private static void Sort(IList<int> nums, int s, int e) {
            if(s >= e) return;

            var pivot = Partition(nums, s, e);
            Sort(nums, s, pivot - 1);
            Sort(nums, pivot + 1, e);
        }

        private static int Partition(IList<int> nums, int s, int e) {
            var pivot = nums[s];
            var i = s;
            var j = e + 1;

            while(i < j) {
                while (nums[++i] < pivot && i < e) { }
                while (nums[--j] > pivot && j > s) { }
                if(i < j) Swap(nums, i, j);
            }

            Swap(nums, s, j);

            return j;
        }

        private static void Swap(IList<int> nums, int i, int j) {
            var tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }

        private static void Shuffle(IList<int> nums) {
            var r = new Random();
            for(var i = 1; i < nums.Count; i++) {
                var j = r.Next(i + 1);
                Swap(nums, j, i);
            }
        }
    }
}
