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

            int offset = 0;
            //int stepsToJump = 0;

            DoStuff(0, 0);

            //do stuff
            void DoStuff(int inIndex, int stepsToJump)
            {
                var jump = 0;
                if (inIndex < 0)
                {
                    jump = intValues[stepsToJump  + inIndex];
                    intValues[stepsToJump] += 1;

                    sum += 1;
                    DoStuff(stepsToJump + inIndex, jump);
                }
                else
                {
                    jump = intValues[inIndex];
                    intValues[inIndex] += 1;
                }


                //-3
                sum += 1;
                try
                {
                    DoStuff(intValues[inIndex + jump], inIndex + jump);
                }
                catch (Exception e)
                {
                    //done        
                }
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
