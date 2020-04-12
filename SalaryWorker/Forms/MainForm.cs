using SalaryWorker.DBWorker.Entities;
using SalaryWorker.DBWorker.Postgres;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace SalaryWorker.Forms
{
    public partial class MainForm : Form
    {
        private bool isMonthSelected = false;
        private bool isYearSelected = false;
        private Employee employee;
        private readonly string[] months = new string[12] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        private List<Profession> professions = new List<Profession>();
        private List<Department> departments = new List<Department>();
        private List<Profession> professionEditing = new List<Profession>();
        private List<Rates> editingRates = new List<Rates>();
        private List<Employee> employeesDeleting = new List<Employee>();
        private string passPattern = "([A-Z]{2}[0-9]{6}$)|([А-Я]{2}[0-9]{6}$)|([0-9]{9}$)";

        public MainForm()
        {
            InitializeComponent();
            employee = new Employee();
        }

        private void Month_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            isMonthSelected = true;
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            if (isYearSelected && isMonthSelected)
            {
                this.payroll.Items.Clear();
                int month = month_comboBox.SelectedIndex + 1;
                int year = (int)year_comboBox.SelectedItem;
                Console.WriteLine(month + ", " + year);
                List<Payroll> payroll = PostgresInteraction.GetInstance()
                                                           .getMonthlyPayroll(month, year);
                foreach (var item in payroll)
                {
                    ListViewItem item1 = new ListViewItem(item.ID.ToString());
                    item1.SubItems.AddRange(new string[] { item.Employee.Passport, item.Department.Name, item.Profession.Name, item.Payout.IssuedBy.ToString() });
                    this.payroll.Items.Add(item1);
                }
            }
            else
            {
                MessageBox.Show("Выберите месяц и год за который нужно получить ведомость!", "Не все данные!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Year_comboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            isYearSelected = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            employee = new Employee();
            professions = PostgresInteraction.GetInstance().getAllProfession();
            departments = PostgresInteraction.GetInstance().getAllDepartment();
            foreach (var item in professions)
                profession_box.Items.Add(item.Name);
            foreach (var item in departments)
                department_box.Items.Add(item.Name);
            birthday_picker.MaxDate = DateTime.Now;
            employment_picker.MaxDate = DateTime.Now;
            tabControl1.Selected += TabControl1_Selected;
            mainTabControl.Selected += MainTabControl_Selected;
            editingTabControl.Selected += EditingTabControl_Selected;
        }

        private void EditingTabControl_Selected(object sender, TabControlEventArgs e)
        {
            isMonthSelected = false;
            isYearSelected = false;
            switch (e.TabPageIndex)
            {
                case 0:
                    professionsList.Items.Clear();
                    editingRates.Clear();
                    editingRates = PostgresInteraction.GetInstance().getAllRates();
                    foreach (var item in editingRates)
                    {
                        ListViewItem item1 = new ListViewItem(item.Profession.Name);
                        professionsList.Items.Add(item1);
                    }
                    break;
                case 1:
                    break;
            }
        }

        private void MainTabControl_Selected(object sender, TabControlEventArgs e)
        {
            isMonthSelected = false;
            isYearSelected = false;
            switch (e.TabPageIndex)
            {
                case 0:
                    break;
                case 1:
                    year_comboBox.Items.Clear();
                    for (int i = DateTime.Now.Year; i > 2000; i--)
                    {
                        year_comboBox.Items.Add(i);
                    }
                    break;
                case 2:
                    if (tabControl1.SelectedTab.Name == "addEmployee")
                    {
                        professions = PostgresInteraction.GetInstance().getAllProfession();
                        departments = PostgresInteraction.GetInstance().getAllDepartment();
                        profession_box.Items.Clear();
                        department_box.Items.Clear();
                        foreach (var item in professions)
                            profession_box.Items.Add(item.Name);
                        foreach (var item in departments)
                            department_box.Items.Add(item.Name);
                        birthday_picker.MaxDate = DateTime.Now;
                        employment_picker.MaxDate = DateTime.Now;
                    }
                    break;
                case 3:
                    if (editingTabControl.SelectedIndex == 0)
                    {
                        professionsList.Items.Clear();
                        editingRates.Clear();
                        editingRates = PostgresInteraction.GetInstance().getAllRates();
                        foreach (var item in editingRates)
                        {
                            ListViewItem item1 = new ListViewItem(item.Profession.Name);
                            professionsList.Items.Add(item1);
                        }
                    }
                    break;
            }
        }

        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            isMonthSelected = false;
            isYearSelected = false;
            switch (e.TabPageIndex)
            {
                case 0:
                    birthday_picker.MaxDate = DateTime.Now;
                    employment_picker.MaxDate = DateTime.Now;
                    employee = new Employee();
                    professions = PostgresInteraction.GetInstance().getAllProfession();
                    departments = PostgresInteraction.GetInstance().getAllDepartment();
                    profession_box.Items.Clear();
                    department_box.Items.Clear();
                    foreach (var item in professions)
                        profession_box.Items.Add(item.Name);
                    foreach (var item in departments)
                        department_box.Items.Add(item.Name);
                    break;
                case 1:
                    Console.WriteLine("Удалить сотрудника");
                    employee_list.View = View.Details;
                    employee_list.Items.Clear();
                    employeesDeleting.Clear();
                    employeesDeleting = PostgresInteraction.GetInstance().getAllEmployees();
                    foreach (var item in employeesDeleting)
                    {
                        ListViewItem item1 = new ListViewItem(item.Id.ToString());
                        item1.SubItems.AddRange(new string[] { item.Passport, item.Birthday.ToShortDateString(), item.Profession.Name, item.Department.Name, item.Employment.ToShortDateString() });
                        employee_list.Items.Add(item1);
                    }
                    break;
                case 2:
                    break;
                case 3:
                    yearWorst.Items.Clear();
                    for (int i = 0; i < months.Length; i++)
                    {
                        monthsWorst.Items.Add(months[i]);
                    }
                    for (int i = DateTime.Now.Year; i > 2000; i--)
                    {
                        yearWorst.Items.Add(i);
                    }
                    break;
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(passport_search_field.Text, passPattern))
            {
                passport_search_field.ForeColor = Color.Red;
            }
            else
            {
                passport_search_field.ForeColor = Color.Black;
            }
        }

        private void TextBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(passport_field.Text, passPattern))
            {
                passport_field.ForeColor = Color.Red;
                employee.Passport = "";
                Console.WriteLine(employee);
            }
            else
            {
                passport_field.ForeColor = Color.Black;
                employee.Passport = passport_field.Text;
                Console.WriteLine(employee);
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (employee.Birthday == DateTime.Now ||
               employee.Department.Id == 0 ||
               employee.Employment == DateTime.MinValue ||
               employee.Profession.Id == 0 ||
               employee.Passport == "")
            {
                MessageBox.Show("Не все данные о сотруднике добавлены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (PostgresInteraction.GetInstance().addEmployee(employee))
                {
                    MessageBox.Show("Сотрудник успешно добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так при добавлении сотрудника!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Birthday_picker_ValueChanged(object sender, EventArgs e)
        {
            employee.Birthday = birthday_picker.Value;
            Console.WriteLine(employee);
        }

        private void Employment_picker_ValueChanged(object sender, EventArgs e)
        {
            employee.Employment = employment_picker.Value;
            Console.WriteLine(employee);
        }

        private void Profession_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            employee.Profession.Id = professions[profession_box.SelectedIndex].Id;
            Console.WriteLine(employee);
        }

        private void Department_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            employee.Department.Id = departments[department_box.SelectedIndex].Id;
            Console.WriteLine(employee);
        }

        private void Accept_Click_1(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(prof_name.Text))
            {
                PostgresInteraction pg = PostgresInteraction.GetInstance();
                Rates profession = new Rates(0, decimal.Parse(textBox2.Text), DateTime.Now, new Profession(0, prof_name.Text));
                if (pg.addProfession(profession))
                {
                    MessageBox.Show("Профессия успешно добавлена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так при добавлении профессии!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBox2.Text = "";
                prof_name.Text = "";
            }
            else
            {
                MessageBox.Show("Введены не все необходимые данные!", "Не все данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Department dep = new Department(0, dep_name.Text);
            if (PostgresInteraction.GetInstance().addDepartment(dep))
            {
                MessageBox.Show("Отдел успешно добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Что-то пошло не так при добавлении отдела!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProfessionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(professionsList.SelectedItems.Count != 0)
            {
                amountPerHour.Text = editingRates[professionsList.SelectedItems[0].Index].PayPerHour.ToString();
            }
        }

        private void TextBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (professionsList.SelectedItems.Count != 0)
            {
                Rates rate = editingRates[professionsList.SelectedItems[0].Index];
                rate.PayPerHour = decimal.Parse(textBox1.Text);
                if(PostgresInteraction.GetInstance().changeRates(rate))
                {
                    MessageBox.Show("Данные о ставке для профессии " + rate.Profession.Name + " успешно изменены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так при изменении ставки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Payroll_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Employee_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if(employee_list.CheckedItems.Count != 0)
            {
                var result = MessageBox.Show("Вы точно хотите удалаить " + employee_list.CheckedItems.Count + " сотрудников?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    bool successful = true;
                    for (int i = 0; i < employee_list.CheckedItems.Count; i++)
                    {
                        if (!PostgresInteraction.GetInstance().deleteEmployee(employeesDeleting[i]))
                        {
                            successful = false;
                            break;
                        }
                    }
                    if (successful)
                    {
                        MessageBox.Show("Сотрудники успешно перемещены в архив!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Что-то пошло не так при удалении!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            List<Employee> employees = PostgresInteraction.GetInstance().getBadEmployees();
            foreach(var item in employees)
            {
                ListViewItem item1 = new ListViewItem(item.Id.ToString());
                item1.SubItems.AddRange(new string[] { item.Passport, item.Profession.Name, item.Department.Name, item.Employment.ToShortDateString(), });
                badEmployeeView.Items.Add(item1);
            }
        }
    }
}
