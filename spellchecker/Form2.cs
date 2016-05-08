using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace spellchecker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void InitializeProgressBar(string path)
        {
            progressBar.Minimum = 1;
            progressBar.Maximum = File.ReadLines(path).Count();
            progressBar.Step = 1;
        }
        
        public void PerformStep()
        {
            progressBar.PerformStep();
        }
    }
}
