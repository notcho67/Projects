using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> students = new List<string>();

            students.Add("Jenny");
            students.Add("Peter");
            students.Add("Mary Jane");

            foreach (string child in students)
            {
                listBox1.Items.Add(child);
            }

            students.Add("Azhar");
            listBox1.Items.Add("New Name: " + students[3]);

            students.Sort();

            listBox1.Items.Add("===============");

            foreach (string child in students)
            {
                listBox1.Items.Add(child);
            }
        }
    }
}
