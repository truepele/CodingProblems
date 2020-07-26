using System.Collections.Generic;

namespace Misc
{
    public static class FindTwoEqualElementsSolution
    {
        public static (int firstIndex, int secondIndex) FindTwoEqualElements(int[] input)
        {
            var valueToIndexMap = new Dictionary<int, int>();
            
            for (var index = 0; index < input.Length; index++)
            {
                var val = input[index];
                if (valueToIndexMap.ContainsKey(val))
                {
                    return (valueToIndexMap[val], index);
                }

                valueToIndexMap[val] = index;
            }

            return (-1, -1);
        }
    }
}