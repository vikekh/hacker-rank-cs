using System;
using System.Collections.Generic;
using System.Linq;

namespace Vikekh.HackerRank.Challenges.SimpleTextEditor
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/simple-text-editor
    /// </summary>
    public class Solution
    {
        public static void Main(string[] args)
        {
            var editor = new Editor();
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

                var print = editor.Operation(t, arg);

                if (print != null)
                {
                    Console.WriteLine(print);
                }
            }
        }
    }

    public class Editor
    {
        public IList<string> Stack { get; set; }

        public Editor(string init = "")
        {
            Stack = new List<string>();
            Stack.Add(init);
        }

        public string Operation(int t, string arg)
        {
            if (t == 1)
            {
                Append(arg);
            }
            else if (t == 2)
            {
                Erase(int.Parse(arg));
            }
            else if (t == 3)
            {
                return Get(int.Parse(arg));
            }
            else if (t == 4)
            {
                Undo();
            }

            return null;
        }

        public void Append(string w)
        {
            Stack.Add(Stack.Last() + w);
        }

        public void Erase(int k)
        {
            Stack.Add(Stack.Last().Substring(0, Stack.Last().Length - k));
        }

        public string Get(int k)
        {
            return Stack.Last()[k - 1].ToString();
        }

        public void Undo()
        {
            Stack.RemoveAt(Stack.Count() - 1);
        }
    }
}
