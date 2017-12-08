using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventConsole.Day1;

namespace Day1UnitTest
{
    [TestClass]
    public class Day1Tests
    {
        //The captcha requires you to review a sequence of digits(your puzzle input) 
        //and find the sum of all digits that match the next digit in the list.
        //The list is circular, so the digit after the last digit is the first digit in the list.

        //1122 produces a sum of 3 (1 + 2) because the first digit(1) matches the second digit and the third digit(2) matches the fourth digit.
        //1111 produces 4 because each digit (all 1) matches the next.
        //1234 produces 0 because no digit matches the next.
        //91212129 produces 9 because the only digit that matches the next one is the last digit, 9.

        #region First
        [TestMethod]
        public void Day1CalculateTest1()
        {
            var solution = new Day1Solution().CalculateFirstAnswer("1122");

            Assert.AreEqual(3, solution);
        }

        [TestMethod]
        public void Day1CalculateTest2()
        {
            var solution = new Day1Solution().CalculateFirstAnswer("1111");

            Assert.AreEqual(4, solution);
        }

        [TestMethod]
        public void Day1CalculateTest3()
        {
            var solution = new Day1Solution().CalculateFirstAnswer("1234");

            Assert.AreEqual(0, solution);
        }

        [TestMethod]
        public void Day1CalculateTest4()
        {
            var solution = new Day1Solution().CalculateFirstAnswer("91212129");

            Assert.AreEqual(9, solution);
        }

        #endregion

        #region Second
        //Now, instead of considering the next digit, it wants you to consider the digit halfway around the circular list.That is, if your list contains 10 items, only include a digit in your sum if the digit 10/2 = 5 steps forward matches it.Fortunately, your list has an even number of elements.
        //For example:

        //1212 produces 6: the list contains 4 items, and all four digits match the digit 2 items ahead.
        //1221 produces 0, because every comparison is between a 1 and a 2.
        //123425 produces 4, because both 2s match each other, but no other digit has a match.
        //123123 produces 12.
        //12131415 produces 4.

        [TestMethod]
        public void Day1CalculateSecondTest1()
        {
            var solution = new Day1Solution().CalculateSecondAnswer("1212");

            Assert.AreEqual(6, solution);
        }
        [TestMethod]
        public void Day1CalculateSecondTest2()
        {
            var solution = new Day1Solution().CalculateSecondAnswer("1221");

            Assert.AreEqual(0, solution);
        }
        [TestMethod]
        public void Day1CalculateSecondTest3()
        {
            var solution = new Day1Solution().CalculateSecondAnswer("123425");

            Assert.AreEqual(4, solution);
        }
        [TestMethod]
        public void Day1CalculateSecondTest4()
        {
            var solution = new Day1Solution().CalculateSecondAnswer("123123");

            Assert.AreEqual(12, solution);
        }
        [TestMethod]
        public void Day1CalculateSecondTest5()
        {
            var solution = new Day1Solution().CalculateSecondAnswer("12131415");

            Assert.AreEqual(4, solution);
        }
        #endregion

    }
}
