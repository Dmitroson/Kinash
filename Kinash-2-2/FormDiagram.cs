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
    public partial class FormDiagram : Form
    {
        public FormDiagram()
        {
            InitializeComponent();
        }

        private void FormDiagram_Load(object sender, EventArgs e)
        {
            Location = new Point(50, 475);
        }

        public void Display()
        {
            string[] legend = { "Federal", "State", "Local" };
            float[] quantity = { 33, 206, 180 };
            float[] percent = new float[quantity.GetUpperBound(0) + 1];
            float sumOfQuantities = 0;
            float sumOfSweepAngles = 0;
            Brush[] brushes = { Brushes.Blue, Brushes.Red, Brushes.Tan, Brushes.Green, Brushes.Orange, Brushes.Gray };
            Graphics graphic = pictureBoxDiagram.CreateGraphics();
            int r = 100, c = 105;
            for (var i = 0; i <= quantity.GetUpperBound(0); i++)
            {
                sumOfQuantities += quantity[i];
            }
            for (var i = 0; i <= quantity.GetUpperBound(0); i++)
            {
                percent[i] = quantity[i] / sumOfQuantities;
            }
            for (var i = 0; i <= quantity.GetUpperBound(0); i++)
            {
                graphic.FillPie(brushes[i], c - r, c - r, 2 * r, 2 * r, sumOfSweepAngles, percent[i] * 360);
                sumOfSweepAngles += percent[i] * 360;
                graphic.FillRectangle(brushes[i], 220, 20 + 30 * i, 20, 20);
                graphic.DrawString(legend[i], ActiveForm.Font, Brushes.Black, 250, 22 + 30 * i);
            }
        }

        private void pictureBoxDiagram_Paint(object sender, PaintEventArgs e)
        {
            Display();
            pictureBoxDiagram.Refresh();
            pictureBoxDiagram.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
