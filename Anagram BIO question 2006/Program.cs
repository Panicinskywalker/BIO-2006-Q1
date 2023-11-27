using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagramprogram
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the first word: ");
            string word1 = Console.ReadLine();
            Console.Write("Enter the first word: ");
            string word2 = Console.ReadLine();

            string result = IsAnagram(word1, word2);
            Console.WriteLine(result);
        }
        private static string IsAnagram(string word1, string word2) 
        {
            int count = 0;
            string result;
            List<char> letters1 = new List<char>();
            List<char> letters2 = new List<char>();
            foreach (char c in word1.ToLower())
            {
                letters1.Add(c);
            }
            foreach (char c in word2.ToLower())
            {
                letters2.Add(c);
            }
            letters1 = letters1.OrderBy(a => a).ToList();
            letters2 = letters2.OrderBy(a => a).ToList();
            for (int i = 0; i < letters1.Count; i++)
            {
                if (letters1[i] == letters2[i])
                {
                    count++;
                }
            }
            if (count == word1.Length)
            {
                result = "Anagram";
            }
            else
            {
                result = "Not an Anagram";
            }
            return result;
        }
    }
}