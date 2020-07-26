using System.Collections.Generic;

namespace LeetCode.Algorithms.Easy.TwoSum
{
    public static class TwoSumSolution
    {
        public static (int firstIndex, int secondIndex) TwoSum(int[] input, int target)
        {
            var valueToIndexMap = new Dictionary<int, int>();
            
            for (var index = 0; index < input.Length; index++)
            {
                var val = input[index];
                var pairValue = target - val;
                if (valueToIndexMap.TryGetValue(pairValue, out var pairIndex))
                {
                    return (pairIndex, index);
                }

                valueToIndexMap[val] = index;
            }

            return (-1, -1);
        }
    }
}