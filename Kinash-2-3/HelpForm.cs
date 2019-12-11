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
    public partial class HelpForm : Form
    {
        private RegistrationForm form;

        public HelpForm(RegistrationForm form1)
        {
            form = form1;
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            labelLastName.Text = form.textBoxLastName.Text;
            labelName.Text = form.textBoxName.Text;
            labelBirth.Text = form.textBoxBirth.Text;
            labelSex.Text = form.comboBoxSex.Text;
            labelStudentsNumber.Text = form.textBoxStudentsNumber.Text;
            labelGroup.Text = form.textBoxGroup.Text;
            labelAdress.Text = form.textBoxAdress.Text;
            labelEmail.Text = form.textBoxEmail.Text;
            labelUsername.Text = form.textBoxUser.Text;
            labelPassword.Text = form.textBoxPassword.Text;
        }
    }
}
