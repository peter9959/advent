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
        private string _input = File.ReadAllText(@"../../Input/day2_test_input.txt");

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
            //1122
            //var arr = input.ToCharArray();

            int sum = 0;

            //var firstVal = arr[0];
            //var oldval = new char();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        oldval = arr[i];
            //        continue;
            //    }

            //    if (oldval == arr[i])
            //    {
            //        int val = int.Parse(arr[i].ToString());
            //        sum += val;
            //    }
            //    else
            //    {
            //        oldval = arr[i];
            //    }

            //    //last
            //    if (i == arr.Length - 1)
            //    {
            //        if (firstVal == arr[i])
            //        {
            //            int val = int.Parse(arr[i].ToString());
            //            sum += val;
            //        }
            //    }
            //}

            return sum;
            //3
        }


    }
}
