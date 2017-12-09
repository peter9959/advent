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

        //It sounds like the goal is to find the only two numbers in each row where one evenly divides the other 
        //- that is, where the result of the division operation is a whole number.They would like you to find 
        //those numbers on each line, divide them, and add up each line's result.

        //For example, given the following spreadsheet:

        //5 9 2 8
        //9 4 7 3
        //3 8 6 5
        //In the first row, the only two numbers that evenly divide are 8 and 2; the result of this division is 4.
        //In the second row, the two numbers are 9 and 3; the result is 3.
        //In the third row, the result is 2.
        //In this example, the sum of the results would be 4 + 3 + 2 = 9.
        [TestMethod]
        public void Day2CalculateTest2()
        {
            var solution = new Day2Solution().CalculateSecondAnswer();

            Assert.AreEqual(9, solution);
        }

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
