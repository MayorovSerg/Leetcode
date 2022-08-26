using System;

namespace Problem_003
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.LengthOfLongestSubstring("abba") == 2);
            Console.WriteLine(solution.LengthOfLongestSubstring("abcabcbb") == 3);
            Console.WriteLine(solution.LengthOfLongestSubstring("bbbbb") == 1);
            Console.WriteLine(solution.LengthOfLongestSubstring("pwwkew") == 3);
        }
    }
}