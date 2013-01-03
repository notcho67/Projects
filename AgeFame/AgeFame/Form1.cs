using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeFame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;

            age = int.Parse(ageBox.Text);

            if (age < 17)
            {
                MessageBox.Show("Still a youngster.");
            }

            else if (age >= 17 && age <= 24)
            {
                MessageBox.Show("Fame Beckons!");
            }

            else if (age >= 25 && age < 40)
            {
                MessageBox.Show("There's still time.");
            }

            else
            {
                MessageBox.Show("Oh dear, you've probably missed it!");
            }
        }
    }
}
