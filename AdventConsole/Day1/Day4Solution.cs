using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventConsole.Day1
{
    public class Day4Solution
    {
        private string _input = File.ReadAllText(@"../../Input/day4_input.txt");
        //private string _input = File.ReadAllText(@"../../Input/day4_test_input.txt");

        public Day4Solution()
        {
        }

        public int CalculateFirstAnswer()
        {
            return CalculateFirstAnswer(_input);
        }
        //A new system policy has been put in place that requires all accounts to use a passphrase instead of simply a password.A passphrase consists of a series of words (lowercase letters) separated by spaces.

        //To ensure security, a valid passphrase must contain no duplicate words.

        //For example:

        //aa bb cc dd ee is valid.
        //aa bb cc dd aa is not valid - the word aa appears more than once.
        //aa bb cc dd aaa is valid - aa and aaa count as different words.
        public int CalculateFirstAnswer(string input)
        {
            string[] stringLineSeparators = new string[] { "\r\n" };
            string[] stringTabSeparators = new string[] { " " };

            string[] rows = input.Split(stringLineSeparators, StringSplitOptions.None);

            //int sum = 0;

            var invalid = new List<int>();

            for (int i = 0; i < rows.Length; i++)
            {

                var values = rows[i].Split(stringTabSeparators, StringSplitOptions.None);
                //var distinctValues = values.Distinct().ToArray();
                var distinctValues = values.Distinct(StringComparer.CurrentCultureIgnoreCase).ToArray();

                if (values.Length != distinctValues.Length)
                {
                    invalid.Add(i);
                }


            }


            return invalid.Count;
            //3
        }
    }
}
