using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventConsole.Day1;

namespace Day1UnitTest
{
    [TestClass]
    public class Day3Tests
    {
        //Each square on the grid is allocated in a spiral pattern starting at a 
        //location marked 1 and then counting up while spiraling outward.For example, the first few squares 
        //are allocated like this:

        //17  16  15  14  13
        //18   5   4   3  12
        //19   6   1   2  11
        //20   7   8   9  10
        //21  22  23  24  25

        //While this is very space-efficient (no squares are skipped), requested data must 
        //be carried back to square 1 (the location of the only access port for this memory system) 
        //by programs that can only move up, down, left, or right.They always take the shortest path: 
        //    the Manhattan Distance between the location of the data and square 1.

   //For example:

   //1 * 0 = 1
   //12 * 3 = 1
   //23 * 2 = 1
   //1024 * 31 = 1


   //Data from square 1 is carried 0 steps, since it's at the access port.
   //Data from square 12 is carried 3 steps, such as: down, left, left.
   //Data from square 23 is carried only 2 steps: up twice.
   //Data from square 1024 must be carried 31 steps.
   //How many steps are required to carry the data from the square identified in 
   //your puzzle input all the way to the access port?

   [TestMethod]
        public void Day3Solution1Test1()
        {
            var solution = new Day3Solution().CalculateFirstAnswer(1);

            Assert.AreEqual(0, solution);
        }

        [TestMethod]
        public void Day3Solution1Test2()
        {
            var solution = new Day3Solution().CalculateFirstAnswer(12);

            Assert.AreEqual(3, solution);
        }

        [TestMethod]
        public void Day3Solution1Test3()
        {
            var solution = new Day3Solution().CalculateFirstAnswer(23);

            Assert.AreEqual(2, solution);
        }

        [TestMethod]
        public void Day3Solution1Test4()
        {
            var solution = new Day3Solution().CalculateFirstAnswer(1024);

            Assert.AreEqual(31, solution);
        }
    }
}
