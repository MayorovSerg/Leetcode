namespace Problem_002
{
    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = l1;
            l1 = new ListNode(0, l1);

            do
            {
                l1 = l1.next;

                if (l2 != null)
                {
                    l1.val += l2.val;
                    l2 = l2.next;
                }

                if (l1.val > 9)
                {
                    l1.val %= 10;
                    if (l1.next == null)
                        l1.next = new ListNode(1);
                    else 
                        l1.next.val += 1;
                }

            } while (l1.next != null);

            if (l2 != null)
            {
                l1.next = l2;
            }

            return result;
        }
    }
}