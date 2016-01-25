using System;

namespace Vikekh.HackerRank.Challenges.SimpleTextEditor
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/simple-text-editor
    /// </summary>
    public class Solution
    {
        public static void Main(string[] args)
        {
            var editor = new SimpleTextEditor();
            var q = int.Parse(Console.ReadLine());

            for (var i = 0; i < q; i++)
            {
                var line = Console.ReadLine();
                var t = line[0] - '0';
                string arg = null;

                if (line.Length > 2 && line[1] == ' ')
                {
                    arg = line.Substring(2);
                }

                var print = editor.Apply(t, arg);

                if (print != null)
                {
                    Console.WriteLine(print);
                }
            }
        }
    }

    public class SimpleTextEditor
    {
        public string Apply(int t, string arg)
        {
            if (t == 3)
            {
                return ".";
            }

            return null;
        }
    }
}
