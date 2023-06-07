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
    public partial class gost : Form
    {
        DB dataBase = new DB();

        public gost()
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

        private void Save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Технические работы, попробуйте позже!");
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void gost_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ReadSingleRow(DataGridView dataGridView, IDataRecord record)
        {          
            dataGridView.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetString(7), record.GetString(8));
        }

        private void RefreshDataGrid(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            var query = @"SELECT * FROM kts.participants1";
            dataBase.openConnection();

            var command = new MySqlCommand(query, dataBase.getConnection());

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView, reader);
            }

            dataBase.closeConnection();
        }
    }
}
