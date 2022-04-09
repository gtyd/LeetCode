using ConsoleApp;
using ConsoleApp.Models;
using NUnit.Framework;

namespace NUnitTest;

[TestFixture]
public class ReverseListSolutionTests
{
    [Test]
    public void ReverseTest()
    {
        var a = new ListNode(1);
        var b = new ListNode(2);
        var c = new ListNode(3);
        var d = new ListNode(4);

        a.next = b;
        b.next = c;
        c.next = d;

        var rs = ReverseListSolution.Reverse(a);
        
        Assert.AreEqual(4,rs.val);
    }
    
    [Test]
    public void ReverseTest2()
    {
        var a = new ListNode(1);
        var b = new ListNode(2);
        var c = new ListNode(3);
        var d = new ListNode(4);

        a.next = b;
        b.next = c;
        c.next = d;

        var rs = ReverseListSolution.Reverse2(a);
        
        Assert.AreEqual(4,rs.val);
    }
}