using System;

namespace Problem_001
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Solution().TwoSum(new[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine($"[{result[0]},{result[1]}]");
            
            result = new Solution().TwoSum(new[] { 3, 2, 4 }, 6);
            Console.WriteLine($"[{result[0]},{result[1]}]");

            result = new Solution().TwoSum(new[] { 3, 3 }, 6);
            Console.WriteLine($"[{result[0]},{result[1]}]");
        }
    }
}