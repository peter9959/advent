using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventConsole.Day1;

namespace Day1UnitTest
{
    [TestClass]
    public class Day4Tests
    {
        [TestMethod]
        public void Day4Solution1Test1()
        {
            var solution = new Day4Solution().CalculateFirstAnswer();

            Assert.AreEqual(1, solution);
        }
    }
}
