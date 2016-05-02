using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spellchecker
{
    class Input
    {
        private List<string> input_words = new List<string>();

        public void GetWords(string someString)
        {
            StringToWords(someString);
        }

        private void StringToWords(string someString)
        {
            char[] delim = { ' ' };
            foreach (string word in someString.Split(delim, StringSplitOptions.RemoveEmptyEntries)) input_words.Add(word);
        }

        public void CheckWords(Dictionary someDictionary)
        {
            for (int i = 0; i < input_words.Count; i++)
            {
                if (!someDictionary.Parse(TrimWord(input_words[i]))) input_words[i] = input_words[i].ToUpper();
            }
        }

        private string WordsToString()
        {
            string output_string = "";
            foreach (string word in input_words) output_string += word + " ";
            return output_string;
        }

        public string GetString()
        {
            return WordsToString();
        }

        private string TrimWord(string someWord)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '\'' };
            int i = 0;

            someWord = someWord.ToLower();
            while (i < someWord.Length) {
                if (!alphabet.Contains(someWord[i])) someWord = someWord.Remove(i); else i++;
            }
            return someWord;
        }
    }
}
