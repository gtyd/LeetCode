using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     int val;
     *     ListNode next;
     *     ListNode(int x) { val = x; }
     * }
     */
    public class AddTwoNumbersSolution
    {
        public ListNode addTwoNumbers(ListNode l1, ListNode l2)
        {
            int val = 0;
            var pre = new ListNode(0);
            var temp = pre;
            while (l1 != null || l2 != null || val != 0)
            {
                val = val + (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val);
                temp.next = new ListNode(val % 10);
                temp = temp.next;
                val = val / 10;
                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
            }
            return pre.next;
        }

        public static ListNode GenerateList(int[] vals)
        {
            ListNode cur = null;
            ListNode temp = null;
            foreach (var val in vals)
            {
                if (cur == null)
                {
                    cur = new ListNode(val);
                    temp = cur;
                }
                else
                {
                    var next = new ListNode(val);
                    temp.next = next;
                    temp = next;
                }
            }
            return cur;
        }
    }

    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int x) { val = x; }
    }

    
}
