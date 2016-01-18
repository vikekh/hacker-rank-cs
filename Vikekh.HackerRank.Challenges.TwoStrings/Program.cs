using System;

namespace Vikekh.HackerRank.Challenges.TwoStrings
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int t;
            int.TryParse(Console.ReadLine(), out t);

            for (var i = 0; i < t; i++)
            {
                var a = Console.ReadLine();
                var b = Console.ReadLine();

                Console.WriteLine(HasCommonSubstring(a, b) ? "YES" : "NO");
            }
        }

        internal static int GetIndex(char c)
        {
            return (c - 'a');
        }

        internal static bool HasCommonSubstring(string a, string b)
        {
            var shortString = a.Length <= b.Length ? a : b;
            var longString = shortString == b ? a : b;
            var substrings = new bool[26];

            for (var i = 0; i < shortString.Length; i++)
            {
                substrings[GetIndex(shortString[i])] = true;
            }

            for (var i = 0; i < longString.Length; i++)
            {
                if (substrings[GetIndex(longString[i])])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
