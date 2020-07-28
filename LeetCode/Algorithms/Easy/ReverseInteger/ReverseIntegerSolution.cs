using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms.Easy.ReverseInteger
{
    public static class ReverseIntegerSolution
    {
        public static int Reverse(int x) 
        {
            var sign = 1;
            if (x < 0)
            {
                sign = -1;
                x *= sign;
            }

            var reversedList = new List<int>();
            
            while (x > 0)
            {
                reversedList.Add(x % 10);
                x /= 10;
            }

            var result = 0;
            var pow = reversedList.Count - 1;
            foreach (var num in reversedList)
            {
                result +=  (int)(num * Math.Pow(10, pow));
                if (result < 0)
                {
                    return 0;
                }

                pow--;
            }

            return result * sign;
        }
        
        public static int Reverse1(int x) 
        {
            var sign = 1;
            if (x < 0)
            {
                sign = -1;
                x *= sign;
            }
            
            var result = 0;
            while (x > 0)
            {
                var pop = x % 10;
                x /= 10;
                result = (int)((double)result * 10 + pop);
                if (result < 0)
                {
                    return 0;
                }
            }

            return result * sign;
        }
        
        public static int Reverse11(int x) 
        {
            var result = 0;
            while (x != 0)
            {
                var pop = x % 10;
                x /= 10;

                if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && pop > 7))
                {
                    return 0;
                }
                if (result < int.MinValue / 10 || (result == int.MinValue / 10 && pop < -8))
                {
                    return 0;
                }
                
                result = result * 10 + pop;
            }

            return result;
        }
        
        public static int Reverse2(int x) 
        {
            var sign = 1;
            if (x < 0)
            {
                sign = -1;
                x *= sign;
            }
            
            var pow = Math.Floor(Math.Log10(x));
            var result = 0;
            while (x > 0)
            {
                result += (int)(x % 10 * Math.Pow(10, pow));
                if (result < 0)
                {
                    return 0;
                }
                x /= 10;
                pow--;
            }

            return result * sign;
        }
        
        public static int Reverse3(int x) 
        {
            var sign = 1;
            if (x < 0)
            {
                sign = -1;
                x *= sign;
            }

            var str = x.ToString();
            str = new string(str.Reverse().ToArray());
            if (int.TryParse(str, out var resultUnsigned))
            {
                return resultUnsigned * sign;
            }

            return 0;
        }

        public static int Reverse4(int x)
        {
            long result = 0;
            while (x != 0)
            {
                result = result * 10 + x % 10;
                x /= 10;
            }

            return result < int.MinValue || result > int.MaxValue ? 0 : (int) result;
        }
    }
}