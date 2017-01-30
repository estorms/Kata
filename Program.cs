﻿using System;

namespace Challenges
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Description: check for duplicates string and return num of duplicate letters, case-insensitive
            ChallengesLib challengesLib = new ChallengesLib();
            Console.WriteLine(challengesLib.CheckDupes(" "));
            Console.WriteLine(challengesLib.CheckDupes("abcde"));
            Console.WriteLine(challengesLib.CheckDupes("aabbcde"));
            Console.WriteLine(challengesLib.CheckDupes("aabcDde"));
            Console.WriteLine(challengesLib.CheckDupes("Indivisibility"));
            Console.WriteLine(challengesLib.CheckDupes("hulkout"));

            //Description: index of odd

            Console.WriteLine(challengesLib.IndexOfOdd("2 4 5"));

            //Description: index of first odd or even in a sequence

            Console.WriteLine(challengesLib.OddOrEven(("2 4 7 8 10")));
            Console.WriteLine(challengesLib.OddOrEven(("1 2 1 1")));
            Console.WriteLine(challengesLib.OddOrEven(("1 1 1 1 11 110")));

            //Description: order string of nums by descending

            Console.WriteLine(challengesLib.DescendingOrder(6874));
            Console.WriteLine(challengesLib.AscendingOrder(6874));
            Console.WriteLine(challengesLib.DescendingAlt(6874));

            //Description: Fizzbuzz

            for (var i = 0; i <= 25; i++)
            {

                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("buzz");
                }

                else
                {
                    Console.WriteLine(i);
                }

            }

            //Description: Fibonacci Sequence

            for (var i = 0; i <= 20; i++)
            {
                Console.WriteLine(challengesLib.Fib(i));
            }
            Console.WriteLine(challengesLib.MakeComplement("ATCCG"));
            string[] dictionary1 = new string[] { "sport", "parrot", "ports", "matey" };
            var results = challengesLib.GetPossibleWords("ortsp", dictionary1);
            foreach (var r in results)
            {
                Console.WriteLine("Possible interpretations include {0}", r);
           }
        }
    }
}

