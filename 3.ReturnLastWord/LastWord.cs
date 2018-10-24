namespace _3.ReturnLastWord
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    public class LastWord
    {

        public static void Main()
        {
            char[] SplitSymbols = { ',', ' ', '-' };
            

            string[] text = Console.ReadLine()
                    .Split(SplitSymbols, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            int count = 1;

            string[] result = new string[0];
            StringBuilder sb = new StringBuilder();

            foreach (var word in text)
            {
                if (word.Contains('.'))
                {
                     sb.Append( GetLastWord(word));
                    sb.Append(" ");
                }
            }
            result = sb.ToString()
                .Trim()
                .Split(SplitSymbols, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(String.Join(", ",result));
        }

        private static string GetLastWord(string word)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var w in word)
            {
                if (w != '.')
                {
                    sb.Append(w);
                }
            }

            return sb.ToString().Trim();
        }
    }
}

