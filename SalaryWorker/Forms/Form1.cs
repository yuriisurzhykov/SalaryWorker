using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using SalaryWorker.DBWorker.Entities;
using SalaryWorker.DBWorker.Postgres;

namespace SalaryWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Accept_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Department dep = new Department(0, textBox1.Text);
            if (PostgresInteraction.GetInstance().addDepartment(dep))
            {
                var res = MessageBox.Show("Отдел успешно добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                switch (res)
                {
                    case DialogResult.OK:
                        Close();
                        break;
                }
            }
            else
            {
                var res = MessageBox.Show("Что-то пошло не так при добавлении отдела!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                switch (res)
                {
                    case DialogResult.OK:
                        Close();
                        break;
                }
            }
        }
    }
}
