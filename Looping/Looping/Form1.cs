﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Looping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int loopStart = int.Parse(textBox1.Text);
            int loopEnd = int.Parse(textBox2.Text);
            int answer = 0;

            for (int i = loopStart; i < loopEnd; i++)
            {
                answer = answer + i;
            }

            MessageBox.Show(answer.ToString());
        }
    }
}