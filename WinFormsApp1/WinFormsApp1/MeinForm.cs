using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MeinForm : Form
    {
        public MeinForm()
        {
            InitializeComponent();
        }

        private void closeButton_Enter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_Leave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }


         private void vxod_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void reg_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registorForm = new RegisterForm();
            registorForm.Show();
        }

        private void spravka_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            spravka form = new spravka();
            form.ShowDialog();
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
