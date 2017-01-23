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

        public int IndexOfOdd(string numbers) {
        
            numbers = numbers.Replace(" ", String.Empty);
            List<int>NumsList = new List<int>();            
            foreach(var s in numbers) {
               
               int val = Convert.ToInt32(s.ToString());
               bool odd = val % 2 != 0;
               if (odd) {
                   
               int index = numbers.ToString().IndexOf(s) + 1;
               return index;
               }
               else {
                  continue;
               }
        
            }
            return -1;
        
        
            

        }
    }
}












//     for (int i = 0; i < strArr.Length; i++)
//     {

//         if (str.IndexOf(strArr[i]) != str.LastIndexOf(strArr[i]))
//         {
//             Dupes.Add(strArr[i]);
//             var groupedDupes = Dupes.GroupBy(h => h);
//             foreach (var d in groupedDupes)
//             {
//                 // Console.WriteLine("{0}, {1}", d.Key, d.Count());
//                 Counts.Add(d.Count());
//             }
//                 Biggest = Counts.Max();
//                 foreach(var we in Counts) {
//                 Console.WriteLine("{0} is counts", we);
//                 };
//             return Biggest;
//         }
//         else {
//              Biggest = 0;
//             return Biggest;
//         }
//     }
//     return 0;
// }



// public void StringToArray(string str)
// {
//     List<char> charCount = new List<char>();
//     var charArr = str.ToUpper().ToArray();
//     int charArrLength = charArr.Length;
//     for (var i = 0; i < charArr.Length; i++)
//     {
//         for (var j = charArr.Length - 1; j > 0; j--)
//         {
//             if (charArr[i] == charArr[j])
//             {
//                 Console.WriteLine("{0}", charArr[i]);
//                 charCount.Add(charArr[i]);
//             }
//         }
//     }

//     //     ß        int n = 5;
//     // for (int row = 0; row < n; row++) {
//     //     for (int col = 0;col < n; col++) {
//     //         Console.Write("# ");
//     //     }
//     //     Console.WriteLine();
//     // }



