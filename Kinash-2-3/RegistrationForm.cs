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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            comboBoxSex.Items.Add("Чоловік");
            comboBoxSex.Items.Add("Жінка");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Activate();
        }
    }
}
