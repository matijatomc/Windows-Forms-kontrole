﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tomcMatijaRichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(@"D:Tempproba.rtf");
            MessageBox.Show("Tekst spremljen");
        }

        private void buttonCitaj_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"D:Tempproba.rtf");
        }

        private void buttonBrisi_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
