using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ChallengesLib
{
    // Write a method that, given the person Ted and the string 'Joe' are passed in, will return Joe's birth month. Once that is complete, augment the method to handle Names that do not exist in the family tree.
    public class Person
    {
        public Person()
        {
            Descendants = new List<Person>();
        }

        public string Name { get; set; }
        public List<Person> Descendants { get; set; }
        public DateTime Birthday { get; set; }

        // public string GetBirthMonth(Person person, string Name)
        // {
        //     //instantiate list to hold all Persons in the family originate from Ted
        //     Person chosenOne = null;
        //     String birthDate = "";
        //     var family = new List<Person> { person };
        //     foreach (var d in person.Descendants)
        //     {
        //         family.Add(d);
        //         foreach (var d2 in d.Descendants)
        //         {
        //             family.Add(d2);
        //         }
        //     }
        //     foreach (var f in family)
        //     {
        //         if (f.Name == Name)
        //         {
        //             chosenOne = f;
        //             birthDate = f.Birthday.ToString("MMMM");
        //         }

        //     }
        //     return birthDate;
        // }

        public string GetBirthMonth(Person person, string descendantName)
        {
            string birthMonth = "";
            if (person.Name == descendantName)
            {
                return person.Birthday.ToString("MMMM");
            }

            foreach (var d in person.Descendants)
            {
                birthMonth = GetBirthMonth(d, descendantName);
                if (birthMonth != string.Empty) break;
            }

            return birthMonth;
        }
    }

    //    if (node == null)
    //     return;

    // output.Add(node);
    // Console.WriteLine(node.Name);

    // foreach (var n in node.Nodes)
    // {
    //     GetNodes(n, output);
    // }




    public static class FamilyTreeGenerator
    {
        public static Person Make()
        {
            return new Person
            {
                Name = "Ted",
                Birthday = DateTime.Parse("5/5/1950"),
                Descendants = new List<Person>
                {
                    new Person
                    {
                        Name = "Sally",
                        Birthday = DateTime.Parse("4/5/1965"),
                        Descendants = new List<Person>
                        {
                            new Person {Name = "Bob", Birthday = DateTime.Parse("9/5/1995")}
                        }
                    },
                    new Person
                    {
                        Name = "Jim",
                        Birthday = DateTime.Parse("3/5/1966"),
                        Descendants = new List<Person>
                        {
                            new Person {Name = "Joe", Birthday = DateTime.Parse("1/5/1985")},
                            new Person {Name = "George", Birthday = DateTime.Parse("6/5/1995"),
                            Descendants = new List<Person>
                                {
                                    new Person {Name = "Steve", Birthday = DateTime.Parse("2/5/1985")},
                                    new Person {Name = "Susan", Birthday = DateTime.Parse("9/5/1995")}
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}