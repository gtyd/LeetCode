using ConsoleApp.Models;

namespace ConsoleApp;

/// <summary>
/// 反转链表
/// </summary>
public static class ReverseListSolution
{
    /// <summary>
    /// 算法1
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public static ListNode Reverse(ListNode head)
    {
        ListNode reverse = null;//新链表的头结点
        while (head != null)
        {
            var next = head.next;//备份head的下一个结点的地址
            head.next = reverse;//将第一个结点与原链表断开，使它指向新链表的头结点
            reverse = head;//把reverse指向新链表，赋值为head
            head = next;//将head指向当前原链表的头结点
        }

        return reverse;
    }

    /// <summary>
    /// 算法2
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public static ListNode Reverse2(ListNode head)
    {
        var temp = new ListNode(0);//设置临时头结点
        while (head!=null)
        {
            var next = head.next;
            head.next = temp.next;
            temp.next = head;
            head = next;
        }
        return temp.next;
    }
}