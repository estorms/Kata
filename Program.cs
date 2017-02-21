using System;
using ChallengesLib;
using System.Collections.Generic;
using System.IO;


namespace Challenges
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // var path = System.IO.File.ReadAllLines(@"/Users/elizabethsanger/workspace/c-sharp-challenges/file.txt");
            // foreach(var l in path) {
            // Console.WriteLine("{0}", l);
            // }
            //  using (StringWriter sr = new StringWriter(path)
            // {
	        // // Read the stream to a string, and write the string to the console.
            
            // }

           var array1 = new string[] { ":D", ":~)", ";~D", ":)" };
       var array2= new string[] { ":)", ":(", ":D", ":O", ":;" };
          var array3= new string[] { ";]", ":[", ";*", ":$", ";-D" };
          var array4= new string[] { ";", ")", ";*", ":$", "8-D" };

            int[] numbers = new int[] {1, 3, 3, 4, 7, 6, 5, 8, 9, 10};
            //Description: check for duplicates string and return num of duplicate letters, case-insensitive
            ChallengesLib challengesLib = new ChallengesLib();
        //   Console.WriteLine(challengesLib.FindShort("poop poo"));
    //    Console.WriteLine(challengesLib.Persistence(999));
    //     Console.WriteLine(challengesLib.Persistence(9));
    //     Console.WriteLine(challengesLib.Fib(13));
    //     Console.WriteLine(challengesLib.sumEvens(numbers));
    //     Console.WriteLine(challengesLib.stringCheck("true"));
    //     Console.WriteLine(challengesLib.stringCheck("faalse"));
    //     var sortedArr = challengesLib.SortArray(numbers);
    //     foreach(var a in sortedArr) {
    //         Console.WriteLine("{0}", a);
    //     }
        Console.WriteLine("{0}", challengesLib.IsPalindrome("po oppoop"));
        Console.WriteLine("{0}: array 1, should be 4, {1}: array 2, should be 2, {2}: array 3, should be 1, {3}: array 4, should be 4", challengesLib.CountSmileys(array1), challengesLib.CountSmileys(array2), challengesLib.CountSmileys(array3), challengesLib.CountSmileys(array4));
        }
    }
}



















