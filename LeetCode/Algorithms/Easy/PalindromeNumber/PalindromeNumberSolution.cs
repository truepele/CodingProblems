namespace LeetCode.Algorithms.Easy.PalindromeNumber
{
    public static class PalindromeNumberSolution
    {
        public static bool IsPalindrome(int input)
        {
            if (input < 0)
            {
                return false;
            }
            
            long reversed = 0;
            var tmp = input;
            while (tmp != 0)
            {
                reversed = reversed * 10 + tmp % 10;
                tmp /= 10;
            }

            return reversed == input;  
        }
        
        public static bool IsPalindrome2(int input)
        {
            if (input < 0 || input % 10 == 0 && input != 0)
            {
                return false;
            }
            
            var reversed = 0;
            while (input > reversed)
            {
                reversed = reversed * 10 + input % 10;
                input /= 10;
            }

            return reversed == input || input == reversed / 10;
        }
    }
}