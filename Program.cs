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
            //Description: check for duplicates string and return num of duplicate letters, case-insensitive
            ChallengesLib challengesLib = new ChallengesLib();
        //   Console.WriteLine(challengesLib.FindShort("poop poo"));
        Console.WriteLine(challengesLib.Persistence(39));
        }
    }
}



















