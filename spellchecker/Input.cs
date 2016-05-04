﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spellchecker
{
    public static class Input
    {
        public static List<string> GetWords(string someString)
        {
            List<string> inputWords = new List<string>();
            char[] delim = { ' ' };
            foreach (string word in someString.Split(delim, StringSplitOptions.RemoveEmptyEntries))
                inputWords.Add(word);
            return inputWords;
        }

        public static string Normalize(string someWord)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '\'' };

            someWord = someWord.ToLower();
            for (int i = 0; !alphabet.Contains(someWord[i]); i++)
                someWord = someWord.Remove(i, 1);
            for (int i = someWord.Length - 1; !alphabet.Contains(someWord[i]); i--)
                someWord = someWord.Remove(i, 1);
            return someWord;
        }

        public static string GetString(List<string> someWords)
        {
            string outputString = "";
            foreach (string word in someWords)
                outputString += word + " ";
            return outputString;
        }
    }
}
