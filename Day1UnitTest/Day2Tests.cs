using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventConsole.Day1;

namespace Day1UnitTest
{
    [TestClass]
    public class Day2Tests
    {

        //        For example, given the following spreadsheet:

        //5 1 9 5
        //7 5 3
        //2 4 6 8
        //The first row's largest and smallest values are 9 and 1, and their difference is 8.
        //The second row's largest and smallest values are 7 and 3, and their difference is 4.
        //The third row's difference is 6.
        //In this example, the spreadsheet's checksum would be 8 + 4 + 6 = 18.

        #region First
        [TestMethod]
        public void Day2CalculateTest1()
        {
            var solution = new Day2Solution().CalculateFirstAnswer();

            Assert.AreEqual(18, solution);
        }

        //[TestMethod]
        //public void Day2CalculateTest2()
        //{
        //    var solution = new Day2Solution().CalculateFirstAnswer("1111");

        //    Assert.AreEqual(4, solution);
        //}

        //[TestMethod]
        //public void Day2CalculateTest3()
        //{
        //    var solution = new Day2Solution().CalculateFirstAnswer("1234");

        //    Assert.AreEqual(0, solution);
        //}

        //[TestMethod]
        //public void Day2CalculateTest4()
        //{
        //    var solution = new Day2Solution().CalculateFirstAnswer("91212129");

        //    Assert.AreEqual(9, solution);
        //}

        #endregion
    }
}
