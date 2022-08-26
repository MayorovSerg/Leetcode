using System;
using System.Collections.Generic;

namespace Problem_003
{
    public class Solution 
    {
        public int LengthOfLongestSubstring(string s)
        {
            var dictionary = new Dictionary<char, int>();
            var maxLength = 0;

            var start = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (dictionary.ContainsKey(s[i]))
                {
                    start = Math.Max(start, dictionary[s[i]] + 1);
                }

                dictionary[s[i]] = i;
                maxLength = Math.Max(maxLength, i - start + 1);
            }

            return maxLength;
        }
    }
}