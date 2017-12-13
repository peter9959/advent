using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventConsole.Day1
{
    public class Day5Solution
    {
        private string _input = File.ReadAllText(@"c:\temp\day5_input.txt");
        //private string _input2 = File.ReadAllText(@"../../Input/day5_test_input.txt");
        //        For example, consider the following list of jump offsets:

        //0
        //3
        //0
        //1
        //-3
        //Positive jumps("forward") move downward; negative jumps move upward.For legibility in this example, these offset values will be written all on one line, with the current instruction marked in parentheses.The following steps would be taken before an exit is found:


        //(0) 3  0  1  -3  - before we have taken any steps.
        //(1) 3  0  1  -3  - jump with offset 0 (that is, don't jump at all). Fortunately, the instruction is then incremented to 1.
        // 2 (3) 0  1  -3  - step forward because of the instruction we just modified.The first instruction is incremented again, now to 2.
        // 2  4  0  1 (-3) - jump all the way to the end; leave a 4 behind.
        // 2 (4) 0  1  -2  - go back to where we just were; increment -3 to -2.
        // 2  5  0  1  -2  - jump 4 steps forward, escaping the maze.
        //In this example, the exit is reached in 5 steps.
        public int CalculateFirstAnswer()
        {
            return CalculateFirstAnswer(_input);
        }

        public int CalculateFirstAnswer(string input)
        {
            string[] stringLineSeparators = new string[] { "\r\n" };
            string[] stringTabSeparators = new string[] { " " };

            string[] rows = input.Split(stringLineSeparators, StringSplitOptions.None);
            var intValues = Array.ConvertAll(rows, s => int.Parse(s));

            int sum = 0;

            int inIndex = 0;
            while (inIndex >= 0 && inIndex <= intValues.Length - 1)
            {
                var val = intValues[inIndex];

                intValues[inIndex] += 1;

                var localNextIndex = inIndex + val;
                sum += 1;

                inIndex = localNextIndex;
            }

            return sum;
        }

        //Now, the jumps are even stranger: after each jump, if the offset was three or more, 
        //instead decrease it by 1. Otherwise, increase it by 1 as before.

        //Using this rule with the above example, the process now takes 10 steps, and the offset values 
        //after finding the exit are left as 2 3 2 3 -1.

        //How many steps does it now take to reach the exit?
        public int CalculateSecondAnswer()
        {
            return CalculateSecondAnswer(_input);
        }
        public int CalculateSecondAnswer(string input)
        {
            string[] stringLineSeparators = new string[] { "\r\n" };
            string[] stringTabSeparators = new string[] { " " };

            string[] rows = input.Split(stringLineSeparators, StringSplitOptions.None);
            var intValues = Array.ConvertAll(rows, s => int.Parse(s));

            int sum = 0;

            int inIndex = 0;
            while (inIndex >= 0 && inIndex <= intValues.Length - 1)
            {
                var val = intValues[inIndex];

                if (val >= 3 || val <= -3)
                {
                    if(val >= 0)
                        intValues[inIndex] -= 1;
                    else
                    {
                        intValues[inIndex] += 1;
                    }
                }
                else
                {
                    intValues[inIndex] += 1;
                }
                var localNextIndex = inIndex + val;
                sum += 1;

                inIndex = localNextIndex;
            }

            return sum;
        }
    }
}
