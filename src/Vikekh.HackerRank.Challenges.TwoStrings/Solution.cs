using System;

namespace Vikekh.HackerRank.Challenges.TwoStrings
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());

            for (var i = 0; i < t; i++)
            {
                var a = Console.ReadLine();
                var b = Console.ReadLine();

                Console.WriteLine(HasCommonSubstring(a, b) ? "YES" : "NO");
            }
        }

        public static bool HasCommonSubstring(string a, string b)
        {
            SortByLength(ref a, ref b);

            var array = new bool[26];

            for (var i = 0; i < a.Length; i++)
            {
                array[a[i].GetLetterIndex()] = true;
            }

            for (var i = 0; i < b.Length; i++)
            {
                if (array[b[i].GetLetterIndex()])
                {
                    return true;
                }
            }

            return false;
        }

        public static void SortByLength(ref string a, ref string b)
        {
            if (a.Length > b.Length)
            {
                var swap = a;

                a = b;
                b = swap;
            }
        }
    }

    public static class Extensions
    {
        public static int GetLetterIndex(this char self)
        {
            return (self - 'a');
        }
    }
}
