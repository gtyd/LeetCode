using ConsoleApp;
using NUnit.Framework;

namespace NUnitTest
{
    [TestFixture()]
    public class AddTwoNumbersSolutionTests
    {
        [Test()]
        public void AddTwoNumbersTest()
        {
            var l1 = AddTwoNumbersSolution.GenerateList(new[] {2, 3, 4});
            var l2 = AddTwoNumbersSolution.GenerateList(new[] { 9, 8, 7 });
            var l3 = new AddTwoNumbersSolution().AddTwoNumbers(l1, l2);
            Assert.AreEqual(4, l3.val);
        }
    }
}