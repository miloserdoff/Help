using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;



namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 35);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }


        private void label1_MouseMove(object sender, MouseEventArgs e)
        {

        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {
        }

        private void passField_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = !passField.UseSystemPasswordChar;
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            String loginUser = loginField.Text; // Логин пользователя
            String passUser = passField.Text;  // Пароль пользователя


            DB db = new DB(); //подключение бд

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand Command = new MySqlCommand("SELECT * FROM `user` WHERE `login` = @uL  AND`pass` = @uP", db.getConnection());

            Command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            Command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = Command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Успешный вход!");
                var menu = new admin();
                menu.Show();
            }

            else
                MessageBox.Show("Не верный логин или пароль!");
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MeinForm form = new MeinForm();
            form.ShowDialog();
        }
    }
}
