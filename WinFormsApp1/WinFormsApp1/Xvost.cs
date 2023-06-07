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
    public partial class Xvost : Form
    {
        DB dataBase = new DB();
        public Xvost()
        {
            InitializeComponent();
            RefreshDataGrid(dataGridView2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ReadSingleRow(DataGridView dataGridView2, IDataRecord record)
        {
            dataGridView2.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetInt32(4), record.GetString(5));
        }

        /// <summary>
        /// Обновить таблицу
        /// </summary>
        /// <param name="dataGridView2">Таблица</param>
        private void RefreshDataGrid(DataGridView dataGridView2)
        {
            try
            {
                dataGridView2.Rows.Clear();

                var query = @"SELECT * FROM popel.xvost";
                dataBase.openConnection();

                var command = new MySqlCommand(query, dataBase.getConnection());

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow(dataGridView2, reader);
                }

                dataBase.closeConnection();

            }

            catch
            {
                MessageBox.Show("ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();


            int i_number = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value);
            string deleteQuery = $"DELETE FROM `xvost` WHERE `id` = {i_number}";


            if (i_number == 0)
            {
                MessageBox.Show("Выберите запись для удаления!");
                return;
            }


            var command = new MySqlCommand(deleteQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            RefreshDataGrid(dataGridView2);

            MessageBox.Show($"Запись под номером {i_number} успешно удалена из таблицы!");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView2);
        }

        private void dot_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new NewDataFormXvost();
            form.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MeinForm form = new MeinForm();
            form.ShowDialog();
        }

        private void Xvost_Load(object sender, EventArgs e)
        {

        }
    }
}
