using System;
using System.Collections.Generic;

namespace Problem_001
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (dict.ContainsKey(diff))
                {
                    return new[] { i, dict[diff] };
                }
                dict[nums[i]] = i;
            }

            return Array.Empty<int>();
        }
    }
}