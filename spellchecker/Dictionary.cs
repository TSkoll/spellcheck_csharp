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
    public class Dictionary
    {
        private string path = "";
        private List<string>[] dictionary = new List<string>[27];

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
                dictionary[i] = new List<string>();
            }
            using (StreamReader reader2 = new StreamReader(File.OpenRead(path)))
            {
                while (!reader2.EndOfStream)
                {
                    string buffer = reader2.ReadLine();
                    if (Convert.ToInt32(buffer.ToCharArray()[0]) - 97 >= 0)
                        dictionary[buffer[0] - 97].Add(buffer);
                    else
                        dictionary[26].Add(buffer);
                }
            }
        }

        public bool Contains(string someWord)
        {
            if (someWord[0] - 97 >= 0)
                return dictionary[someWord[0] - 97].Contains(someWord);
            else
                return dictionary[26].Contains(someWord);
        }

        public void AddToDictionary(string someWord)
        {
            someWord = someWord.NormalizeWord();
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine();
                sw.Write(someWord);
            }
            if (someWord[0] - 97 >= 0)
                dictionary[someWord[0] - 97].Add(someWord);
            else
                dictionary[26].Add(someWord);
        }
    }
}