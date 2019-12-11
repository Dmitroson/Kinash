using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinash_2_3
{
    public partial class DialogForm : Form
    {
        private RegistrationForm form;

        public DialogForm(RegistrationForm form1)
        {
            form = form1;
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "d:"; 
            openFileDialog1.Filter = "All Image files(*.bmp;*.jpeg;*.ico;*.gif;*.jpg)|*.bmp;*.jpeg;*.ico;*.gif;*.jpg"; 
            openFileDialog1.ShowDialog(); 
            try 
            { 
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName); 
            }
            catch 
            {
                MessageBox.Show("Error"); 
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = "d:\\";
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 2; 
            sfd.RestoreDirectory = true;
            DialogResult result = sfd.ShowDialog(); 
            System.IO.Stream fileStream;
            System.IO.MemoryStream userInput = new System.IO.MemoryStream();
            if (result == DialogResult.OK)
            {
                fileStream = sfd.OpenFile();
                userInput.Position = 0;
                userInput.WriteTo(fileStream);
                fileStream.Close();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Owner.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                this.Font = fontDialog1.Font;
                this.ForeColor = fontDialog1.Color;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog(); 
            MyDialog.AllowFullOpen = false; 
            MyDialog.ShowHelp = true; 
            MyDialog.Color = this.BackColor; 
            if (MyDialog.ShowDialog() == DialogResult.OK) this.BackColor = MyDialog.Color;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm(form);
            helpForm.Show();
        }
    }
}