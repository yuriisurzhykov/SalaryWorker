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
        private Payout payout;
        private Payroll payrollItem;
        private readonly string[] months = new string[12] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        private List<Rates> rates = new List<Rates>();
        private List<Department> departments = new List<Department>();
        private List<Profession> professionEditing = new List<Profession>();
        private List<Rates> editingRates = new List<Rates>();
        private List<Employee> employeesList = new List<Employee>();
        private List<int> selectedEmployees = new List<int>();
        private List<Payroll> payrolls = new List<Payroll>();
        private string passPattern = "([A-Z]{2}[0-9]{6}$)|([А-Я]{2}[0-9]{6}$)|([0-9]{9}$)";

        public MainForm()
        {
            InitializeComponent();
            employee = new Employee();
            payout = new Payout();
            payrollItem = new Payroll();
        }

        private void Month_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            isMonthSelected = true;
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            if (isYearSelected && isMonthSelected)
            {
                payroll.Items.Clear();
                int month = month_comboBox.SelectedIndex + 1;
                int year = (int)year_comboBox.SelectedItem;
                Console.WriteLine(month + ", " + year);
                payrolls.Clear();
                payrolls = PostgresInteraction.GetInstance().getMonthlyPayroll(month, year);
                foreach (var item in payrolls)
                {
                    ListViewItem item1 = new ListViewItem(item.ID.ToString());
                    item1.SubItems.AddRange(new string[] { item.Employee.Passport, item.Department.Name, item.Profession.Name, item.Payout.IssuedBy.ToString() });
                    payroll.Items.Add(item1);
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
            rates = PostgresInteraction.GetInstance().getAllRates();
            departments = PostgresInteraction.GetInstance().getAllDepartment();
            foreach (var item in rates)
                profession_box.Items.Add(item.Profession.Name);
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
            EditingTabControl(e.TabPageIndex);
        }

        private void EditingTabControl(int index)
        {
            isMonthSelected = false;
            isYearSelected = false;
            switch (index)
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
                    payrolls.Clear();
                    payrolls = PostgresInteraction.GetInstance().getAllPayroll();
                    payoutChange.Items.Clear();
                    foreach (var item in payrolls)
                    {
                        SuperPayroll superPayroll = item as SuperPayroll;
                        ListViewItem item1 = new ListViewItem(item.ID.ToString());
                        item1.SubItems.AddRange(new string[] { superPayroll.Employee.Passport, superPayroll.Department.Name, superPayroll.Profession.Name, superPayroll.Payout.IssuedBy.ToString(), superPayroll.Date.ToShortDateString() });
                        payoutChange.Items.Add(item1);
                    }
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
                    EmployeeTabControll(tabControl1.SelectedIndex);
                    break;
                case 3:
                    EditingTabControl(editingTabControl.SelectedIndex);
                    break;
            }
        }

        private void EmployeeTabControll(int pageIndex)
        {
            isMonthSelected = false;
            isYearSelected = false;
            switch (pageIndex)
            {
                case 0:
                    birthday_picker.MaxDate = DateTime.Now;
                    employment_picker.MaxDate = DateTime.Now;
                    employee = new Employee();
                    rates = PostgresInteraction.GetInstance().getAllRates();
                    departments = PostgresInteraction.GetInstance().getAllDepartment();
                    profession_box.Items.Clear();
                    department_box.Items.Clear();
                    foreach (var item in rates)
                        profession_box.Items.Add(item.Profession.Name);
                    foreach (var item in departments)
                        department_box.Items.Add(item.Name);
                    break;
                case 1:
                    Console.WriteLine("Удалить сотрудника");
                    employee_list.View = View.Details;
                    amount.Text = employee_list.CheckedItems.Count.ToString();
                    employee_list.Items.Clear();
                    employeesList.Clear();
                    employeesList = PostgresInteraction.GetInstance().getAllEmployees();
                    foreach (var item in employeesList)
                    {
                        ListViewItem item1 = new ListViewItem(item.Id.ToString());
                        item1.SubItems.AddRange(new string[] { item.Passport, item.Birthday.ToShortDateString(), item.Profession.Name, item.Department.Name, item.Employment.ToShortDateString() });
                        employee_list.Items.Add(item1);
                    }
                    break;
                case 2:
                    employeesList = PostgresInteraction.GetInstance().getAllEmployees();
                    employeePayout.Items.Clear();
                    monthsPayout.Items.Clear();
                    numericUpDown1.Maximum = 100;
                    numericUpDown1.Minimum = 1;
                    foreach (var item in employeesList)
                    {
                        ListViewItem item1 = new ListViewItem(item.Id.ToString());
                        item1.SubItems.AddRange(new string[] { item.Passport, item.Profession.Name, item.Department.Name });
                        employeePayout.Items.Add(item1);
                    }
                    for(int i = 0; i < DateTime.Today.Month; i++)
                    {
                        monthsPayout.Items.Add(months[i]);
                    }
                    break;
                case 3:
                    yearWorst.Items.Clear();
                    monthsWorst.Items.Clear();
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

        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            EmployeeTabControll(e.TabPageIndex);
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

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
                    employeesList.Add(employee);
                    MessageBox.Show("Сотрудник успешно добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Console.WriteLine(employee);
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
            employee.Profession.Id = rates[profession_box.SelectedIndex].Profession.Id;
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
            if(!string.IsNullOrEmpty(dep_name.Text))
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
            else
            {
                MessageBox.Show("Введите название отдела!", "Нет данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        if (!PostgresInteraction.GetInstance().deleteEmployee(employeesList[i]))
                        {
                            successful = false;
                            break;
                        }
                        else
                        {
                            employeesList.RemoveAt(i);
                            employee_list.Items.RemoveAt(i);
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
            if(monthsWorst.SelectedItem != null || yearWorst.SelectedItem != null)
            {
                badEmployeeView.Items.Clear();
                List<BadEmployee> employees = PostgresInteraction.GetInstance().getBadEmployees(monthsWorst.SelectedIndex + 1, (int)yearWorst.SelectedItem);
                foreach (var item in employees)
                {
                    ListViewItem item1 = new ListViewItem(item.Id.ToString());
                    item1.SubItems.AddRange(new string[] { item.Passport, item.Profession.Name, item.Department.Name, item.Employment.ToShortDateString(), item.AmountHours.ToString() });
                    badEmployeeView.Items.Add(item1);
                }
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Button5_Click(object sender, EventArgs e)
        {
            if(employeePayout.CheckedItems.Count != 0)
            {
                if(payout.IssuedBy == 0 ||
                   payout.Date == DateTime.MinValue ||
                   payout.AmountHours == 0)
                {
                    MessageBox.Show("Не все поля для добавления платежа заполнены!", "Не все данные получены!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int amountEmployees = employeePayout.CheckedItems.Count;
                    bool isSuccessful = true;
                    for (int i = 0; i < amountEmployees; i++)
                    {
                        payout.Employee = employeesList[employeePayout.CheckedItems[i].Index];
                        if (!PostgresInteraction.GetInstance().addPayout(payout))
                        {
                            isSuccessful = false;
                            break;
                        }
                    }
                    if (isSuccessful)
                    {
                        MessageBox.Show("Для " + amountEmployees + " сотрудников создан платеж " + payout.IssuedBy, "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("При создании платежа что-то пошло не так!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали ни одного сотрудника!", "Не все данные получены!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(employeePayout.SelectedItems.Count != 0)
            {
                payout.Employee.Id = employeesList[employeePayout.SelectedItems[0].Index].Id;
            }
            Console.WriteLine(payout.Employee);
        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox3.Text))
            {
                payout.IssuedBy = decimal.Parse(textBox3.Text);
                Console.WriteLine(payout);
            }
        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void MonthsPayout_SelectedIndexChanged(object sender, EventArgs e)
        {
            payout.Date = new DateTime(DateTime.Now.Year, monthsPayout.SelectedIndex + 1, 1);
            Console.WriteLine(payout.Date);
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            payout.AmountHours = (int)numericUpDown1.Value;
        }

        private void EmployeePayout_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if(e.Item.Checked)
            {
                selectedEmployees.Add(employeesList[e.Item.Index].Id);
                Console.WriteLine(selectedEmployees.Count);
            }
            else
            {
                selectedEmployees.Remove(employeesList[e.Item.Index].Id);
                Console.WriteLine(selectedEmployees.Count);
            }
        }

        private void ListView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (payoutChange.SelectedItems.Count != 0)
            {
                payrollItem = payrolls[payoutChange.SelectedItems[0].Index];
                Console.WriteLine(payrollItem);
                employeePayoutName.Text = payrollItem.Employee.Passport;
                datePayoutChange.Text = ((SuperPayroll)payrollItem).Date.ToShortDateString();
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Label24_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if((payrollItem as SuperPayroll).Date == DateTime.MinValue ||
                payrollItem.ID == 0 ||
                payrollItem.Payout.IssuedBy != decimal.Parse(textBox4.Text))
            {
                MessageBox.Show("Не выбрана выплата либо не введено новое значение!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(PostgresInteraction.GetInstance().upadtePayout(new Payout(payrollItem.ID, 
                                                                            ((SuperPayroll)payrollItem).Date, 
                                                                            payrollItem.Payout.IssuedBy, 
                                                                            0, 
                                                                            payrollItem.Employee)))
                {
                    EditingTabControl(editingTabControl.SelectedIndex);
                    MessageBox.Show("Данные успешно изменены!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("При изменении что-то пошло не так!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            payrollItem.Payout.IssuedBy = decimal.Parse(textBox4.Text);
        }

        private void СменитьПодключениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostgresConnection.Reconnection();
        }

        private void ДоабвитьСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void НачислениеЗарплатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void СоздатьРасчетToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ДобавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedIndex = 2;
            tabControl1.SelectedIndex = 0;
        }

        private void УдалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedIndex = 2;
            tabControl1.SelectedIndex = 1;
        }

        private void ВыйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ВедомостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedIndex = 1;
        }

        private void СоздатьРасчетToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mainTabControl.SelectedIndex = 4;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedIndex = 2;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedIndex = 3;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedIndex = 4;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Employee_list_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            amount.Text = employee_list.CheckedItems.Count.ToString();
        }
    }
}
