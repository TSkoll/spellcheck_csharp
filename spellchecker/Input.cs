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
                if (!someDictionary.Parse(input_words[i])) input_words[i] = input_words[i].ToUpper();
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
    }
}
