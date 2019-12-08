using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinash_2_2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Location = new Point(50, 25);
            hScrollBarSize.Minimum = 5;
            hScrollBarSize.Maximum = 100;
            hScrollBarSize.LargeChange = 10;

            hScrollBarSpeed.Minimum = 1;
            hScrollBarSpeed.Maximum = 100;
            hScrollBarSpeed.LargeChange = 20;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void buttonMainPicture_Click(object sender, EventArgs e)
        {
            FormAnimation formAnimation = new FormAnimation();
            formAnimation.Owner = this;
            formAnimation.Show();
        }

        protected void buttonMainDiagram_Click(object sender, EventArgs e)
        {
            FormDiagram formDiagram = new FormDiagram();
            formDiagram.Owner = this;
            formDiagram.Show();
        }

        private void buttonMainGraphicObject_Click(object sender, EventArgs e)
        {
            FormGraphicObject formGraphicObject = new FormGraphicObject();
            formGraphicObject.Owner = this;
            formGraphicObject.Show();
        }

        private void hScrollBarSize_Scroll(object sender, ScrollEventArgs e)
        {
            FormAnimation formAnimation = new FormAnimation();
            formAnimation.Owner = this;
            formAnimation.pictureBoxAnimation.Width = formAnimation.Width + hScrollBarSize.Value;
            formAnimation.pictureBoxAnimation.Height = formAnimation.Height + hScrollBarSize.Value;
        }

        private void hScrollBarSpeed_Scroll(object sender, ScrollEventArgs e)
        {
            FormAnimation formAnimation = new FormAnimation();
            formAnimation.Owner = this;
            formAnimation.timerAnimation.Interval = hScrollBarSpeed.Value;
            
        }
    }
}