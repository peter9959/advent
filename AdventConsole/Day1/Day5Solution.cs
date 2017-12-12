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
        private string _input = File.ReadAllText(@"../../Input/day5_input.txt");
        private string _input2 = File.ReadAllText(@"../../Input/day5_test_input.txt");
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

            var sum2 = DoStuff(0);
            
            //do stuff
            int DoStuff(int inIndex)
            {
                if (inIndex <= intValues.Length - 1)
                {
                    var val = intValues[inIndex];
                    //jump
                    intValues[inIndex] += 1;

                    var localNextIndex = inIndex + val;
                    sum += 1;

                    if(sum < 63000)
                        DoStuff(localNextIndex);

                }

                return sum;
            }






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
