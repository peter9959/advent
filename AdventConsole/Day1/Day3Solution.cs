﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventConsole.Day1
{
    public class Day3Solution
    {
        const int _input = 265149;
        //        Each square on the grid is allocated in a spiral pattern starting at a location marked 1 and then counting up while spiraling outward.For example, the first few squares are allocated like this:

        //17  16  15  14  13
        //18   5   4   3  12
        //19   6   1   2  11
        //20   7   8   9  10
        //21  22  23---> ...
        //While this is very space-efficient (no squares are skipped), requested data must be carried back to square 1 (the location of the only access port for this memory system) by programs that can only move up, down, left, or right.They always take the shortest path: the Manhattan Distance between the location of the data and square 1.

        //For example:

        //Data from square 1 is carried 0 steps, since it's at the access port.
        //Data from square 12 is carried 3 steps, such as: down, left, left.
        //Data from square 23 is carried only 2 steps: up twice.
        //Data from square 1024 must be carried 31 steps.
        //How many steps are required to carry the data from the square identified in your puzzle input all the way to the access port?
        public int CalculateFirstAnswer()
        {
            return CalculateFirstAnswer(_input);
        }

        public int CalculateFirstAnswer(int input)
        {
            int sum = 0;

            //string[] stringLineSeparators = new string[] { "\r\n" };
            //string[] stringTabSeparators = new string[] { "\t" };

            //string[] rows = input.Split(stringLineSeparators, StringSplitOptions.None);


            //for (int i = 0; i < rows.Length; i++)
            //{
            //    var values = rows[i].Split(stringTabSeparators, StringSplitOptions.None);
            //    var intValues = Array.ConvertAll(values, s => int.Parse(s));

            //    int highestval = intValues.Max();
            //    int lowestval = intValues.Min();

            //    sum += (highestval - lowestval);

            //}


            return sum;
            //3
        }
    }
}
