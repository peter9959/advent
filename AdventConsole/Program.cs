using AdventConsole.Day1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var day1SolutionCalculator = new Day1Solution();
            var day1testSolution = day1SolutionCalculator.CalculateFirstAnswer();
            var day1testSolution2 = day1SolutionCalculator.CalculateSecondAnswer();

            var day2SolutionCalculator = new Day2Solution();
            var day2Solution = day2SolutionCalculator.CalculateFirstAnswer();
            var day2Solution2 = day2SolutionCalculator.CalculateSecondAnswer();



            Console.WriteLine("**********************************");
            Console.WriteLine("Day 1");


            Console.WriteLine(day1testSolution);


            Console.WriteLine(day1testSolution2);

            Console.WriteLine("**********************************");
            Console.WriteLine("Day 2");


            Console.WriteLine(day2Solution);
            Console.WriteLine(day2Solution2);


            Console.ReadLine();
        }
    }
}
