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
    public partial class NewDataFormXvost : Form
    {
        DB dataBase = new DB();
        public NewDataFormXvost()
        {
            InitializeComponent();
            textBox6.Text = "xvost";
            textBox6.ReadOnly = true;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            string addQuery = $"INSERT INTO `popel`.`xvost` (`FIOBOSS`, `Product`, `Quantity`, `OrderNumber`, `CompanyName`) VALUES (@FIOBOSS, @Product, @Quantity, @OrderNumber, @CompanyName)";

            MySqlCommand command1 = new MySqlCommand(addQuery, dataBase.getConnection());

            command1.Parameters.Add("@FIOBOSS", MySqlDbType.VarChar).Value = textBox2.Text;
            command1.Parameters.Add("@Product", MySqlDbType.VarChar).Value = textBox3.Text;
            command1.Parameters.Add("@Quantity", MySqlDbType.VarChar).Value = textBox4.Text;
            command1.Parameters.Add("@OrderNumber", MySqlDbType.VarChar).Value = textBox5.Text;
            command1.Parameters.Add("@CompanyName", MySqlDbType.VarChar).Value = textBox6.Text;

            command1.ExecuteNonQuery();
            MessageBox.Show("Запись успешно создана!");
            dataBase.closeConnection();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MeinForm form = new MeinForm();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewDataFormXvost_Load(object sender, EventArgs e)
        {

        }
    }
}
