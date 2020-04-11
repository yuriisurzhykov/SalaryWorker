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
            PostgresInteraction pg = PostgresInteraction.GetInstance();
            Profession profession = new Profession(0, name.Text);
            if (pg.addProfession(profession))
            {
                var res = MessageBox.Show("Профессия успешно добавлена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                switch (res)
                {
                    case DialogResult.OK:
                        Close();
                        break;
                }
            }
            else
            {
                var res = MessageBox.Show("Что-то пошло не так при добавлении профессии!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                switch (res)
                {
                    case DialogResult.OK:
                        Close();
                        break;
                }
            }
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

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
