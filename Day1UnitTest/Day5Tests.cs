using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventConsole.Day1;

namespace Day1UnitTest
{
    [TestClass]
    public class Day5Tests
    {
        [TestMethod]
        public void Day5Solution1Test1()
        {
            var solution = new Day5Solution().CalculateFirstAnswer();

            Assert.AreEqual(5, solution);
        }
    }
}
