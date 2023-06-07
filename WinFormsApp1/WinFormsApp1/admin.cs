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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class admin : Form
    {
        // int status = 1;
        public admin()
        {
            InitializeComponent();
            RefreshDataGrid(dataGridView1);
        }

        DB dataBase = new DB();
        private void closeButton_Enter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_Leave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void ReadSingleRow(DataGridView dataGridView, IDataRecord record)
        {
            dataGridView.Rows.Add(record.GetString(0), record.GetInt32(1));
        }

        private void RefreshDataGrid(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            var query = @"SELECT popel.roga.CompanyName, popel.roga.OrderNumber FROM popel.roga
                        UNION
                        SELECT popel.kopita.CompanyName, popel.kopita.OrderNumber FROM popel.kopita
                        UNION
                        SELECT popel.xvost.CompanyName, popel.xvost.OrderNumber FROM popel.xvost";
            dataBase.openConnection();

            var command = new MySqlCommand(query, dataBase.getConnection());

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView, reader);
            }

            dataBase.closeConnection();
        }

        private void dot_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form = new NewDataFormRoga();
            form.ShowDialog();
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            dataBase.openConnection();


            int i_number = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            string deleteQuery = $"DELETE FROM `information` WHERE `CompaniName` = {i_number}";


            if (i_number == 0)
            {
                MessageBox.Show("Выберите запись для удаления!");
                return;
            }


            var command = new MySqlCommand(deleteQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            RefreshDataGrid(dataGridView1);

            MessageBox.Show($"Запись под номером {i_number} успешно удалена из таблицы!");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            gost form = new gost();
            form.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            moder form = new moder();
            form.ShowDialog();
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

        private void Xvost_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Xvost();
            form.ShowDialog();
        }

        private void Kopita_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Kopita();
            form.ShowDialog();
        }

        private void roga_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Roga();
            form.ShowDialog();
        }

        private void admin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
