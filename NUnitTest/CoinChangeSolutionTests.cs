using ConsoleApp;
using NUnit.Framework;

namespace NUnitTest
{
    [TestFixture()]
    public class CoinChangeSolutionTests
    {
        [Test()]
        public void CoinChangeTest()
        {
            var coins = new[] {1, 3, 5};
            var amount = 17;
            var rs = CoinChangeSolution.CoinChange(coins,amount);
            Assert.AreEqual(5, rs);
        }
    }
}