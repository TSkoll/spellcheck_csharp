using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spellchecker
{
    public class Edit
    {
        public List<string> GetEdits(string someWord)
        {

            List<string> variants = new List<string>();
            if (someWord.Length == 1)
                variants.Add(someWord);
            else
            {
                for (int i = 0; i < someWord.Length; i++)
                    variants.Add(someWord.Remove(i, 1));
            }
            return variants;
        }
    }
}
