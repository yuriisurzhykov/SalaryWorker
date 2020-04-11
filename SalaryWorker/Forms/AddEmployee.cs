using SalaryWorker.DBWorker.Entities;
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
using System.Text.RegularExpressions;

namespace SalaryWorker.Forms
{
    public partial class AddEmployee : Form
    {

        private List<Profession> professions = new List<Profession>();
        private List<Department> departments = new List<Department>();
        private Employee employee;
        private static string passPattern = "([A-Z]{2}[0-9]{6}$)|([А-Я]{2}[0-9]{6}$)|([0-9]{9}$)";

        public AddEmployee()
        {
            InitializeComponent();
            employee = new Employee();
            professions = PostgresInteraction.GetInstance().getAllProfession();
            departments = PostgresInteraction.GetInstance().getAllDepartment();
            foreach (var item in professions)
                comboBox1.Items.Add(item.Name);
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            foreach (var item in departments)
                comboBox2.Items.Add(item.Name);
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            employee.ProfessionId = professions[comboBox1.SelectedIndex].Id;
            Console.WriteLine(employee);
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            employee.DepartmentId = departments[comboBox2.SelectedIndex].Id;
            Console.WriteLine(employee);
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            employee.Birthday = dateTimePicker1.Value;
            Console.WriteLine(employee);
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            employee.Employment = dateTimePicker2.Value;
            Console.WriteLine(employee);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (employee.Birthday == DateTime.Now ||
               employee.DepartmentId == 0 ||
               employee.Employment == DateTime.MinValue ||
               employee.ProfessionId == 0 || 
               employee.Passport == "")
            {
                MessageBox.Show("Не все данные о сотруднике добавлены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (PostgresInteraction.GetInstance().addEmployee(employee))
                {
                    var res = MessageBox.Show("Сотрудник успешно добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    switch (res)
                    {
                        case DialogResult.OK:
                            Close();
                            break;
                    }
                }
                else
                {
                    var res = MessageBox.Show("Что-то пошло не так при добавлении сотрудника!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    switch (res)
                    {
                        case DialogResult.OK:
                            Close();
                            break;
                    }
                }
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(!Regex.IsMatch(textBox1.Text, passPattern))
            {
                textBox1.ForeColor = Color.Red;
                employee.Passport = "";
                Console.WriteLine(employee);
            }
            else
            {
                textBox1.ForeColor = Color.Black;
                employee.Passport = textBox1.Text;
                Console.WriteLine(employee);
            }
        }
    }
}
