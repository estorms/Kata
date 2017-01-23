using System;

namespace Challenges
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            //check dupes
            ChallengesLib challengesLib = new ChallengesLib();
            // Console.WriteLine(challengesLib.CheckDupes(" "));
            //  Console.WriteLine(challengesLib.CheckDupes("abcde"));
            //  Console.WriteLine(challengesLib.CheckDupes("aabbcde"));
            //   Console.WriteLine(challengesLib.CheckDupes("aabcDde"));
            // Console.WriteLine(challengesLib.CheckDupes("Indivisibility"));
            // Console.WriteLine(challengesLib.CheckDupes("hulkout"));
            
            //index of odd
         Console.WriteLine(challengesLib.IndexOfOdd("2 4 5"));

         //index of first odd or even in a sequence

          Console.WriteLine(challengesLib.OddOrEven(("2 4 7 8 10")));
           Console.WriteLine(challengesLib.OddOrEven(("1 2 1 1")));
              Console.WriteLine(challengesLib.OddOrEven(("1 1 1 1 11 110")));
           
         
        }
    }
}

