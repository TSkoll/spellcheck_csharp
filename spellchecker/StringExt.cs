using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtended
{
    public static class StringExt
    {
        public static string NormalizeWord(this String someWord)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '\'' };
            int i;

            someWord = someWord.ToLower();
            i = 0;
            while ((someWord.Length > 0) && (!alphabet.Contains(someWord[i])))
            {
                someWord = someWord.Remove(i, 1);
            }
            i = someWord.Length - 1;
            while ((someWord.Length > 0) && (!alphabet.Contains(someWord[i])))
            {
                someWord = someWord.Remove(i, 1);
                i--;
            }

            return someWord;
        }
    }
}
