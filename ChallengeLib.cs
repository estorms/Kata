using System;
using System.Linq;
using System.Collections.Generic;

namespace Challenges
{
    public class ChallengesLib
    {
        // Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. The input string can be assumed to contain only alphanumeric characters, including digits, uppercase and lowercase alphabets.
        public int CheckDupes(string str)
        {
            //convert the string to uppercase for case-insensitivity
            str = str.ToUpper();
            // run a query (returns type IEnumerable) that converts the string to an array of characters (line 15), groups each character into an IGrouping<TKey, TElement> when the count of that character in the array is greater than 1 then selects the key (character) of the group
            var qry = (from c in str.ToCharArray()
                       group c by c into g
                       where g.Count() > 1
                       select g.Key);
            int num = qry.Count();
            return num;
        }


//        Bob is preparing to pass IQ test. The most frequent task in this test is to find out which one of the given numbers differs from the others. Bob observed that one number usually differs from the others             in evenness. Help Bob — to check his answers, he needs a program that among the given numbers finds one that is different in evenness, and return a position of this number.
//        ! Keep in mind that your task is to help Bob solve a real IQ test, which means indexes of the elements start from 1 (not 0)

        public int OddOrEven(string numbers)
        {
            //eliminate empty spaces from the string
            numbers = numbers.Replace(" ", String.Empty);
            //establish two counters (even and odd) for iterating through String
                int OddCounter = 0;
                int EvenCounter = 0;
            //instantiate a new list to hold the nums after conversion from string
            List<int>NumList = new List<int>();
            foreach (var c in numbers)
            {
                //convert each char in string to number and add it to the list
                int val = Convert.ToInt32(c.ToString());
                NumList.Add(val);

                //establish booleans to check for even vs odd
                bool odd = val % 2 != 0;
                bool even = val % 2 == 0;

                //if the character in the iteration is odd, increment oddcounter; otherwise, increment even
                if (odd) {
                    OddCounter++;
                }
                else {
                    EvenCounter++;
                }
            }
            //check which counter is biggest
            var Biggest = Math.Max(EvenCounter, OddCounter);

            //if the even counter is biggest, query the number list and pull back the first instance of an odd number
            if (EvenCounter == Biggest) {
                var result = NumList.Where(item => item % 2 !=0).First();
                //return the "real world" index of the first odd number
                var index = NumList.IndexOf(result) + 1;
                return index;
            }
            else {
                //perform the same operation, but with evens
                var result = NumList.Where(item => item %2 ==0).First();
                var index = NumList.IndexOf(result);
                return index + 1;
            }
            
        }

// Your task is to make a function that can take any non-negative integer as a argument and return it with its digits in descending order. Descending order means that you take the highest digit and place the next highest digit immediately after it.

public int DescendingOrder (int num) {
 var nums = num.ToString().ToCharArray().OrderByDescending(i => i).ToArray();
    return Convert.ToInt32(new string(nums));
    

}
        public int IndexOfOdd(string numbers)
        {
            numbers = numbers.Replace(" ", String.Empty);
            foreach (var s in numbers)
            {
                int val = Convert.ToInt32(s.ToString());
                bool odd = val % 2 != 0;
                if (odd)
                {
                    int index = numbers.ToString().IndexOf(s) + 1;
                    return index;
                }
                else
                {
                    continue;
                }
            }
            return -1;
        }
    }
}


