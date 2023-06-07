using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WinFormsApp1
{
    /// <summary>
    /// Работа с БД.
    /// </summary>
    public class DB
    {
        /// <summary>
        /// Строка подключения.
        /// </summary>
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=89963493390;database=ttss");

        /// <summary>
        /// Открыть соединение.
        /// </summary>
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        /// <summary>
        /// Закрыть соединение.
        /// </summary>
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        /// <summary>
        /// Получить результат соединения.
        /// </summary>
        /// <returns>Соединение.</returns>
        public MySqlConnection getConnection()
        {
            return connection;
        }
       
}
}

