namespace spellchecker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inbox = new System.Windows.Forms.TextBox();
            this.outbox = new System.Windows.Forms.TextBox();
            this.listSuggest = new System.Windows.Forms.ListBox();
            this.bReplace = new System.Windows.Forms.Button();
            this.bSkip = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bCheck = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your text here:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Word suggestions will appear here:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output:";
            // 
            // inbox
            // 
            this.inbox.Location = new System.Drawing.Point(12, 42);
            this.inbox.Multiline = true;
            this.inbox.Name = "inbox";
            this.inbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inbox.Size = new System.Drawing.Size(260, 297);
            this.inbox.TabIndex = 3;
            // 
            // outbox
            // 
            this.outbox.Location = new System.Drawing.Point(604, 42);
            this.outbox.Multiline = true;
            this.outbox.Name = "outbox";
            this.outbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outbox.Size = new System.Drawing.Size(260, 299);
            this.outbox.TabIndex = 4;
            // 
            // listSuggest
            // 
            this.listSuggest.FormattingEnabled = true;
            this.listSuggest.Location = new System.Drawing.Point(278, 73);
            this.listSuggest.Name = "listSuggest";
            this.listSuggest.Size = new System.Drawing.Size(320, 225);
            this.listSuggest.TabIndex = 5;
            // 
            // bReplace
            // 
            this.bReplace.Enabled = false;
            this.bReplace.Location = new System.Drawing.Point(278, 304);
            this.bReplace.Name = "bReplace";
            this.bReplace.Size = new System.Drawing.Size(75, 23);
            this.bReplace.TabIndex = 6;
            this.bReplace.Text = "Replace";
            this.bReplace.UseVisualStyleBackColor = true;
            this.bReplace.Click += new System.EventHandler(this.bReplace_Click);
            // 
            // bSkip
            // 
            this.bSkip.Enabled = false;
            this.bSkip.Location = new System.Drawing.Point(359, 304);
            this.bSkip.Name = "bSkip";
            this.bSkip.Size = new System.Drawing.Size(75, 23);
            this.bSkip.TabIndex = 7;
            this.bSkip.Text = "Skip";
            this.bSkip.UseVisualStyleBackColor = true;
            this.bSkip.Click += new System.EventHandler(this.bSkip_Click);
            // 
            // bAdd
            // 
            this.bAdd.Enabled = false;
            this.bAdd.Location = new System.Drawing.Point(523, 302);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 37);
            this.bAdd.TabIndex = 8;
            this.bAdd.Text = "Add to dictionary";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bCheck
            // 
            this.bCheck.Location = new System.Drawing.Point(197, 345);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(75, 23);
            this.bCheck.TabIndex = 9;
            this.bCheck.Text = "Check";
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dictionaryToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(876, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dictionaryToolStripMenuItem
            // 
            this.dictionaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDictionaryToolStripMenuItem});
            this.dictionaryToolStripMenuItem.Name = "dictionaryToolStripMenuItem";
            this.dictionaryToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.dictionaryToolStripMenuItem.Text = "Dictionary";
            this.dictionaryToolStripMenuItem.Click += new System.EventHandler(this.dictionaryToolStripMenuItem_Click);
            // 
            // openDictionaryToolStripMenuItem
            // 
            this.openDictionaryToolStripMenuItem.Name = "openDictionaryToolStripMenuItem";
            this.openDictionaryToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.openDictionaryToolStripMenuItem.Text = "Open dictionary";
            this.openDictionaryToolStripMenuItem.Click += new System.EventHandler(this.openDictionaryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.howToUseToolStripMenuItem.Text = "View Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(876, 380);
            this.Controls.Add(this.bCheck);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bSkip);
            this.Controls.Add(this.bReplace);
            this.Controls.Add(this.listSuggest);
            this.Controls.Add(this.outbox);
            this.Controls.Add(this.inbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Spellcheck v0.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inbox;
        private System.Windows.Forms.TextBox outbox;
        private System.Windows.Forms.ListBox listSuggest;
        private System.Windows.Forms.Button bReplace;
        private System.Windows.Forms.Button bSkip;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

