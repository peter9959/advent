using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdventConsole.Day1
{
    public class Day2Solution
    {
        private string _input = File.ReadAllText(@"../../Input/day2_input.txt");
        private string _input2 = File.ReadAllText(@"../../Input/day2_test_input.txt");

        public Day2Solution()
        {
        }

        //        For example, given the following spreadsheet:

        //5 1 9 5
        //7 5 3
        //2 4 6 8
        //The first row's largest and smallest values are 9 and 1, and their difference is 8.
        //The second row's largest and smallest values are 7 and 3, and their difference is 4.
        //The third row's difference is 6.
        //In this example, the spreadsheet's checksum would be 8 + 4 + 6 = 18.

        public int CalculateFirstAnswer()
        {
            return CalculateFirstAnswer(_input);
        }

        public int CalculateFirstAnswer(string input)
        {
            string[] stringLineSeparators = new string[] { "\r\n" };
            string[] stringTabSeparators = new string[] { "\t" };

            string[] rows = input.Split(stringLineSeparators, StringSplitOptions.None);

            int sum = 0;

            for (int i = 0; i < rows.Length; i++)
            {
                var values = rows[i].Split(stringTabSeparators, StringSplitOptions.None);
                var intValues = Array.ConvertAll(values, s => int.Parse(s));

                int highestval = intValues.Max();
                int lowestval = intValues.Min();

                sum += (highestval - lowestval);

            }


            return sum;
            //3
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
        public double CalculateSecondAnswer()
        {
            return CalculateSecondAnswer(_input);
        }

        private double CalculateSecondAnswer(string input)
        {
            string[] stringLineSeparators = new string[] { "\r\n" };
            string[] stringTabSeparators = new string[] { "\t" };

            string[] rows = input.Split(stringLineSeparators, StringSplitOptions.None);

            var sum = 0.00;

            for (int i = 0; i < rows.Length; i++) //rows.Length
            {
                var values = rows[i].Split(stringTabSeparators, StringSplitOptions.None);
                var intValues = Array.ConvertAll(values, s => int.Parse(s));
                var intvalueLength = intValues.Length;

                double sumDivide = 0;

                for (int j = 0; j < intvalueLength; j++)
                {
                    var currentValue = intValues[j];
                    var valuesToTestToDivide = intValues.Where((source, index) => index != j).ToArray();
                    bool done = false;

                    for (int k = 0; k < valuesToTestToDivide.Length; k++)
                    {
                        var sumdivideArr = new double[2] { currentValue, valuesToTestToDivide[k] };
                        sumDivide = sumdivideArr.Max() / sumdivideArr.Min();

                        if (sumDivide % 1 == 0)
                        {
                            sum += sumDivide;
                            done = true;
                            break;
                        }
                    }

                    if (done)
                        break;

                }
            }

            return sum;
        }
    }
}
