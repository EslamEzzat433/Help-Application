﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramingProject.Forms
{
    public partial class Note_Form : Form
    {
        public Note_Form()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            System.IO.File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }
    }
}
