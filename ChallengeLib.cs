using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace Challenges
{
    public class ChallengesLib
    {


    public string declareWinner(Fighter fighter1, Fighter fighter2) {
        var f1Health = fighter1.Health;
        var f2Health = fighter2.Health;
        var f1Damage = fighter1.DamagePerAttack;
        var f2Damage = fighter2.DamagePerAttack;

        while (f1Health >= 0 && f2Health >=0) {
            f2Health = f2Health - f1Damage;
            f1Health = f1Health - f2Damage;
        }
      return  f1Health >= f2Health ? $"{fighter1.Name}" : $"{fighter2.Name}";
    }
    public int CountSmileys(string[] smileys) {
        var counter = 0;

        foreach(var item in smileys) {
            if ((item.Length == 2) 
            && (item.Contains(':') || item.Contains(';')) 
            && (item.Contains(')') || item.Contains('D'))) {   
                    // if (item.Length ==3 && (item.Contains('~') || item.Contains('-'))){
                    //     counter ++;
                    // }
                    counter ++;
            }
            else if ((item.Length == 3) 
            && (item.Contains(':') || item.Contains(';')) 
            && (item.Contains(')') || item.Contains('D')) 
            && (item.Contains('~') || item.Contains('-'))){
                    //     counter ++;
                    // }
                    counter ++;
            }
        }
        return counter;
    }

    

  
    public  int[] SortArray(int[] array)
  {
    List<int>odds = new List<int>();
      for (var i =0; i < array.Length; i++) {
          if(array[i] %2 != 0) {
              
            //   odds.Add(array[i]);
              
          }
        
      }
          return odds.ToArray();
  }

//          public int[] DataReverse(int[] data)
//   {
        
     
     
//   }
        // Compare two strings by comparing the sum of their values (ASCII character code).
        // For comparing treat all letters as UpperCase.

public bool stringCheck (string str) {
  
  return str.Distinct().Count() == str.Length;

}
        public bool Compare(string s1, string s2)
        {

            var str1 = s1.ToUpper().Sum(s => s);
            var str2 = s2.ToUpper().Sum(s => s);
            return str1 == str2;
        }

        public int sumEvens(int[] nums) {
            return nums.Where(s => s % 2 ==0).Aggregate((s, s1) => s * s);
        }
        // Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, which is the number of times you must multiply the digits in num until you reach a single digit.

        public int Persistence(long n)

        {
            if (n.ToString().Count() == 1)
            {
                return 0;
            }
            else
            {
                var numbers = new List<long>();
                for (; n > 0; n /= 10)
                    numbers.Add(n % 10);
                var product = Convert.ToInt32(numbers.Aggregate((a, b) => a * b));
                if (product >= 0 && product <= 9)
                {
                    return 1;
                }
                else
                {
                    return 1 + Persistence(product);
                }

            }
        }

        public int FindShort(string s)
        {
            var smallest = s.Split(" ".ToCharArray()).ToList().Min(l => l.Count());
            return smallest;
        }

        public bool IsPalindrome(string str)
        {
            str  = str.ToUpper().Replace(" ", String.Empty);
            return str.SequenceEqual(str.Reverse());
        }

        // The numberOfOccurrences function must return the number of occurrences of an element in an array.
        public int NumberOfOccurences(int x, int[] xs)
        {
            var counter = 0;
            for (var i = 0; i < xs.Length; i++)
            {
                if (xs[i] == x)
                {
                    counter++;
                }

            }
            return counter;
        }
        //     return xs.Count(num => num == x);

        public void Fibonacci(int a, int b, int c)
        {
            if (c == 0) return;

            int current = a + b;

            Console.WriteLine(current);

            Fibonacci(a, current, c - 1);
        }
        public int RecursiveFib(int num)
        {
            if (num < 2)
            {
                return 1;
            }
            else
            {
                return RecursiveFib(num - 1) + RecursiveFib(num - 2);
                //THIS WORKS BECAUSE THE SECOND FUNCTION BEGINS RETURNING 1, WHICH THEN PASSES BACK UP THE CHAIN
            }
        }
        public int FindEvenIndex(int[] arr)
        {
            int sum = 0;
            int leftSum = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            for (var j = 0; j < arr.Length; j++)
            {
                sum -= arr[j];

                if (leftSum == sum)
                {
                    return j;
                }
                leftSum += arr[j];

            }


            return -1;
        }
        //String.Concat is working where ToString() is not
        public bool VampireTest(long x, long y)
        {
            var prod = String.Concat((x * y).ToString().OrderBy(c => c));
            var longs = String.Concat((String.Concat(x, y)).OrderBy(c => c));
            return longs == prod;

        }
        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
            try
            {
                //order the jumbled string by converting it to a char array and then ordering by each letter in the array
                var orderedJumble = jumble.ToCharArray().OrderBy(c => c);
                //concat the ordered char array back to string (<IEnumerable> char won't convert via ToString())
                var orderJumbleString = String.Concat(orderedJumble);
                //repeat the above process for each string in the dictionary and add it to a list instantiated to hold the ordered dictionary strings
                var DictionaryList = new List<string>();
                foreach (var s in dictionary)
                {
                    var orderedDictionary = s.ToCharArray().OrderBy(c => c);
                    var orderedDictionaryString = String.Concat(orderedDictionary);
                    DictionaryList.Add(orderedDictionaryString);
                }
                var valuesList = new List<string>();

                for (var i = 0; i < DictionaryList.Count; i++)
                {
                    if (DictionaryList[i] == orderJumbleString)
                    {
                        valuesList.Add(dictionary[i]);
                    }
                    Console.WriteLine("{0}", DictionaryList[i]);
                }
                for (var i = 0; i < valuesList.ToArray().Length; i++)
                {
                    Console.WriteLine("{0} w/in array", valuesList[i]);
                }
                return valuesList.ToArray();

                // throw new NotImplementedException();
            }
            catch
            {
                throw;
            }
        }

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

            char[,] NucleicAcids = new char[2, 2] { { 'A', 'T' }, { 'C', 'T' } };
            Console.WriteLine("{0} is [0, 0], {1} is [0, 1], {2} is [1, 0], {3} is [1, 1],", NucleicAcids[0, 0], NucleicAcids[0, 1], NucleicAcids[1, 0], NucleicAcids[1, 1]);
            if (IsValid(dna))
            {

                StringBuilder sb = new StringBuilder();
                StringBuilder sb2 = new StringBuilder();

                string reversedDNA = dna.ToUpper().Replace((NucleicAcids[0, 0]), (NucleicAcids[0, 1])).ToString();

                for (var i = 0; i < dna.Length; i++)
                {
                    if (dna[i].Equals('A'))
                    {
                        sb.Append('T');
                    }
                    else if (dna[i].Equals('T'))
                    {
                        sb.Append('A');
                    }
                    else if (dna[i].Equals('C'))
                    {
                        sb.Append('G');

                    }
                    else if (dna[i].Equals('G'))
                    {
                        sb.Append('C');
                    }
                }
                return sb.ToString();
                // return reversedDNA;
            }

            else
            {
                string rejection = "Sorry, but Mendel says 'no.'";
                return rejection;
            }
        }

    }
}

