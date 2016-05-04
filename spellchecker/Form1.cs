using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace spellchecker
{
    public partial class Form1 : Form
    {
        private Dictionary dict = new Dictionary();

        public Form1()
        {
            InitializeComponent();
        }

        private void bCheck_Click(object sender, EventArgs e)
        {
            if (!dict.DictionaryLoaded)
                dict.OpenDictionary();
            List<string> inputWords = Input.GetWords(inbox.Text);
            foreach (string word in inputWords)
            {
                object result = dict.SearchForEntry(word);
                if (result is List<string>)
                {
                    foreach (string suggestion in (List<string>)result)
                        listSuggest.Items.Add(suggestion);
                    //Wait for event here - ???
                }
            }
        }
    }
}
