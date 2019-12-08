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
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Користувач не зареєстрований!");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Owner = this;
            registrationForm.Show();

            if ((textBoxUser.Text == registrationForm.textBoxUser.Text && textBoxPassword.Text == registrationForm.textBoxPassword.Text) &&
                (textBoxUser.Text != "" && textBoxPassword.Text != "")) 
            {
                DialogForm dialogForm = new DialogForm();
                dialogForm.Owner = this;
                dialogForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Введіть вірний логін та пароль!");

            }
        }
    }
}
