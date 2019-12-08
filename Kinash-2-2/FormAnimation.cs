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
    public partial class FormAnimation : Form
    {
        int x = 1;
        int y = 1;

        public FormAnimation()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Location = new Point(500, 25);
            timerAnimation.Enabled = true;
            
        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            if (pictureBoxAnimation.Top <= 0 || pictureBoxAnimation.Top >= (ActiveForm.ClientSize.Height - pictureBoxAnimation.Height))
            {
                x = -x;
            }
            pictureBoxAnimation.Top += x;
            if (pictureBoxAnimation.Left <= 0 || pictureBoxAnimation.Left >= (ActiveForm.ClientSize.Width - pictureBoxAnimation.Width))
            {
                y = -y;
            }
            pictureBoxAnimation.Left += y;
        }

        private void pictureBoxAnimation_Click(object sender, EventArgs e)
        {

        }
    }
}
