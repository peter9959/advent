﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventConsole.Day1
{

    public class Day1Solution
    {
        const string _input = "36743676522426214741687639282183216978128565594112364817283598621384839756628424146779311928318383597235968644687665159591573413233616717112157752469191845757712928347624726438516211153946892241449523148419426259291788938621886334734497823163281389389853675932246734153563861233894952657625868415432316155487242813798425779743561987563734944962846865263722712768674838244444385768568489842989878163655771847362656153372265945464128668412439248966939398765446171855144544285463517258749813731314365947372548811434646381595273172982466142248474238762554858654679415418693478512641864168398722199638775667744977941183772494538685398862344164521446115925528534491788728448668455349588972443295391385389551783289417349823383324748411689198219329996666752251815562522759374542652969147696419669914534586732436912798519697722586795746371697338416716842214313393228587413399534716394984183943123375517819622837972796431166264646432893478557659387795573234889141897313158457637142238315327877493994933514112645586351127139429281675912366669475931711974332271368287413985682374943195886455927839573986464555141679291998645936683639162588375974549467767623463935561847869527383395278248952314792112113126231246742753119748113828843917812547224498319849947517745625844819175973986843636628414965664466582172419197227695368492433353199233558872319529626825788288176275546566474824257336863977574347328469153319428883748696399544974133392589823343773897313173336568883385364166336362398636684459886283964242249228938383219255513996468586953519638111599935229115228837559242752925943653623682985576323929415445443378189472782454958232341986626791182861644112974418239286486722654442144851173538756859647218768134572858331849543266169672745221391659363674921469481143686952478771714585793322926824623482923579986434741714167134346384551362664177865452895348948953472328966995731169672573555621939584872187999325322327893336736611929752613241935211664248961527687778371971259654541239471766714469122213793348414477789271187324629397292446879752673";

        public Day1Solution()
        {
        }

        //The captcha requires you to review a sequence of digits(your puzzle input) 
        //and find the sum of all digits that match the next digit in the list.
        //The list is circular, so the digit after the last digit is the first digit in the list.

        //1122 produces a sum of 3 (1 + 2) because the first digit(1) matches the second digit and the third digit(2) matches the fourth digit.
        //1111 produces 4 because each digit (all 1) matches the next.
        //1234 produces 0 because no digit matches the next.
        //91212129 produces 9 because the only digit that matches the next one is the last digit, 9.
        public int CalculateFirstAnswer()
        {
            return CalculateFirstAnswer(_input);
        }
        
        public int CalculateFirstAnswer(string input)
        {
            //1122
            var arr = input.ToCharArray();

            int sum = 0;

            var firstVal = arr[0];
            var oldval = new char();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    oldval = arr[i];
                    continue;
                }

                if (oldval == arr[i])
                {
                    int val = int.Parse(arr[i].ToString());
                    sum += val;
                }
                else
                {
                    oldval = arr[i];
                }

                //last
                if (i == arr.Length - 1)
                {
                    if (firstVal == arr[i])
                    {
                        int val = int.Parse(arr[i].ToString());
                        sum += val;
                    }
                }
            }

            return sum;
            //3
        }

        //You notice a progress bar that jumps to 50% completion.Apparently, the door isn't yet satisfied, but it did emit a star as encouragement. The instructions change:
        //Now, instead of considering the next digit, it wants you to consider the digit halfway around the circular list.
        //That is, if your list contains 10 items, only include a digit in your sum if the digit 10/2 = 5 steps forward matches it.
        //Fortunately, your list has an even number of elements.
        //For example:

        //1212 produces 6: the list contains 4 items, and all four digits match the digit 2 items ahead.
        //1221 produces 0, because every comparison is between a 1 and a 2.
        //123425 produces 4, because both 2s match each other, but no other digit has a match.
        //123123 produces 12.
        //12131415 produces 4.
        //What is the solution to your new captcha?

        public int CalculateSecondAnswer()
        {
            return CalculateSecondAnswer(_input);
        }

        public int CalculateSecondAnswer(string input)
        {
            var arr = input.ToCharArray();

            int sum = 0;

            var arrLength = arr.Length;
            var stepsforward = arrLength / 2;


            for (int i = 0; i < arrLength; i++)
            {
                int compareIndex = 0;

                //go from middle
                if (i <= stepsforward - 1)
                {
                    compareIndex = i + stepsforward;
                }
                //loop to beginning
                else
                {
                    //solve 7 - x = 1

                    //123425
                    compareIndex = (i + stepsforward) - (arrLength); 
                }

                if (arr[i] == arr[compareIndex]) 
                {
                    int val = int.Parse(arr[i].ToString());
                    sum += val;
                }
            }

            return sum;
        }
    }
}
