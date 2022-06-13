using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace TaskC
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CountIt("ahhcccdde");
        }

        public static void CountIt(string name)
        {
            var dict = new Dictionary<char, int>(); // variable saves each character's occurence
            
            // populating our hashtable with every character (key) and it's occurence (value)
            foreach (var c in name)
            {
                dict.TryGetValue(c, out var value);
                if (value == 0) dict.Add(c, 1);
                else dict[c] = value + 1;
            }

            // --NOTICE-- I used the built-in sorting method in .NET instead of creating my own to save time
            var test = dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key).Take(3).ToArray();
            foreach (var c in test)
            {
                Console.WriteLine("{0} {1}", c, dict[c]); // print each character & it's frequency
            }
            
            /* UNCOMPLETED ALGORITHM
            var max = 0;
            char firstMost = ' ', secondMost = ' ', thirdMost = ' ';
            var logoCharacters = new char[3]; // 2nd Constraint half check (can't exceed 3 characters)

            foreach (var c in dict.Keys) // loop that gets most common character
            {
                if (dict[c] > max)
                {
                    max = dict[c];
                    firstMost = c;
                }
            }

            foreach (var c in dict.Keys)
            {
                if (dict[c] > max && dict[c] != firstMost)
                {
                    max = dict[c];
                    secondMost = c;
                }
            }

            foreach (var c in dict.Keys)
            {
                if (dict[c] > max && dict[c] != firstMost && dict[c] != secondMost)
                {
                    max = dict[c];
                    thirdMost = c;
                }
            }

            logoCharacters[0] = firstMost;
            logoCharacters[1] = secondMost;
            logoCharacters[2] = thirdMost;
            
            foreach (var c in logoCharacters)
            {
                Console.WriteLine(c);
            }
            */
        }
    }
}