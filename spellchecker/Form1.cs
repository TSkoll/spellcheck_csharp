using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Input input = new Input();
            input.GetWords(inbox.Text);
            input.CheckWords(dict);
            outbox.Text = input.GetString();
        }
    }
}
