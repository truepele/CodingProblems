using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms.Medium.ThreeSum
{
    public static class ThreeSumSolution
    {
        public static IList<IList<int>> ThreeSum(int[] input)
        {
            Array.Sort(input);
            var results = new List<IList<int>>();
            for (var i = 0; i < input.Length; i++)
            {
                if (i > 0 && input[i] == input[i - 1])
                {
                    continue;
                }
                
                var twoSums = TwoSumOnSorted(input, i + 1, -input[i]);
                if (twoSums.Count == 0)
                {
                    continue;
                }

                foreach (var twoSum in twoSums)
                {
                    results.Add(new[] {input[i], twoSum[0], twoSum[1]});
                }
            }
            
            return results;
        }

        private static IList<IList<int>> TwoSumOnSorted(IList<int> input, int startIndex = 0, int target = 0)
        {
            int i = startIndex, j = input.Count - 1;
            var results = new List<IList<int>>();

            while (i < j)
            {
                if (input[i] + input[j] == target)
                {
                    var prev = results.LastOrDefault();
                    if (prev == null || prev[0] != input[i] && prev[1] != input[j])
                    {
                        results.Add(new[] {input[i], input[j]});
                    }

                    i++;
                    j--;
                }
                else if(input[i] + input[j] < target)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return results;
        }
    }
}