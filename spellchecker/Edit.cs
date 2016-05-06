using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spellchecker
{
    public class Edit
    {
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        private string source;
        private List<string> edits = new List<string>();

        public List<string> GetEdits(string someWord)
        {
            source = someWord;
            edits.AddRange(Remove(source));
            edits.AddRange(Add(source));
            edits.AddRange(Replace(source));
            edits.AddRange(Swap(source));
            return edits;
        }

        private List<string> Remove(string someWord)
        {
            List<string> variants = new List<string>();
            for (int i = 0; i < someWord.Length; i++)
                variants.Add(someWord.Remove(i, 1));
            return variants;
        }

        private List<string> Add(string someWord)
        {
            List<string> variants = new List<string>();
            for (int i = 0; i <= someWord.Length; i++)
                foreach (char letter in alphabet)
                    variants.Add(someWord.Insert(i, letter.ToString()));
            return variants;
        }

        private List<string> Replace(string someWord)
        {
            List<string> variants = new List<string>();
            for (int i = 0; i < someWord.Length; i++)
            {
                foreach (char letter in alphabet)
                {
                    variants.Add(someWord.Remove(i, 1).Insert(i, letter.ToString()));
                }
            }
            return variants;
        }

        private List<string> Swap(string someWord)
        {
            List<string> variants = new List<string>();
            string baseWord = someWord;
            for (int i = 0; i < someWord.Length - 1; i++)
            {
                char c = someWord[i];
                StringBuilder sb = new StringBuilder(someWord);
                sb[i] = sb[i + 1];
                sb[i + 1] = c;
                someWord = sb.ToString();
                variants.Add(someWord);
                someWord = baseWord;
            }
            return variants;
        }
    }
}
