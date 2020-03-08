using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    /// <summary>
    /// 两数相加
    /// </summary>
    public class AddTwoNumbersSolution
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int val = 0;
            var pre = new ListNode(0);
            var temp = pre;
            while (l1 != null || l2 != null || val != 0)
            {
                //相加取和，遇10进1
                val = val + (l1?.val ?? 0) + (l2?.val ?? 0);
                //临时节点temp此时指向的是当前节点，余数为链表中下一节点本位上的值
                temp.next = new ListNode(val % 10);
                //将下一节点赋值给临时节点temp
                temp = temp.next;
                //取摸，进位，例如：11/10，进位为1
                val /= 10;
                l1 = l1?.next;
                l2 = l2?.next;
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

    /// <summary>
    /// 模拟链表
    /// </summary>
    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int x) { val = x; }
    }
}
