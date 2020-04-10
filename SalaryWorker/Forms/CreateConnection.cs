using SalaryWorker.DBWorker.Postgres;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryWorker
{
    public partial class CreateConnection : Form
    {
        private string server;
        private string user_id;
        private string password;
        private string database;

        public CreateConnection()
        {
            InitializeComponent();
        }

        private void CreateConnection_Load(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            server = server_box.Text;
            user_id = user_name.Text;
            password = password_box.Text;
            database = db_name.Text;
            if (!PostgresConnection.CreateConnectionString(server, user_id, password, database))
            {
                MessageBox.Show("Введены некорректные данные", "Ошибка подключения!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Application.Restart();
            }
        }
    }
}
