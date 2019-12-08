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
    public partial class FormGraphicObject : Form
    {
        Random random = new Random();
        public FormGraphicObject()
        {
            InitializeComponent();
        }

        private void FormGraphicObject_Load(object sender, EventArgs e)
        {
            Location = new Point(500, 475);
            Graphics graphic = pictureBoxGraphicObject.CreateGraphics();
        }

        public void Draw(Graphics graphic)
        {
            Pen BlackPen = new Pen(Color.Black, 3);
            Pen RedPen = new Pen(Color.Red, 3);

            Brush[] brushes = { Brushes.Blue, Brushes.Red, Brushes.Tan, Brushes.Green, Brushes.Orange, Brushes.Gray };
            
            graphic.DrawEllipse(BlackPen, 50, 50, 100, 100);
            graphic.FillEllipse(Brushes.Red, 50, 50, 100, 100);

            if (radioButtonColor.Checked)
            {
                graphic.DrawEllipse(RedPen, 50, 50, 100, 100);
                graphic.FillEllipse(brushes[random.Next(brushes.Length)], 50, 50, 100, 100);
            }
            else if (radioButtonSize.Checked)
            {
                graphic.DrawEllipse(RedPen, 0, 0, 200, 200);
                graphic.FillEllipse(Brushes.Black, 0, 0, 200, 200);
            }
            else {
                graphic.DrawRectangle(RedPen, 50, 50, 100, 100);
                graphic.FillRectangle(Brushes.Black, 50, 50, 100, 100);
            }
        }

        private void radioButtonColor_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxGraphicObject.Refresh();
        }

        private void radioButtonSize_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxGraphicObject.Refresh();
        }

        private void radioButtonShape_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxGraphicObject.Refresh();
        }

        private void pictureBoxGraphicObject_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }
    }
}
