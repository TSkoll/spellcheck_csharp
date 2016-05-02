﻿namespace spellchecker
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your text here:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Word suggestions will appear here:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output:";
            // 
            // inbox
            // 
            this.inbox.Location = new System.Drawing.Point(12, 25);
            this.inbox.Name = "inbox";
            this.inbox.Size = new System.Drawing.Size(260, 20);
            this.inbox.TabIndex = 3;
            // 
            // outbox
            // 
            this.outbox.Location = new System.Drawing.Point(12, 229);
            this.outbox.Name = "outbox";
            this.outbox.Size = new System.Drawing.Size(260, 20);
            this.outbox.TabIndex = 4;
            // 
            // listSuggest
            // 
            this.listSuggest.FormattingEnabled = true;
            this.listSuggest.Location = new System.Drawing.Point(12, 74);
            this.listSuggest.Name = "listSuggest";
            this.listSuggest.Size = new System.Drawing.Size(172, 134);
            this.listSuggest.TabIndex = 5;
            // 
            // bReplace
            // 
            this.bReplace.Location = new System.Drawing.Point(197, 74);
            this.bReplace.Name = "bReplace";
            this.bReplace.Size = new System.Drawing.Size(75, 23);
            this.bReplace.TabIndex = 6;
            this.bReplace.Text = "Replace";
            this.bReplace.UseVisualStyleBackColor = true;
            // 
            // bSkip
            // 
            this.bSkip.Location = new System.Drawing.Point(197, 103);
            this.bSkip.Name = "bSkip";
            this.bSkip.Size = new System.Drawing.Size(75, 23);
            this.bSkip.TabIndex = 7;
            this.bSkip.Text = "Skip";
            this.bSkip.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(197, 132);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 35);
            this.bAdd.TabIndex = 8;
            this.bAdd.Text = "Add to dictionary";
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bSkip);
            this.Controls.Add(this.bReplace);
            this.Controls.Add(this.listSuggest);
            this.Controls.Add(this.outbox);
            this.Controls.Add(this.inbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Spellcheck";
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
    }
}
