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
        private Input input;

        public Form1()
        {
            InitializeComponent();
        }

        private void bCheck_Click(object sender, EventArgs e)
        {
            if (!dict.DictionaryLoaded)
            {
                dict.OpenDictionary();
                if (!dict.DictionaryLoaded)
                    MessageBox.Show("Error: You must load a dictionary before proceeding");
                else
                {
                    outbox.Text = "";
                    input = new Input();
                    input.GetWords(inbox.Text);
                    FindMisspell();
                }
            }
            else
            {
                outbox.Text = "";
                input = new Input();
                input.GetWords(inbox.Text);
                FindMisspell();
            }
            
        }

        private void FindMisspell()
        {
            input.FindNextMisspell(dict);
            if (!input.ReachedEnd)
            {
                label2.Text = "We couldn't find this word: '" + input.CurrentWord + "'. Did you mean: ";
                listSuggest.Items.Clear();
                listSuggest.Items.AddRange(input.GetSuggestions(dict).ToArray());
                bSkip.Enabled = true;
                bAdd.Enabled = true;
                if (listSuggest.Items.Count > 0)
                {
                    listSuggest.SelectedIndex = 0;
                    bReplace.Enabled = true;
                }
            }
            else
            {
                label2.Text = "All done!";
                listSuggest.Items.Clear();
                bReplace.Enabled = false;
                bSkip.Enabled = false;
                bAdd.Enabled = false;
                outbox.Text = input.GetString();
            }
        }

        private void bReplace_Click(object sender, EventArgs e)
        {
            input.ReplaceWord(listSuggest.SelectedItem.ToString());
            FindMisspell();
        }

        private void bSkip_Click(object sender, EventArgs e)
        {
            FindMisspell();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dict.AddToDictionary(input.CurrentWord);
            FindMisspell();
        }

        private void openDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dict.OpenDictionary();
        }

        private void dictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}