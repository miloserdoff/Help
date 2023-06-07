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
    public partial class Kopita : Form
    {
        DB dataBase = new DB();
        public Kopita()
        {
            InitializeComponent();
            RefreshDataGrid(dataGridView1);
        }

        private void ReadSingleRow(DataGridView dataGridView1, IDataRecord record)
        {
            dataGridView1.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetInt32(4), record.GetString(5));
        }

        private void RefreshDataGrid(DataGridView dataGridView1)
        {
            try
            {
                dataGridView1.Rows.Clear();

                var query = @"SELECT * FROM popel.kopita";
                dataBase.openConnection();

                var command = new MySqlCommand(query, dataBase.getConnection());

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow(dataGridView1, reader);
                }

                dataBase.closeConnection();

            }

            catch
            {
                MessageBox.Show("ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dot_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new NewDataFormKopita();
            form.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();


            int i_number = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            string deleteQuery = $"DELETE FROM `kopita` WHERE `id` = {i_number}";


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

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MeinForm form = new MeinForm();
            form.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kopita_Load(object sender, EventArgs e)
        {

        }
    }
}
