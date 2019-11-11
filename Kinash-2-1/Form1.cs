using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinash_2_1
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox.Items.Add(comboBox.SelectedItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox.Items.Add("Стіл");
            comboBox.Items.Add("Ручка");
            comboBox.Items.Add("Зошит");
            comboBox.Items.Add("Фломастер");
            comboBox.Items.Add("Олівець");
            listBox.Sorted = true;
            BackColor = Color.FromArgb(120, 170, 225);
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            textBox1.Text = comboBox.Text;
        }

        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckBoxVisible_CheckedChanged(object sender, EventArgs e)
        {
            if(textBox1.Visible == false)
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

        private void CheckBoxEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Enabled == false)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
        }

        private void ListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            this.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            this.ForeColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void Form_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var font = rand.Next(0, 9);
            switch (font)
            {
                case 0: Font = new Font("Arial", 10, FontStyle.Regular); break;
                case 1: Font = new Font("Arial", 10, FontStyle.Bold); break;
                case 2: Font = new Font("Arial", 10, FontStyle.Italic); break;
                case 3: Font = new Font("Times New Roman", 10, FontStyle.Regular); break;
                case 4: Font = new Font("Times New Roman", 10, FontStyle.Bold); break;
                case 5: Font = new Font("Times New Roman", 10, FontStyle.Italic); break;
                case 6: Font = new Font("Calibri", 10, FontStyle.Regular); break;
                case 7: Font = new Font("Calibri", 10, FontStyle.Bold); break;
                case 8: Font = new Font("Calibri", 10, FontStyle.Italic); break;
            }
        }
    }
}
