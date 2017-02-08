using System;
using ChallengesLib;
using System.Collections.Generic;

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


            //here, calling on static method within static class exactly as would w/non-statics, minus object instantation

            //This is the progenitor, type Person, name Ted;
            var Ted = FamilyTreeGenerator.Make();
            var fam = Ted.GetBirthMonth(Ted, "Susan");
            Console.WriteLine("{0}", fam);
            Console.WriteLine(challengesLib.VampireTest(1, 0));
            // foreach (var f in fam) {
        }
    }
}


























// Console.WriteLine("{0} is the family member's name, {1} is his or her birthday", f.Name, f.Birthday);
//   var descendants = firstGen.GetDescendants(firstGen, "Ted");
//   foreach(var d in descendants) {
//       Console.WriteLine("{0} is an entry in the descendents return", d);
//   }
//     //These are Ted's descendants, a list of Persons, names Sally and Jim
//     var secondGen = new List<Person>();

//     //These are our third generation members, a list of Persons, names Bob (son of Sally), Joe, and George (sons of Jim)
//     var thirdGen = new List<Person>();

//     foreach (var d in firstGen.Descendants)
//     {
//         secondGen.Add(d);
//     }
//    foreach(var d in secondGen) {
//      foreach(var d2 in d.Descendants) {
//          Console.WriteLine("{0} should be a thirdGen name", d2.Name);
//          thirdGen.Add(d2);
//      }
//    }
//     var firstGenDescendants = firstGen.GetDescendants(firstGen, "Ted");
//     foreach (var f in firstGenDescendants) {
//   Console.WriteLine("{0} is descendants", f);
//     }
// }


