using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {
                textBox1.Cut();
            }
        }

        private void mnuUndo_Click(object sender, EventArgs e)
        {
            if (textBox1.CanUndo == true)
            {
                textBox1.Undo();
                textBox1.ClearUndo();
            }
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Copy();
            }
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                textBox2.Paste();
            }
        }

        private void mnuViewTextBoxes_Click(object sender, EventArgs e)
        {
            mnuViewTextBoxes.Checked = !mnuViewTextBoxes.Checked;

            if (mnuViewTextBoxes.Checked)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
            }
        }

        private void mnuViewImages_Click(object sender, EventArgs e)
        {
            string Chosen_File = "";

            openFD.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFD.Title = "Insert an Image";
            openFD.FileName = "";
            openFD.Filter = "JPEG Images|*.jpg|GIF Images|*.gif|BITMAPS|*.bmp";

            if (openFD.ShowDialog() != DialogResult.Cancel)
            {
                Chosen_File = openFD.FileName;
                pictureBox1.Image = Image.FromFile(Chosen_File);
            }
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string Chosen_File = "";

            openFD.InitialDirectory = "C:";
            openFD.Title = "Open a Text File";
            openFD.FileName = "";
            openFD.Filter = "Text Files|*.txt|Word Documents|*.doc";

            if (openFD.ShowDialog() != DialogResult.Cancel)
            {
                Chosen_File = openFD.FileName;
                richTextBox1.LoadFile(Chosen_File, RichTextBoxStreamType.PlainText);
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            string Saved_File = "";

            saveFD.InitialDirectory = "C:";
            saveFD.Title = "Save a Text File";
            saveFD.FileName = "";

            saveFD.Filter = "Text Files|*.txt|All Files|*.*";

            if (saveFD.ShowDialog() != DialogResult.Cancel)
            {
                Saved_File = saveFD.FileName;
                richTextBox1.SaveFile(Saved_File, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
