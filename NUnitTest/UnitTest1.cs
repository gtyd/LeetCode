using NUnit.Framework;
using ConsoleApp;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var result = new LengthOfLongestSubstringSolution().LengthOfLongestSubstring("abba");
            Assert.AreEqual(result, 2);
        }
    }
}