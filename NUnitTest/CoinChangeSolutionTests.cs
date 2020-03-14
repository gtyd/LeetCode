using NUnit.Framework;
using ConsoleApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Tests
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