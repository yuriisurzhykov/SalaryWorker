using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using SalaryWorker.DBWorker.Interfaces;

namespace SalaryWorker.DBWorker.Postgres
{
    class PostgresConnection : DBConnection
    {
        private static string mainConnStr = "";
        private static PostgresConnection instance = null;

        private static string server;
        private static string user;
        private static string password;
        private static string database;

        private static string[] connection;

        public string ConnectionString { get { return mainConnStr; } }

        public static void CreateConnectionString()
        {
            try
            {
                // Читаем их файла параметры для строки поключения
                connection = File.ReadAllLines(Environment.SpecialFolder.ApplicationData + "conn.txt");
                CreateConnectionString(connection[0],
                                       connection[1],
                                       connection[2],
                                       connection[3]);
                Application.Run(new Form1());
            }
            catch (FileNotFoundException)
            {
                Application.Run(new CreateConnection());
            }
            catch (IndexOutOfRangeException)
            {
                Application.Run(new CreateConnection());
            }
        }

        public static bool CreateConnectionString(string server, string user_id, string password, string database)
        {
            //Попытка подключения к БД
            try
            {
                //Создаем строку подключения
                mainConnStr = "Server=" + server + ";" +
                              "User Id=" + user_id + ";" +
                              "Password=" + password + ";" +
                              "Database=" + database + ";";
                Console.WriteLine(mainConnStr);
                //Пробуем подключиться к БД
                try
                {
                    NpgsqlConnection conn = new NpgsqlConnection(mainConnStr);
                    conn.Open();
                    conn.Close();
                    FileStream fs = new FileStream(Environment.SpecialFolder.ApplicationData + "conn.txt", FileMode.Create);
                    fs.Close();
                    // Записываем в файл настройки для подключения к БД
                    File.WriteAllLines(Environment.SpecialFolder.ApplicationData + "conn.txt",
                                       new string[] { server, user_id, password, database });
                }
                catch (System.Net.Sockets.SocketException)
                {
                    MessageBox.Show("Время ожидания подключения к серверу истекло\n" +
                                    "Проверьте соединение с интернетом и повторите запуск приложения!",
                                    "Время ожидания истекло",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                catch (TimeoutException)
                {
                    MessageBox.Show("Время ожидания подключения к серверу истекло\n" +
                                    "Проверьте соединение с интернетом и повторите запуск приложения!",
                                    "Время ожидания истекло",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                return true;
            }
            catch (PostgresException) // Если что-то пошло не так, значит неправильно 
                                      // указан 1 из 4-х параметров строки подключения
            {
                return false;
            }
            catch (NpgsqlException)
            {
                return false;
            }
        }

        public static PostgresConnection GetConnection()
        {
            if (instance == null)
                instance = new PostgresConnection();
            return instance;
        }
    }
}
