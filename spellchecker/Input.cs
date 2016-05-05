using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringExtended;

namespace spellchecker
{
    public class Input
    {
        private List<string> inputWords;
        private int wordCurrent = 0;

        public bool ReachedEnd
        {
            get
            {
                if (wordCurrent < inputWords.Count)
                    return false;
                else
                    return true;
            }
        }

        public string CurrentWord
        {
            get
            {
                return inputWords[wordCurrent];
            }
        }

        public void GetWords(string inputString)
        {
            char[] delim = { ' ' };
            inputWords = inputString.Split(delim, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        public void FindNextMisspell(Dictionary someDictionary)
        {
            while ((wordCurrent < inputWords.Count) && (someDictionary.Contains(inputWords[wordCurrent].NormalizeWord())))
                wordCurrent++;
        }

        public List<string> GetSuggestions(Dictionary someDictionary)
        {
            Edit edits = new Edit();
            List<string> editsList = edits.GetEdits(inputWords[wordCurrent].Normalize());
            List<string> suggestions = new List<string>();
            foreach (string word in editsList)
                if (someDictionary.Contains(word))
                    suggestions.Add(word);
            return suggestions;
        }

        public void ReplaceWord(string correctWord)
        {
            inputWords[wordCurrent] = correctWord;
            wordCurrent++;
        }

        public string GetString()
        {
            string outputString = "";
            foreach (string word in inputWords)
                outputString += word + " ";
            outputString.Remove(outputString.Length-1, 1);
            return outputString;
        }
    }
}
