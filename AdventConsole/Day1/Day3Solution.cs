using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventConsole.Day1
{
    public class Day3Solution
    {
        const int _input = 265149;

        //bottomright = 265225
        //rows = 515

        //265149
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

            if (input == 1)
                return 0;

            int rows = 0;
            
            //find number of rows
            //x^2 > input

            int start = 1;

            while (Math.Pow(start, 2) < input)
            {
                start += 2;
            }

            //number of rows
            rows = start;

            int bottomRightCorner = (int)Math.Pow(rows, 2);

            var row = 0;
            var col = 0;
            //find row number is at
            int reverseStepsToNumber = bottomRightCorner - input; //13
            int numberAtStartOfBottomRow = bottomRightCorner - (rows - 1); //21
            int numberAtStartofFirstRow = numberAtStartOfBottomRow - (rows - 1); //17
            int numberAtEndOfFirstRow = numberAtStartofFirstRow - (rows - 1); //13

            if (input > numberAtStartOfBottomRow)
            {
                row = rows;
                col = 1 + (input - numberAtStartOfBottomRow);
            }
            else if (input > numberAtStartofFirstRow)
            {
                int stepsToNumber = input - numberAtStartofFirstRow;
                row = stepsToNumber + 1;
                col = 1;
            }
            else if (input > numberAtEndOfFirstRow)
            {
                row = 1;
                col = rows - (input - numberAtEndOfFirstRow);
            }
            else
            {
                row = 1 + (numberAtEndOfFirstRow - input);
                col = rows;
            }

            int sum = 0;
            
            var middle = Math.Abs(rows / 2) + 1;

            

            int stepsToMiddleRow = Math.Abs(middle - row);
            int stepsToMiddleCol = Math.Abs(col - middle);

            if (row == middle)
            {
                sum = stepsToMiddleCol;
            }
            else if (col == middle)
            {
                sum = stepsToMiddleRow;
            }
            else
            {
                sum = stepsToMiddleRow + stepsToMiddleCol;

            }




            return sum;
        }
    }
}
