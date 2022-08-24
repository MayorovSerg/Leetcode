using System;
using System.Collections.Generic;

namespace Problem_002
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            PrintResult(solution.AddTwoNumbers(
                new ListNode(2, new ListNode(4, new ListNode(3))),
                new ListNode(5, new ListNode(6, new ListNode(4)))));
            
            PrintResult(solution.AddTwoNumbers(
                new ListNode(0),
                new ListNode(0)));
            
            PrintResult(solution.AddTwoNumbers(
                new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))))),
                new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))));
            
            PrintResult(solution.AddTwoNumbers(
                new ListNode(0),
                new ListNode(7, new ListNode(3))));
        }

        private static void PrintResult(ListNode l)
        {
            var list = new List<int>();
            while (l != null)
            {
                list.Add(l.val);
                l = l.next;
            }

            Console.WriteLine($"[{string.Join(',', list)}]");
        }
    }
}