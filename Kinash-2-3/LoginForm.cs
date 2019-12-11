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
        int n, m;
        RegistrationForm registrationForm = new RegistrationForm();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            n = 0;
            m = 0;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                MessageBox.Show("Користувач не зареєстрований!");
                n++;
                
                registrationForm.Owner = this;
                registrationForm.Show();
            }

            if ((textBoxUser.Text == registrationForm.textBoxUser.Text && textBoxPassword.Text == registrationForm.textBoxPassword.Text) &&
                (textBoxUser.Text != "" && textBoxPassword.Text != "")) 
            {
                DialogForm dialogForm = new DialogForm(registrationForm);
                dialogForm.Owner = this;
                dialogForm.Show();
                this.Hide();
            }
            else
            {
                if (m != 0)
                {
                    MessageBox.Show("Введіть вірний логін та пароль!");
                    
                }
                m++;
            }
        }
    }
}
