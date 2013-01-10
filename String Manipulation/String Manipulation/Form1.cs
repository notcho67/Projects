using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Manipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stringVar = textBox1.Text;

            textBox1.Text = stringVar.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stringTrim = textBox2.Text;

            stringTrim = stringTrim.Trim();

            int stringLength = stringTrim.Length;

            MessageBox.Show(stringLength.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string stringEmail = textBox3.Text;

            int result = stringEmail.IndexOf("@");

            if (result == -1)
            {
                MessageBox.Show("Invalid Email Address");
            }
            else
            {
                MessageBox.Show("@ found at position " + result.ToString());
            }
        }
    }
}
