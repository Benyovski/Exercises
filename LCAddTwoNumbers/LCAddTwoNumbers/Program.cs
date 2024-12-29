namespace LCAddTwoNumbers
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
    };

    internal class Program
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode current = result;
            int carry = 0;

            while (l1 != null || l2 != null)
            {
                int x = (l1 != null) ? l1.val : 0;
                int y = (l2 != null) ? l2.val : 0;

                int sum = x + y + carry;
                carry = sum / 10;

                current.next = new ListNode(sum % 10);
                current = current.next;

                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                } 
            }

            if (carry > 0)
            {
                current.next = new ListNode(carry);
            }

            return result.next;
        }
        static void Main(string[] args)
        {
            ListNode l3 = new(3, null);
            ListNode l2 = new(4, l3);
            ListNode l1 = new(2, l2);
            ListNode[] ll1 = [l1, l2, l3];

            ListNode l6 = new(4, null);
            ListNode l5 = new(6, l6);
            ListNode l4 = new(5, l5);
            ListNode[] ll2 = [l4, l5, l6];
            ListNode[] rl = new ListNode[3];

            ListNode result = new();
            for (int i = 0; i < ll1.Length; i++)
            {
                rl[i] = AddTwoNumbers(ll1[i], ll2[i]);
            }
            for(int i = 0;i < rl.Length; i++)
            {
                Console.WriteLine(rl[i].val);
            }
        }
    }
}
