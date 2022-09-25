using System;

namespace Problem_004
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(new [] {1, 3}, new []{ 2, 6}, 2.5d);
            Test(new [] {1, 3}, new []{ 2 }, 2d);
            Test(new [] {1, 3}, new int[]{  }, 2d);
            Test(new [] {5}, new int[]{  }, 5d);
        }

        private static void Test(int[] arr1, int[] arr2, double expect)
        {
            var solution = new Solution();
            var median = solution.FindMedianSortedArrays(arr1, arr2);
            var answer = Math.Abs(median - expect) < 0.00001 ? "Correct" : "Incorrect";
            Console.WriteLine($"Median: {median}; Answer: {answer}");
        }
    }
}