using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using StringExtended;

namespace spellchecker
{
    public class Dict
    {
        private string path = "";
        private Dictionary<string, List<string>>[] dictionary = new Dictionary<string, List<string>>[27];

        public bool DictionaryLoaded
        {
            get
            {
                return (path != "");
            }
        }

        public void OpenDictionary()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open dictionary file";
            ofd.Filter = "Text File|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                GetDictionary(path);
            }
        }

        private void GetDictionary(string somePath)
        {
            for (int i = 0; i < 27; i++)
            {
                dictionary[i] = new Dictionary<string, List<string>>();
            }
            using (StreamReader reader2 = new StreamReader(File.OpenRead(path)))
            {
                while (!reader2.EndOfStream)
                {
                    string buffer = reader2.ReadLine();
                    if (String.IsNullOrWhiteSpace(buffer))
                        continue;
                    Edit edits = new Edit();
                    List<string> keys = edits.GetEdits(buffer);
                    foreach (string key in keys)
                    {
                        if (Convert.ToInt32(key.ToCharArray()[0]) - 97 >= 0)
                        {
                            if (!dictionary[key[0] - 97].ContainsKey(key))
                                dictionary[key[0] - 97].Add(key, new List<string>());
                            dictionary[key[0] - 97][key].Add(buffer);
                        }
                        else
                        {
                            if (!dictionary[26].ContainsKey(key))
                                dictionary[26].Add(key, new List<string>());
                            dictionary[26][key].Add(buffer);
                        }
                            
                    }                        
                }
            }
        }

        public bool Contains(string someWord)
        {
            bool contains = false;
            Edit edits = new Edit();
            List<string> keys = edits.GetEdits(someWord);
            foreach (string key in keys)
                if (Convert.ToInt32(key.ToCharArray()[0]) - 97 >= 0)
                    if (dictionary[key[0] - 97][key].Contains(someWord))
                    {
                        contains = true;
                        break;
                    }
                else
                    if (dictionary[26][key].Contains(someWord))
                    {
                        contains = true;
                        break;
                    }
            return contains;
        }

        public List<string> GetMatches(string someKey)
        {
            List<string> matches = new List<string>();
            if (Convert.ToInt32(someKey.ToCharArray()[0]) - 97 >= 0)
                matches.AddRange(dictionary[someKey[0] - 97][someKey]);
            else
                matches.AddRange(dictionary[26][someKey]);
            return matches;
        }

        public void AddToDictionary(string someWord)
        {
            someWord = someWord.NormalizeWord();
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine();
                sw.Write(someWord);
            }
            Edit edits = new Edit();
            List<string> keys = edits.GetEdits(someWord);
            foreach (string key in keys)
                if (Convert.ToInt32(key.ToCharArray()[0]) - 97 >= 0)
                    dictionary[key[0] - 97][key].Add(someWord);
                else
                    dictionary[26][key].Add(someWord);
        }
    }
}