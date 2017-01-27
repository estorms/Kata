using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
            List<int> NumList = new List<int>();
            foreach (var c in numbers)
            {
                //convert each char in string to number and add it to the list
                int val = Convert.ToInt32(c.ToString());
                NumList.Add(val);

                //establish booleans to check for even vs odd
                bool odd = val % 2 != 0;
                bool even = val % 2 == 0;

                //if the character in the iteration is odd, increment oddcounter; otherwise, increment even
                if (odd)
                {
                    OddCounter++;
                }
                else
                {
                    EvenCounter++;
                }
            }
            //check which counter is biggest
            var Biggest = Math.Max(EvenCounter, OddCounter);

            //if the even counter is biggest, query the number list and pull back the first instance of an odd number
            if (EvenCounter == Biggest)
            {
                var result = NumList.Where(item => item % 2 != 0).First();
                //return the "real world" index of the first odd number
                var index = NumList.IndexOf(result) + 1;
                return index;
            }
            else
            {
                //perform the same operation, but with evens
                var result = NumList.Where(item => item % 2 == 0).First();
                var index = NumList.IndexOf(result);
                return index + 1;
            }

        }

        // Your task is to make a function that can take any non-negative integer as a argument and return it with its digits in descending order. Descending order means that you take the highest digit and place the next highest digit immediately after it.

        public int DescendingOrder(int num)
        {
            List<int> NumList = new List<int>();
            var numString = num.ToString();
            foreach (var c in numString)
            {
                //convert each char in string to number and add it to the list
                int val = Convert.ToInt32(c.ToString());
                NumList.Add(val);
            }
            var numArray = NumList.ToArray();
            int[] sortedCopy = numArray.OrderByDescending(i => i).ToArray();
            int output = sortedCopy
            .Select((t, i) => t * Convert.ToInt32(Math.Pow(10, sortedCopy.Length - i - 1)))
            .Sum();
            return output;

        }

        public int DescendingAlt(int num)
        {
            var stringInt = num.ToString().ToList().OrderByDescending(s => s);
            var str = String.Join("", stringInt);
            return Convert.ToInt32(str);
        }

        public int AscendingOrder(int num)
        {
            var NumString = num.ToString().OrderByDescending(i => i);
            var NumList = num.ToString().ToList().OrderBy(i => i);
            var str = String.Join("", NumList);
            return Convert.ToInt32(str);
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

        //         The new "Avengers" movie has just been released! There are a lot of people at the cinema box office standing in a huge line. Each of them has a single 100, 50 or 25 dollars bill. A "Avengers" ticket costs 25 dollars. // Vasya is currently working as a clerk. He wants to sell a ticket to every single person in this line. Can Vasya sell a ticket to each person and give the change if he initially has no money and sells the tickets strictly in the order people follow in the line? Return YES, if Vasya can sell a ticket to each person and give the change. Otherwise return NO.

        public string Tickets(int[] peopleInLine)
        {
            int accumulator = 0;

            string no = "NO";
            string yes = "YES";
            bool divisible;
            for (var i = 0; i <= peopleInLine.Length; i++)
            {
                int currentSale = peopleInLine[i];
                int nextSale = peopleInLine[i + 1];
                if (nextSale % 25 != 0)
                {
                    divisible = false;
                }
                else
                {
                    divisible = true;
                }
                if (divisible == true)
                {
                    return yes;
                }

                else { return no; }
            }
            //    return peopleInLine.Aggregate((num, next) => num * next);

            return no;
        }

        public int Fib(int n)
        {
            int a = 0;
            int b = 1;
            int c;

            for (var i = 0; i <= n; i++)
            {
                c = a;
                a = b;
                b = a + c;
            }
            return a;
        }

        static readonly Regex Validator = new Regex(@"^[ATCG]+$");

        public static bool IsValid(string str)
        {
            return Validator.IsMatch(str);
        }
        public string MakeComplement(string dna)
        {

            char [,] NucleicAcids = new char[2, 2] {{'A', 'T'}, {'C', 'T'}};
            Console.WriteLine("{0} is [0, 0], {1} is [0, 1], {2} is [1, 0], {3} is [1, 1],",  NucleicAcids[0, 0], NucleicAcids[0, 1], NucleicAcids[1, 0], NucleicAcids[1, 1]);
            if (IsValid(dna))
            { 

                StringBuilder sb = new StringBuilder();
                StringBuilder sb2 = new StringBuilder();

                string reversedDNA = dna.ToUpper().Replace((NucleicAcids[0, 0]), (NucleicAcids[0, 1])).ToString();

            //     for (var i = 0; i < dna.Length; i++)
            //     {
            //         if (dna[i].Equals('A'))
            //         {
            //             sb.Append('T');
            //         }
            //         else if (dna[i].Equals('T'))
            //         {
            //             sb.Append('A');
            //         }
            //         else if (dna[i].Equals('C'))
            //         {
            //             sb.Append('G');

            //         }
            //         else if (dna[i].Equals('G'))
            //         {
            //             sb.Append('C');
            //         }
            //     }
            //     return sb.ToString();
            return reversedDNA;
            }

            else
            {
                string rejection = "Sorry, but Mendel says 'no.'";
                return rejection;
            }
        }
    }
}

