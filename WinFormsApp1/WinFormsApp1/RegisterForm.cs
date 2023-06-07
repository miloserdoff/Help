using MySql.Data.MySqlClient;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 35);




        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void buttonr_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                MessageBox.Show("Логин не указан!");
                return;
            }


            if (passField.Text == "")
            {
                MessageBox.Show("Пароль не указан!");
                return;
            }
            if (userNameField.Text == "")
            {
                MessageBox.Show("Имя не указано!");
                return;
            }

            if (useraSurnameField.Text == "")
            {
                MessageBox.Show("Фамилия не указана!");
                return;
            }

            if (IsUserExist())
                return;


            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `user` (`login`, `pass`, `name`, `surname`) VALUES (@login, @password, @name, @surname)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = useraSurnameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            db.closeConnection();
        }
        public bool IsUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand Command = new MySqlCommand("SELECT * FROM `user` WHERE `login` = @uL", db.getConnection());

            Command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;


            adapter.SelectCommand = Command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже зарегистрирован!");
                return true;
            }

            else
                return false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MeinForm form = new MeinForm();
            form.ShowDialog();
        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void id_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = !passField.UseSystemPasswordChar;
        }
    }


}


